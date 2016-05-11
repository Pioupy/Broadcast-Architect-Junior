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

namespace BAJunior.View.Forms.user
{
    public partial class U_AddApplicationInAddProfil : Form
    {
        public U_AddApplicationInAddProfil()
        {
            InitializeComponent();
        }
        public U_AddApplicationInAddProfil(String applicationName)
        {
            InitializeComponent();
            // Recover Application on Database
            ApplicationData applicationData = new ApplicationData();
            List<Model.Application> applicationList = applicationData.readAll();
            for (int i = 0; i < applicationList.Count; i++)
            {
                String application = applicationList[i].getName();
                if (application != applicationName)
                {
                    this.lv_application.Items.Add(application);
                }
            }
        }

        private void lv_application_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
