using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.Routes
{
    public class ApiRoutes
    {
        public const string FetchStudent = "api/student/fetch";
        public const string FetchStudents = "api/students/fetch";
        public const string FetchLecturer = "api/lecturer/fetch";
        public const string FetchLecturerByEmail = "api/lecturer/fetch-by-email";
        public const string FetchLecturers = "api/lecturers/fetch";
        public const string CreateStudent = "api/student/create";
        public const string CreateStudents = "api/students/create";
        public const string CreateLecturer = "api/lecturer/create";
        public const string CreateLecturers = "api/lecturers/create";
        public const string UpdateStudentPhoto = "api/student-photo/update";
        public const string FetchCourse = "api/course/fetch";
        public const string FetchCourses = "api/courses/fetch";
        public const string CreateCourse = "api/course/create";
        public const string CreateCourses = "api/courses/create";
        public const string CreateLecture = "api/lecture/create";

        public const string VerifyStudent = "api/student/verify";
        public const string MarkAttendance = "api/attendance/mark";
        public const string AssignLecturerToCourse = "api/lecturer/assign-course";
        public const string RegisterStudentCourse = "api/student-course/register";
        public const string ValidateStudentAccess = "api/student-access/validate";
        public const string VerifyStudentAccess = "api/student-access/verify";
        public const string ValidateLecturerAccess = "api/lecturer-access/validate";
        public const string VerifyLecturerAccess = "api/lecturer-access/verify";
        public const string FetchLecturerAttendanceRecords = "api/lecturer-attendance-records/fetch";
        public const string FetchLectureAttendees = "api/lecture-attendees/fetch";
        public const string RetrieveStudentsAttendanceRanking = "api/student-attendance-ranking/fetch";
        public const string RetrieveCoursesAttendanceRanking = "api/course-attendance-ranking/fetch";
        public const string RetrieveLecturersAttendanceRanking = "api/lecturer-attendance-ranking/fetch";

    }
}
