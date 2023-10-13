using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Students
{
    public class UpdateStudentPhotoApiModel
    {
        public string Id { get; set; }
        public string EncodedPhoto { get; set; }

    }
}
