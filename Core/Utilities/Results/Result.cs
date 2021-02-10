using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResults
    {
        

        public Result(bool success, string message):this(success)
            //ctor'da kücük harf yazıyoruz
        {
            Message = message;
            //Success = success;
        }
        //Overloading : aşırı yükleme (Constructor Overloading)
        //Aynı Kod 2 kere DRY : Dont repeat yourself
        public Result(bool success) //ctor'da kücük harf yazıyoruz
        {
            //Message = message;
            Success = success;
        }

        public bool Success { get; }

        public string Message  { get; } //Read only constructor'da sadece set edilir


    }
}
