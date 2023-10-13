using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class CoursesDataModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Unit {  get; set; }
        public List<LecturesDataModel> Lectures { get; set; }

        public List<LecturerCoursesDataModel> Lecturers { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;


    }
}
