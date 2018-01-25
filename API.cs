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
    class API //работа с API
    {

        public static T GetResponse<T>(string url)//получение Get запроса и возврат в виде объекта
        {
            string requestText = "";
            WebRequest webRequest=WebRequest.Create(url);
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            if (stream != null)
            {
                StreamReader sr = new StreamReader(stream);
                requestText = sr.ReadToEnd();
            }
            var ob=JsonConvert.DeserializeObject<T>(requestText);
            return ob;
        }
    }
}
