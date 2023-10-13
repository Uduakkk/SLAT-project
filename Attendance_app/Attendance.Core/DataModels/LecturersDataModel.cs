using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class LecturersDataModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public int AccessCode { get; set; }
        public List<LecturerCoursesDataModel> Courses { get; set; }

        public List<LecturesDataModel> Lectures { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;


    }
}
