using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance.Core.ApiModels.Admin.CreateLecturerApiModel;

namespace Attendance.Core.ApiModels.Admin
{
    public class FetchCoursesApiModel
    {
        public string CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public string CourseDescription { get; set; }
        public List<LecturerApiModel> Lecturers { get; set; }
        public DateTimeOffset DateCreated { get; set; }

    }
}
