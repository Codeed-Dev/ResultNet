using System;

namespace ResultNet
{
    public class ResultError
    {
        public ResultError(string errorMessage)
        {
            this.Message = errorMessage;
        }

        public ResultError(Exception exception) : this(exception.Message)
        {
            this.Exception = exception;
        }

        public string Message { get; private set; }

        public Exception Exception { get; private set; }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
