using BAJunior.Model;
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
    public partial class U_AddParamInAddProfil : Form
    {
        private List<Param> m_listParam;
        private List<TextBox> m_listTextBox = new List<TextBox>();
        public U_AddParamInAddProfil()
        {
            InitializeComponent();
        }
        public U_AddParamInAddProfil(List<Param> listParam)
        {
            InitializeComponent();
            m_listParam = listParam;
            //Label label = new Label();
            //label.Text = "test";
            //panel_Param.Controls.Add(label);
            int i = 0;
            //List<Label> listPanel;
            //List<TextBox> listTextBox;
            foreach (Param param in listParam)
            {
                Label label = new Label();
                TextBox textbox = new TextBox();
                textbox.Name = "Tb_param" + param.getId();
                label.Name = "Label" + param.getId();
                label.Text = " Veuillez saisir une valeur pour le paramètre "+param.getName()+" de type "+ param.getValue() +" : ";
                textbox.Visible = true;
                label.Visible = true;
                textbox.Location = new Point(500, 0 + i * 50);
                label.Location = new Point(0, 0 + i * 50);
                textbox.Width = 100;
                label.Width = 500;
                label.Show();
                textbox.Show();
                panel_Param.Controls.Add(label);
                panel_Param.Controls.Add(textbox);
                m_listTextBox.Add(textbox);
                i++;
            }
            btn_cancel.Location = new Point(0+ btn_cancel.Location.X, 25 + panel_Param.Height);
            btn_save.Location = new Point(0 + btn_save.Location.X, 25 + panel_Param.Height);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Param param in m_listParam)
            {
                TextBox texbox = m_listTextBox[i];
                if (texbox.Text != "")
                {
                    //enregristrer
                }
                else
                {
                    MessageBox.Show("le param " + param.getName() + "n'est pas renseigner");
                }
                i++;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //appelle méthode qui annule dans u_addprofil
        }
    }
}
