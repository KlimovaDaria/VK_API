using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace vk_api_wf
{
    public class CropPhoto
    {
        [JsonProperty(PropertyName = "photo")]
        public Photo Photo { get; set; }
    }
}
