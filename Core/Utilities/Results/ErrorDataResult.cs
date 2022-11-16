using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            T Data = data;
        }

        public ErrorDataResult(T data) : base(data, false)
        {
            T Data = data;
        }

        public ErrorDataResult(string message) : base(default, false)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
