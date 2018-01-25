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

        private int numberFriend = 0;//номер отображаемого друга
        private List<string> friendsIdList = new List<string>();//список найденных общих друзей
        private const string userGetURL = "https://api.vk.com/method/users.get?user_ids=";//ссылка для получения информации о пользователе
        private const string fiedls = "&fields=country,city,bdate,crop_photo&v=5.69";//
        private const string friendsGetURL="https://api.vk.com/method/friends.get?user_id=";//ссылка для нахождения общих друзей


        #region обработчики кнопок
        private void button_Find_Friends_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                friendsIdList = GetMutualFriends(textBoxUser1ID.Text, textBoxUser2ID.Text);
                DisplayFriendFromList(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Введите корректные Id пользователей");
            }
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            if (numberFriend + 1 < friendsIdList.Count) numberFriend++;
            else numberFriend = 0;
            DisplayFriendFromList(numberFriend);
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            if (numberFriend - 1 >= 0) numberFriend--;
            else numberFriend = friendsIdList.Count - 1;
            DisplayFriendFromList(numberFriend);
        }
        #endregion

        private User GetUser(string user_id)//получение информации о пользователе по его id
        {
            User user = API.GetResponse<User>(userGetURL + user_id + fiedls);
            return user;
        }

        private Friend GetIdFriends(string user_id)//получение списка всех друзей пользователя по его id
        {
            Friend friend = API.GetResponse<Friend>(friendsGetURL + user_id + "&v = 5.69");
            return friend;
        }

        private List<string> GetMutualFriends(string idFriend1, string idFriend2)//нахождение списка id общих друзей
        {
            string user1_id = GetUser(idFriend1).FieldsUserArray[0].Id;
            Friend firstFriend = GetIdFriends(user1_id);
            List<string> firstList = firstFriend.ItemFriends;
            string user2_id = GetUser(idFriend2).FieldsUserArray[0].Id;
            Friend secondFriend = GetIdFriends(user2_id);
            List<string> secondList = secondFriend.ItemFriends;
            numberFriend = 0;
            return firstFriend.GetMutualFriends(secondFriend);
        }


        private void DisplayFriendFromList(int num)//отображение информации о друге по его номеру в списке
        {
            if (friendsIdList.Count != 0)
            {
                User user = GetUser(friendsIdList[num]);//получение информации о друге по его id
                DisplayInfoUser(user);//отображение информации о друге
            }
        }

        #region отображение в форме
        private void DisplayInfoUser(User user)//отображение информации о пользователе
        {
            labelUserName.Text = (user.FieldsUserArray[0].FirstName != null) ? user.FieldsUserArray[0].FirstName : "unknown";
            labelUserSurname.Text = (user.FieldsUserArray[0].LastName != null) ? user.FieldsUserArray[0].LastName : "unknown";
            labelUserCountry.Text = (user.FieldsUserArray[0].Country != null) ? user.FieldsUserArray[0].Country.Title : "unknown";
            labelUserCity.Text = (user.FieldsUserArray[0].City != null) ? user.FieldsUserArray[0].City.Title : "unknown";
            if (user.FieldsUserArray[0].DateBirth != null)
            {
                if (user.FieldsUserArray[0].DateBirth.Length <= 5) user.FieldsUserArray[0].DateBirth += ".XXXX";
                labelUserBirthDate.Text = user.FieldsUserArray[0].DateBirth;
            }
            else 
            labelUserBirthDate.Text =  "unknown";
            string path = user.FieldsUserArray[0].CropPhoto.Photo.PhotoUrl;
            pictureBoxUserPhoto.ImageLocation = path;
            pictureBoxUserPhoto.Load();
        }

        private void ClearForm()
        {
            pictureBoxUserPhoto.Image = null;
            labelUserName.Text = "_";
            labelUserSurname.Text = "_";
            labelUserCountry.Text = "_";
            labelUserCity.Text = "_";
            labelUserBirthDate.Text = "_";
        }
        #endregion
    }
}
