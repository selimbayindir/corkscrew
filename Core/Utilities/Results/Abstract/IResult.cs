using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    /// <summary>
    /// Temel Voidler için 
    /// </summary>
    public interface IResult
    {

        bool IsSuccess { get; } //sadece okunabilir

        string Message { get; }


    }
}
