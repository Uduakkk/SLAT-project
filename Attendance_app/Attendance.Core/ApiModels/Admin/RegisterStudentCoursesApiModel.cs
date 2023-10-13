using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Admin
{
    public class RegisterStudentCoursesApiModel
    {
        public string StudentId { get; set; }
        public string[] CourseIds { get; set; }

    }
}
