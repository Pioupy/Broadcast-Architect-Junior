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
        private bool m_isOK = false;
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
                String typeValue = null;
                if (param.getValue() == "1")
                {
                    typeValue = "numérique";
                }
                else
                {
                    typeValue = "caractère";
                }
                label.Text = " Veuillez saisir une valeur pour le paramètre "+param.getName()+" de type "+ typeValue + " : ";
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
            bool isOk = true;
            foreach (Param param in m_listParam)
            {
                TextBox texbox = m_listTextBox[i];
                // check type 
                if (texbox.Text != "")
                {
                    if (param.getValue() == "1") // numérique
                    {
                        int parseValeur = 0;
                        bool result = int.TryParse(texbox.Text, out parseValeur);
                        if (result==false)
                        {
                            isOk = false;
                            MessageBox.Show("Problèmes sur la valeur de getValues not numérique");
                        }
                    }
                    else if (param.getValue() == "2") // charactère
                    {
                        int parseValeur = 0;
                        bool result = int.TryParse(texbox.Text, out parseValeur);
                        if (result == true)
                        {
                            isOk = false;
                            MessageBox.Show("Problèmes sur la valeur de getValues not charactere");
                        }
                    }
                    else
                    {
                        //(param.getValue() > 3 anormal !
                        //text message erreur
                        MessageBox.Show("Problèmes sur la valeur de getValues > 2");
                        isOk = false;
                    }
                }
                else
                {
                    MessageBox.Show("le param " + param.getName() + " n'est pas renseigné");
                }
                i++;
            }
            i = 0;
            if(isOk == true )
            {
                foreach (Param param in m_listParam)
                {
                    TextBox texbox = m_listTextBox[i];
                    m_listParam[i].setValue(texbox.Text);
                    i++;
                }
                setListParam(m_listParam);
                setIsOK(true);
                this.Close();
            }
            else
            {
                //
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //appelle méthode qui annule dans u_addprofil
            setIsOK(false);
            this.Close();
        }

        // [Getter/Setter] List<Param> m_listParam
        public List<Param> getListParam()
        {
            return this.m_listParam;
        }
        public void setListParam(List<Param> listParam)
        {
            this.m_listParam = listParam;
        }
        // [Getter/Setter] Bool m_isOK
        public bool getIsOK()
        {
            return this.m_isOK;
        }
        public void setIsOK(bool isOK)
        {
            this.m_isOK = isOK;
        }
    }
}
