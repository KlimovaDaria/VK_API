using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace vk_api_wf
{
   public class User//класс для работы с пользователем
   {
       [JsonProperty(PropertyName = "response")]
       public List<FieldsUser> FieldsUserArray { get; set; }// поля, которые необходимо получить
    }
}
