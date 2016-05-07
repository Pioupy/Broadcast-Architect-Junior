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
    public partial class A_GestBtns : UserControl
    {
        List<Command> commands = new List<Command>();
        CommandData command = new CommandData();

        public A_GestBtns()
        {
            InitializeComponent();

            commands = command.readAll();

            foreach (Command item in commands)
            {
                lv_Button.Items.Add(item.getName());
            }
        }

        private void btn_AddBtn_Click(object sender, EventArgs e)
        {
            var PopUp = new A_Gest1Btn();
            PopUp.Show();
        }

        private void btn_EditBtn_Click(object sender, EventArgs e)
        {
           Command buttonSelected = commands.Where(item => item.getName() == lv_Button.SelectedItems[0].Text).FirstOrDefault();

            var PopUp = new A_Gest1Btn(buttonSelected);
            PopUp.Show();
        }
    }
}
