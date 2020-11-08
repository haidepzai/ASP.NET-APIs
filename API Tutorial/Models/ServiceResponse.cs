using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Tutorial
{
    //Für zusätzliche Infos wie Success, Message
    public class ServiceResponse<T> //generic kann z.B. vom Typ Character sein oder vom Typ List<Character> usw
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;

    }
}
