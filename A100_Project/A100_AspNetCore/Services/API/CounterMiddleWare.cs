using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Services.API
{
    public class CounterMiddleWare
    {


        private int i = 0; // счетчик запросов

        public int GetValue
        {
            get =>  ++i;
        }
        
        public void min()
        {
            i--;
        }

        public CounterMiddleWare()
        {
            i = new Random().Next(0, 100000);
        }



        private readonly RequestDelegate _next;

        public CounterMiddleWare(RequestDelegate next)
        {
            this._next = next;
        }
        
        private async Task Plus()
        {
            await Task.Run(() => { i++; });
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await Task.Run(() => { i++; });
            //httpContext.Response.ContentType = "text/html;charset=utf-8";
            //await httpContext.Response.WriteAsync($"Запрос {i}; Counter: {counter.Value}; Service: {counterService.Counter.Value}");
        }
    }
}
