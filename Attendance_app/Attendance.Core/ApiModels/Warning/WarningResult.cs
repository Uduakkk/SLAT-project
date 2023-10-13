using Attendance.Core.ApiModels.Base;

namespace Attendance.Core.ApiModels.Warning
{
    public class WarningResult
    {

        public List<IssuesApiModel> Warnings { get; set; }
    }
}