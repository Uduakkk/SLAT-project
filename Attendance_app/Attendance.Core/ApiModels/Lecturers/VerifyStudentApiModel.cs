using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Lecturers
{
    public class VerifyStudentApiModel
    {
        public string CourseId { get; set; }
        public string MatricNumber { get; set; }

    }
}
