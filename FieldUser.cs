using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace vk_api_wf
{
    public class FieldsUser
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "bdate")]
        public string DateBirth { get; set; }
        [JsonProperty(PropertyName = "city")]
        public City City { get; set; }
        [JsonProperty(PropertyName = "country")]
        public Country Country { get; set; }
        [JsonProperty(PropertyName = "friend_status")]
        public int FriendStatus { get; set; }
        [JsonProperty(PropertyName = "crop_photo")]
        public CropPhoto CropPhoto { get; set; }
        [JsonProperty(PropertyName = "items")]
        public List<string> ItemFriends { get; set; }
    }
}
