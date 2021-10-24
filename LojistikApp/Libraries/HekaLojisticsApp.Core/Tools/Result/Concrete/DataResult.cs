using HekaLojisticsApp.Core.Enum.Status;
using HekaLojisticsApp.Core.Tools.Result.Abstract;
using System;

namespace HekaLojisticsApp.Core.Tools.Result.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {

        public DataResult(ResultStatusEnum resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }

        public DataResult(ResultStatusEnum resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
        }

        public DataResult(ResultStatusEnum resultStatus, string message, T data, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
            Exception = exception;
        }
        public ResultStatusEnum ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public T Data { get; }


    }
}
