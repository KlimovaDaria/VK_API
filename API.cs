using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.IO;

namespace vk_api_wf
{
    class API
    {

        public static T Get_Info_User<T>(string url)
        {
            object value = null;
            var reqGet = WebRequest.Create(url);
            var resp = reqGet.GetResponse();
            var stream = resp.GetResponseStream();

            if (stream != null)
            {
                //читаем поток в строку
                StreamReader sr = new StreamReader(stream);
                var srToString = sr.ReadToEnd();
                //десериализуем JSON строку в объект
                return JsonConvert.DeserializeObject<T>(srToString);
            }
            //Возвращаем объект
            return (T)value;
        }
    }
}
