﻿using BAJunior.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAJunior.View.Forms.user
{
    public partial class U_User : Form
    {
        public U_User()
        {
            InitializeComponent();
        }
        public U_User(User user, String nameProfile, String nameKeyboard, String nameApplication)
        {
            InitializeComponent();
            U_AddProfil addProfile = new U_AddProfil(user, nameProfile, nameKeyboard, nameApplication);
            u_AddProfil = addProfile;
        }
    }
}
