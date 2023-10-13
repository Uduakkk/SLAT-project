using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance.Core.ApiModels.Admin.CourseAttendanceRecordApiModel;

namespace Attendance.Core.ApiModels.Admin
{
    public class LecturerAttendanceRecordApiModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LecturerEmail { get; set; }

        public int AttendanceCount { get; set; }

        public IEnumerable<LectureAttendanceRecordApiModel> Lectures { get; set; }
    }
}
