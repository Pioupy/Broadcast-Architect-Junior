﻿using System;
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
        private U_AddProfil m_addProfil;
        public U_AddApplicationInAddProfil()
        {
            InitializeComponent();
        }
        public U_AddApplicationInAddProfil(U_AddProfil addProfil, List<String> applicationName)
        {
            InitializeComponent();
            m_addProfil = addProfil;
            // Recover Application on Database
            ApplicationData applicationData = new ApplicationData();
            List<Model.Application> applicationList = applicationData.readAll();
            List<String> application = new List<string>();
            for (int i = 0; i < applicationList.Count; i++)
            {
                application.Add(applicationList[i].getName());
                if(!applicationName.Contains(application[i]))
                {
                    this.lv_application.Items.Add(application[i]);
                }
            }
        }

        private void lv_application_DoubleClick(object sender, EventArgs e)
        {
            if (lv_application.SelectedItems.Count > 0)
            {
                int count = lv_application.Items.IndexOf(lv_application.SelectedItems[0]);
                m_addProfil.addApplication(lv_application.Items[count].Text);
                lv_application.Clear();
                this.Close();
            }
        }
    }
}
