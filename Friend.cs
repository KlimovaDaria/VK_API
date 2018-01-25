using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace vk_api_wf
{
    public class Friend//класс для работы со списком друзей пользователя
    {
        [JsonProperty(PropertyName = "response")]
        public List<string> ItemFriends { get; set; }

        public List<string> GetMutualFriends(Friend anotherFriend)//найти общих друзей
        {
            List<string> MutualFriends = new List<string>();
            foreach (string id in anotherFriend.ItemFriends)
            {
                if (this.ItemFriends.Contains(id))
                    MutualFriends.Add(id);
            }
            return MutualFriends;
        }
    }
}
