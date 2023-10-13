using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Admin
{
    public class AssignLecturerToCourseApiModel
    {
        public string CourseId { get; set; }
        public string LecturerId { get; set; }

    }
}
