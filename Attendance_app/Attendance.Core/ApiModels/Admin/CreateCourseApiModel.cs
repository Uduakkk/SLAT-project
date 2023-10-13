using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Admin
{
    public class CreateCourseApiModel
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get;}
        public int CourseUnit { get; set; }

        public class CourseApiModel
        {
            public string CourseId { get; set; }
            public string CourseTitle { get; set; }
            public string CourseCode { get; set; }
            public int CourseUnit { get; set; }
            public string CourseDescription { get; set; }
        }
    }
}
