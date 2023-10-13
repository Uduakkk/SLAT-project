using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Admin
{
    public class CourseAttendanceRecordApiModel
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int AttendanceCount { get; set; }
        public IEnumerable<LectureAttendanceRecordApiModel> Lectures { get; set; }

        public class LectureAttendanceRecordApiModel
        {
            public string LectureTitle { get; set; }

            public int AttendanceCount { get; set; }
        }
    }
}
