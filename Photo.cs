using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace vk_api_wf
{
    public class Photo
    {
        [JsonProperty(PropertyName = "photo_130")]
        public string photo_url { get; set; }
    }
}
