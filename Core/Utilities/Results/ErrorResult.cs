using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results//1 inheritance
{
    public class ErrorResult:Result //2 public yaptık
    {
        public ErrorResult(string message) : base(false, message) //3 true -> false | SuccessResult -> ErrorResult
        {

        }

        public ErrorResult() : base(false) //4 true -> false | SuccessResult -> ErrorResult
        {

        }
    }
}
