﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace A100_Service.Exceptions
{
    // Пользователькое исключение, которое возвращается, в случае, если аккаунт уже подключен к серверу

    [DataContract]
    public class MyException
    {

        private string _ExceptionName;

        [DataMember]
        public string ExceptionName
        {
            get
            {
                return _ExceptionName;
            }
            set
            {
                _ExceptionName = value;
            }
        }

        public MyException()
        {

        }

        public MyException(string ExceptionName)
        {
            this.ExceptionName = ExceptionName;
        }

    }
}
