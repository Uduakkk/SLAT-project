using Attendance.Core.ApiModels.Base;
using Attendance.Core.ApiModels.Students;
using Attendance.Core.Data;
using Attendance.Core.Routes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Attendance_app.Controllers
{
    public class StudentsController : ControllerBase
    {
        #region Private Members

        private readonly ApplicationDbContext _context;

      
        private readonly IConfiguration _configuration;

        private readonly ILogger<StudentsController> _logger;

        #endregion

        #region Controller

      
        public StudentsController(ApplicationDbContext context, IConfiguration configuration, ILogger<StudentsController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
        }

        #endregion

      
        [HttpGet(ApiRoutes.FetchStudent)]
        public async Task<ApiResponse> FetchStudentAsync([FromQuery] string matricNumber)
        {
            
            string errorMessage = default;

            object result = default;

            try
            {
                
                if (string.IsNullOrEmpty(matricNumber))
                    
                    throw new Exception("Student's matric number is required!");

               
                var student = await _context.Students.FirstOrDefaultAsync(student => student.MatricNo == matricNumber);

                
                result = student ?? throw new Exception($"The matric number: {matricNumber} does not match an existing student");
            }
            catch (Exception ex)
            {
                
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                
                errorMessage = ex.Message;
            }

           
            return new ApiResponse
            {
                Result = result,
                ErrorMessage = errorMessage
            };
        }

        
        [HttpGet(ApiRoutes.FetchStudents)]
        public async Task<ApiResponse> FetchStudentsAsync()
        {
            
            string errorMessage = default;
            object result = default;

            try
            {
                var students = await _context.Students.ToListAsync();
                result = students;
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                errorMessage = ex.Message;
            }

            return new ApiResponse
            {
                Result = result,
                ErrorMessage = errorMessage
            };
        }
        [HttpPost(ApiRoutes.UpdateStudentPhoto)]
        public async Task<ApiResponse> UpdateStudentPhotoAsync([FromBody] UpdateStudentPhotoApiModel model)
        {
            string errorMessage = default;

            try
            {
                if (string.IsNullOrEmpty(model.EncodedPhoto))
                    throw new Exception("This operation require a student\'s photo base 64 encoded format.");
                var student = await _context.Students.FindAsync(model.Id);
                if (student == null)
                    throw new Exception("The specified id does not match a student");

                student.Photo = model.EncodedPhoto;

                _context.Students.Update(student);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                errorMessage = ex.Message;
            }

            return new ApiResponse
            {
                ErrorMessage = errorMessage
            };
        }

       
        [HttpGet(ApiRoutes.ValidateStudentAccess)]
        public async Task<ApiResponse> ValidateStudentAccessAsync([FromQuery] string matricNo)
        {
            string errorMessage = default;

            var result = default(object);

            if (string.IsNullOrEmpty(matricNo))
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;

                return new ApiResponse
                {
                    ErrorMessage = "Student's matric number is required"
                };
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(student => student.MatricNo == matricNo);

            if (student is null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;

                return new ApiResponse
                {
                    ErrorMessage = "A student with the specified matric number does not exist."
                };
            }

            try
            {
                student.AccessCode = new Random().Next(minValue: 100001, maxValue: 999999);

                _context.Students.Update(student);

                await _context.SaveChangesAsync();

                try
                {
                    var userName = _configuration["Email:Username"];

                    var password = _configuration["Email:Password"];

                    string messageBody = @$"<p>Hello {student.FirstName},</p> <p>Your access code is {student.AccessCode}.</p>";

                    var message = new MailMessage(new MailAddress(userName, "Slat | Yaba College of Technology"),
                        new MailAddress(student.Email))
                    {
                        Subject = "Verify Your Access",
                        Body = messageBody,
                        IsBodyHtml = true
                    };

                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Credentials = new NetworkCredential(userName, password);
                        smtpClient.Host = "smtp.outlook.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;

                        smtpClient.Send(message);
                    }
                }
                catch (Exception ex)
                {
                    
                    _logger.LogError(ex.Message);

                    Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    return new ApiResponse
                    {
                        ErrorMessage = "An error occurred while trying to send a validation email."
                    };
                }

                result = new { id = student.Id, email = student.Email, firstName = student.FirstName, lastName = student.LastName, photo = student.Photo };
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                errorMessage = ex.Message;
            }

            return new ApiResponse
            {
                Result = result, 
                ErrorMessage = errorMessage
            };
        }

        
        [HttpGet(ApiRoutes.VerifyStudentAccess)]
        public async Task<ApiResponse> VerifyLecturerAccessAsync([FromQuery] string matricNo, [FromQuery] int accessCode)
        {
            string errorMessage = default;

            var result = default(object);

            try
            {
                if (string.IsNullOrEmpty(matricNo))
                {
                    Response.StatusCode = (int)HttpStatusCode.BadRequest;

                    return new ApiResponse
                    {
                        ErrorMessage = "Student's email is required"
                    };
                }

                if (string.IsNullOrEmpty(accessCode.ToString()))
                {
                    Response.StatusCode = (int)HttpStatusCode.BadRequest;

                    return new ApiResponse
                    {
                        ErrorMessage = "Access code is required"
                    };
                }

                var student = await _context.Students.FirstOrDefaultAsync(student => student.MatricNo == matricNo);

                if (student is null)
                {
                    Response.StatusCode = (int)HttpStatusCode.NotFound;

                    return new ApiResponse
                    {
                        ErrorMessage = "A student with the specified matric number does not exist."
                    };
                }

                if (student.AccessCode != accessCode)
                {
                    Response.StatusCode = (int)HttpStatusCode.Unauthorized;

                    throw new Exception("Invalid access code");
                }

                result = "Valid access code";
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                errorMessage = ex.Message;
            }

            return new ApiResponse
            {
                Result = result,
                ErrorMessage = errorMessage
            };
        }
    }
}
