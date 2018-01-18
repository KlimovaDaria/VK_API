using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.IO;

namespace vk_api_wf
{
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private string user_id;

        private void button_Get_Information_Click(object sender, EventArgs e)
        {
            try
            {
                user_id = textBox_User_ID.Text;
                Response resp = GetUser();
                resp = GetCountry(resp);
                resp = GetCity(resp);
                resp = Get_BirthDay(resp);
                resp = Get_Photo(resp);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введите корректный id пользователя");
            }
            catch (WebException)
            {
                MessageBox.Show("Отсутствует подключение с Интернетом");
            }
        }

        private Response GetUser()
        {
            Response resp = API.Get_Info_User<Response>("https://api.vk.com/method/users.get?user_ids=" + user_id + "&v=5.69");
            label_user_Name.Text = (resp.response[0].first_name != null) ? resp.response[0].first_name : "unknown";
            label_User_Surname.Text = (resp.response[0].last_name != null) ? resp.response[0].last_name : "unknown";
            return resp;
        }

        private Response GetCountry(Response resp)
        {
            resp = API.Get_Info_User<Response>("https://api.vk.com/method/users.get?user_ids=" + user_id + "&fields=country&v=5.69");
            label_User_Country.Text = (resp.response[0].country != null) ? resp.response[0].country.title : "unknown";
            return resp;
        }

        private Response GetCity(Response resp)
        {
            resp = API.Get_Info_User<Response>("https://api.vk.com/method/users.get?user_ids=" + user_id + "&fields=city&v=5.69");
            label_User_City.Text = (resp.response[0].city != null) ? resp.response[0].city.title : "unknown";
            return resp;
        }

        private Response Get_BirthDay(Response resp)
        {
            resp = API.Get_Info_User<Response>("https://api.vk.com/method/users.get?user_ids=" + user_id + "&fields=bdate&v=5.69");
            label_User_BDay.Text = (resp.response[0].bdate != null) ? resp.response[0].bdate : "unknown";
            return resp;
        }

        private Response Get_Photo(Response resp)
        {
            resp = API.Get_Info_User<Response>("https://api.vk.com/method/users.get?user_ids=" + user_id + "&fields=crop_photo&v=5.69");
            string path = resp.response[0].crop_photo.photo.photo_url;
            user_Photo.ImageLocation = path;
            user_Photo.Load();
            return resp;
        }

      
        
    }
}
