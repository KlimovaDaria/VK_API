using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace vk_api_wf
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string first_name { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string last_name { get; set; }
        [JsonProperty(PropertyName = "bdate")]
        public string bdate { get; set; }
        [JsonProperty(PropertyName = "city")]
        public City city { get; set; }
        [JsonProperty(PropertyName = "country")]
        public Country country { get; set; }
        [JsonProperty(PropertyName = "friend_status")]
        public int friend_status { get; set; }
        [JsonProperty(PropertyName = "crop_photo")]
        public Crop_photo crop_photo { get; set; }
    }
}
