using HekaLojisticsApp.Core.Enum.Status;
using System;

namespace HekaLojisticsApp.Core.Tools.Result.Abstract
{
    public interface IResult
    {
        public ResultStatusEnum ResultStatus { get; } // ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }


    }
}