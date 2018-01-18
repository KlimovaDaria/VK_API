using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace vk_api_wf
{
   public class Response
   {
       [JsonProperty(PropertyName = "response")]
       public User[] response { get; set; }
    }
}
