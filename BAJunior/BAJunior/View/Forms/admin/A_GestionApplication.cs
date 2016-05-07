using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAJunior.ServiceData;
using BAJunior.Model;

namespace BAJunior.View.Forms.admin
{
    public partial class A_GestionApplication : Form
    {
        Model.Application actualApps;

        public A_GestionApplication()
        {
            InitializeComponent();
        }

        public A_GestionApplication(Model.Application sendApps)
        {
            InitializeComponent();

            actualApps = sendApps;

            tb_NameApps.Text = sendApps.getName();
            tb_AppsPath.Text = sendApps.getLink();
        }

        private void btn_saveApps_Click(object sender, EventArgs e)
        {
            ApplicationData bdd = new ApplicationData();
            if (actualApps != null)
            {
                actualApps.setName(tb_NameApps.Text);
                actualApps.setLink(tb_AppsPath.Text);

                bdd.update(actualApps);
            }
            else
            {
                actualApps = new Model.Application(tb_NameApps.Text, tb_AppsPath.Text);
                bdd.create(actualApps);
            }

            Form.ActiveForm.Close();
        }
    }
}
