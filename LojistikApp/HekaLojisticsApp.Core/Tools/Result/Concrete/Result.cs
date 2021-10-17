using HekaLojisticsApp.Core.Enum.Status;
using HekaLojisticsApp.Core.Tools.Result.Abstract;
using System;

namespace HekaLojisticsApp.Core.Tools.Result.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatusEnum resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatusEnum resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }

        public Result(ResultStatusEnum resultStatus, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }

        public ResultStatusEnum ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
 
    }
}
