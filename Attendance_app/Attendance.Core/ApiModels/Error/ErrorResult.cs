using Attendance.Core.ApiModels.Base;

namespace Attendance.Core.ApiModels.Error
{
    public class ErrorResult
    {
        public List<IssuesApiModel> Errors { get; set; }

    }
}