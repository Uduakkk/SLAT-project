﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Admin
{
    public class StudentAttendanceRecordApiModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatricNo { get; set; }
        public string Email { get; set; }
        public int AttendanceCount { get; set; }

    }
}
