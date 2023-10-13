using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Core.ApiModels.Base
{
    public class IssuesApiModel
    {
        public dynamic Status { get; set; }
        public dynamic Code { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public Source Source { get; set; }

    }

    public class Source
    {
        public string Pointer { get; set; }
        public string Parameter { get; set; }
        public string Example { get; set; }
    }
}
