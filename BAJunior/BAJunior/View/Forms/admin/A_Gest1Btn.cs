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
    public partial class A_Gest1Btn : UserControl
    {
        Command actualCommand;
        List<Param> buttonParam;
        CommandData commandData = new CommandData();

        public A_Gest1Btn()
        {
            InitializeComponent();
        }

        public A_Gest1Btn(Command command)
        {
            InitializeComponent();
            actualCommand = command;

            buttonParam = commandData.readParamByCommand(command.getId());

            tb_propName.Text = command.getName();                
            tb_imagePath.Text = command.getPicture();

            if (buttonParam[0].getName() == "vide")
            {
                tb_nom1.Text = "vide";
                tb_valor1.Text = "vide";
            }
            else
            {
                tb_nom1.Text = buttonParam[0].getName();
                tb_valor1.Text = buttonParam[0].getValue();

                if (buttonParam[0].getIsUser())
                    rbtn_custom1.Checked = true;
                else
                    rbtn_fix1.Checked = true;
            }
        }

        private void rbtn_empty1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_empty1.Checked)
            {
                tb_nom1.Enabled = false;
                tb_valor1.Enabled = false;
            }
            else
            {
                tb_nom1.Enabled = true;
                tb_valor1.Enabled = true;
            }
        }

        private void rbtn_empty2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty2.Checked)
            {
                tb_nom2.Enabled = false;
                tb_valor2.Enabled = false;
            }
            else
            {
                tb_nom2.Enabled = true;
                tb_valor2.Enabled = true;
            }
        }

        private void rbtn_empty3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty3.Checked)
            {
                tb_nom3.Enabled = false;
                tb_valor3.Enabled = false;
            }
            else
            {
                tb_nom3.Enabled = true;
                tb_valor3.Enabled = true;
            }
        }

        private void rbtn_empty4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty4.Checked)
            {
                tb_nom4.Enabled = false;
                tb_valor4.Enabled = false;
            }
            else
            {
                tb_nom4.Enabled = true;
                tb_valor4.Enabled = true;
            }
        }

        private void rbtn_empty5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty5.Checked)
            {
                tb_nom5.Enabled = false;
                tb_valor5.Enabled = false;
            }
            else
            {
                tb_nom5.Enabled = true;
                tb_valor5.Enabled = true;
            }
        }

        private void rbtn_empty6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty6.Checked)
            {
                tb_nom6.Enabled = false;
                tb_valor6.Enabled = false;
            }
            else
            {
                tb_nom6.Enabled = true;
                tb_valor6.Enabled = true;
            }
        }

        private void rbtn_empty7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty7.Checked)
            {
                tb_nom7.Enabled = false;
                tb_valor7.Enabled = false;
            }
            else
            {
                tb_nom7.Enabled = true;
                tb_valor7.Enabled = true;
            }
        }

        private void rbtn_empty8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty8.Checked)
            {
                tb_nom8.Enabled = false;
                tb_valor8.Enabled = false;
            }
            else
            {
                tb_nom8.Enabled = true;
                tb_valor8.Enabled = true;
            }
        }

        private void rbtn_empty9_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty9.Checked)
            {
                tb_nom9.Enabled = false;
                tb_valor9.Enabled = false;
            }
            else
            {
                tb_nom9.Enabled = true;
                tb_valor9.Enabled = true;
            }
        }

        private void rbtn_empty10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty10.Checked)
            {
                tb_nom10.Enabled = false;
                tb_valor10.Enabled = false;
            }
            else
            {
                tb_nom10.Enabled = true;
                tb_valor10.Enabled = true;
            }
        }

        private void rbtn_empty11_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty11.Checked)
            {
                tb_nom11.Enabled = false;
                tb_valor11.Enabled = false;
            }
            else
            {
                tb_nom11.Enabled = true;
                tb_valor11.Enabled = true;
            }
        }

        private void rbtn_empty12_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty12.Checked)
            {
                tb_nom12.Enabled = false;
                tb_valor12.Enabled = false;
            }
            else
            {
                tb_nom12.Enabled = true;
                tb_valor12.Enabled = true;
            }
        }

        private void rbtn_empty13_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty13.Checked)
            {
                tb_nom13.Enabled = false;
                tb_valor13.Enabled = false;
            }
            else
            {
                tb_nom13.Enabled = true;
                tb_valor13.Enabled = true;
            }
        }

        private void rbtn_empty14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty14.Checked)
            {
                tb_nom14.Enabled = false;
                tb_valor14.Enabled = false;
            }
            else
            {
                tb_nom14.Enabled = true;
                tb_valor14.Enabled = true;
            }
        }

        private void rbtn_fix1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix1.Checked)
            {
                lbl_type1.Text = " Type  :";
                //tb_valor1.Hide(); cacher la tb et montrer la cb => trop complex
            }
            else
            {
                lbl_type1.Text = "Valeur :";
            }
        }

        private void rbtn_fix2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix2.Checked)
            {
                lbl_type2.Text = " Type  :";
            }
            else
            {
                lbl_type2.Text = "Valeur :";
            }
        }

        private void rbtn_fix3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix3.Checked)
            {
                lbl_type3.Text = " Type  :";
            }
            else
            {
                lbl_type3.Text = "Valeur :";
            }
        }

        private void rbtn_fix4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix4.Checked)
            {
                lbl_type4.Text = " Type  :";
            }
            else
            {
                lbl_type4.Text = "Valeur :";
            }
        }

        private void rbtn_fix5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix5.Checked)
            {
                lbl_type5.Text = " Type  :";
            }
            else
            {
                lbl_type5.Text = "Valeur :";
            }
        }

        private void rbtn_fix6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix6.Checked)
            {
                lbl_type6.Text = " Type  :";
            }
            else
            {
                lbl_type6.Text = "Valeur :";
            }
        }

        private void rbtn_fix7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix7.Checked)
            {
                lbl_type7.Text = " Type  :";
            }
            else
            {
                lbl_type7.Text = "Valeur :";
            }
        }

        private void rbtn_fix8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix8.Checked)
            {
                lbl_type8.Text = " Type  :";
            }
            else
            {
                lbl_type8.Text = "Valeur :";
            }
        }

        private void rbtn_fix9_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix9.Checked)
            {
                lbl_type9.Text = " Type  :";
            }
            else
            {
                lbl_type9.Text = "Valeur :";
            }
        }

        private void rbtn_fix10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix10.Checked)
            {
                lbl_type10.Text = " Type  :";
            }
            else
            {
                lbl_type10.Text = "Valeur :";
            }
        }

        private void rbtn_fix11_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix11.Checked)
            {
                lbl_type11.Text = " Type  :";
            }
            else
            {
                lbl_type11.Text = "Valeur :";
            }
        }

        private void rbtn_fix12_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix12.Checked)
            {
                lbl_type12.Text = " Type  :";
            }
            else
            {
                lbl_type12.Text = "Valeur :";
            }
        }

        private void rbtn_fix13_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix13.Checked)
            {
                lbl_type13.Text = " Type  :";
            }
            else
            {
                lbl_type13.Text = "Valeur :";
            }
        }

        private void rbtn_fix14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix14.Checked)
            {
                lbl_type14.Text = " Type  :";
            }
            else
            {
                lbl_type14.Text = "Valeur :";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (actualCommand != null)
            {
                 actualCommand.setName(tb_propName.Text);
                 actualCommand.setPicture(tb_imagePath.Text);

                if (buttonParam[0].getName() == "vide")
                {
                    tb_nom1.Text = "vide";
                    tb_valor1.Text = "vide";
                }
                else
                {
                    tb_nom1.Text = buttonParam[0].getName();
                    tb_valor1.Text = buttonParam[0].getValue();

                    if (buttonParam[0].getIsUser())
                        rbtn_custom1.Checked = true;
                    else
                        rbtn_fix1.Checked = true;
                }
            }
            else
            {
                actualCommand = new Command(tb_propName.Text, tb_imagePath.Text, cb_catName.TabIndex);
                commandData.create(actualCommand);

                buttonParam.Add(new Param(tb_nom1.Text, tb_valor1.Text, rbtn_custom1.Checked));

                foreach (Param item in buttonParam)
                {

                }
            }
        }
    }
}
