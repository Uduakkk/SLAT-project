using Attendance.Core.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        /// <param name="options">The database options</param>
        /// <param name="operationalStoreOptions">The operational store options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<AdminsDataModel> Admins { get; set; }
        public DbSet<StudentsDataModel> Students { get; set; }
        public DbSet<LecturersDataModel> Lecturers { get; set; }

        public DbSet<AttendeesDataModel> Attendees { get; set; }

        public DbSet<LecturesDataModel> Lectures { get; set; }

        public DbSet<CoursesDataModel> Courses { get; set; }

        public DbSet<LecturerCoursesDataModel> LecturerCourses { get; set; }

        public DbSet<StudentCoursesDataModel> StudentCourses { get; set; }
    }
}

