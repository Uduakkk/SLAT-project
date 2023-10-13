using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.DataModels
{
    public class AdminsDataModel
    {
        public string Id { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

    }
}
