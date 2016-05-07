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
    public partial class A_GestApps : UserControl
    {
        List<Model.Application> applications = new List<Model.Application>();
        ApplicationData application = new ApplicationData();

        public A_GestApps()
        {
            InitializeComponent();

            applications = application.readAll();
            foreach (Model.Application item in applications)
            {
                lv_Apps.Items.Add(item.getName());
            }
        }

        private void btn_AddApps_Click(object sender, EventArgs e)
        {
            var PopUp = new A_GestionApplication();
            PopUp.Show();
        }

        private void btn_EditApps_Click(object sender, EventArgs e)
        {
            Model.Application appsSelected = applications.Where(item => item.getName() == lv_Apps.SelectedItems[0].Text).FirstOrDefault();

            var PopUp = new A_GestionApplication(appsSelected);
            PopUp.Show();            
        }

        private void btn_DeleteApps_Click(object sender, EventArgs e)
        {

        }
    }
}
