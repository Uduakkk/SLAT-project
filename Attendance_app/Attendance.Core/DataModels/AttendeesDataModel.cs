using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class AttendeesDataModel
    {
        
        public string Id { get; set; }
        public string LectureId { get; set; }
        public string StudentId { get; set; }

        [ForeignKey(nameof(LectureId))]
        public LecturesDataModel Lecture { get; set; }

        [ForeignKey(nameof(StudentId))]
        public StudentsDataModel Student { get; set; }

        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

    }
}
