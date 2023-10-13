using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class LecturerCoursesDataModel
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string LecturerId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }

        [ForeignKey(nameof(LecturerId))]
        public LecturersDataModel Lecturer { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

    }
}
