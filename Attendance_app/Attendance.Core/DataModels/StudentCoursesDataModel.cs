using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class StudentCoursesDataModel
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public StudentsDataModel Student { get; set; }
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

    }
}
