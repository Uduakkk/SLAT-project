using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Attendance.Core.ApiModels.Admin.CreateCourseApiModel;

namespace Attendance.Core.ApiModels.Lecturers
{
    public class FetchLecturerAttendanceRecordApiModel
    {
        public List<CoursesApiModel> Courses { get; set; }

    }

    public class CoursesApiModel
    {
        public string CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public string CourseDescription { get; set; }
        public IEnumerable<CourseLectureApiModel> Lectures { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }

    public class CourseLectureApiModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<LectureAttendeeApiModel> Attendees { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }

    public class LectureAttendeeApiModel
    {
        public string MatricNo { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
