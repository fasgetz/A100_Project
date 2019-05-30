using System;
using Newtonsoft.Json;

namespace JsonLibrary
{
    /// <summary>
    /// Класс предоставляет функционал для работы с Json
    /// </summary>


    public static partial class JsonFunctional
    {

        // Метод который выполняет сериализацию объекта и возвращает Json
        public static string GetJson(object json)
        {
            try
            {
                return JsonConvert.SerializeObject(json);
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        // Метод, который выполняет дессериализацию json и возвращает объект типа T
        public static T GetObjects<T>(string json)
            where T: class
        {
            return JsonConvert.DeserializeObject<T>(json);

        }
    }
}
