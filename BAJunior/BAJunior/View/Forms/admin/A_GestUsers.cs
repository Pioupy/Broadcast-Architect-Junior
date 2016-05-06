using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.ServiceData;
using BAJunior.Model;

namespace BAJunior.View.Forms.admin
{
    public partial class A_GestUsers : UserControl
    {
        List<User> users = new List<User>();

        public A_GestUsers()
        {
            InitializeComponent();

            UserData user = new UserData();
            users = user.readAll();

            foreach (User item in users)
            {
                lv_User.Items.Add(item.getLogin());
            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            var PopUp = new A_Gest1Users();
            PopUp.Show();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            User userSelected = users.Where(item => item.getLogin() == lv_User.SelectedItems[0].Text).FirstOrDefault();

            var PopUp = new A_Gest1Users(userSelected.getLogin(), userSelected.getPassword(), userSelected.isAdmin());
            PopUp.Show();
        }
    }
}
