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

        private void lv_Apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_NameApps.Text = lv_Apps.SelectedItems[0].Text;
        }

        private void btn_saveApps_Click(object sender, EventArgs e)
        {
            Model.Application appTmp = applications.Where(item => item.getName() == tb_NameApps.Text).FirstOrDefault();

            if (appTmp != null)
            {
                application.update(appTmp);
            }
            else
            {
                application.create(new Model.Application(tb_NameApps.Text,tb_ApplicationFolder.Text));
            }

            tb_NameApps.Text = "";
            lv_Apps.Refresh();
        }
    }
}
