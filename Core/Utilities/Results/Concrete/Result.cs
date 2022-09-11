﻿using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool ısSuccess, string message) : this(ısSuccess)
        {
            //IsSuccess = ısSuccess;
            Message = message;
        }

        public Result(bool ısSuccess)
        {
            IsSuccess = ısSuccess; ///:this(ısSuccess)
        }
  

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
