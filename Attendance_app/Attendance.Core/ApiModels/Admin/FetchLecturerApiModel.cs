using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance.Core.ApiModels.Admin.CreateCourseApiModel;

namespace Attendance.Core.ApiModels.Admin
{
    public class FetchLecturerApiModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<CourseApiModel> Courses { get; set; }
        public string Photo { get; set; }

    }
}
