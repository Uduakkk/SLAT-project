using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Lecturers
{
    public class CreateLectureApiModel
    {
        public string LecturerId { get; set; }
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
