using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool ısSuccess)
        {
            IsSuccess = ısSuccess; ///:this(ısSuccess)
        }
        public Result(bool ısSuccess, string message) :this(ısSuccess)
        {
            IsSuccess = ısSuccess;
            Message = message;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
