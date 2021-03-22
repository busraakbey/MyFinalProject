using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidleriçin başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; } 
    }
}
