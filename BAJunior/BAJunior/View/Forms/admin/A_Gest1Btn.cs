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
using System.IO;

namespace BAJunior.View.Forms.admin
{
    public partial class A_Gest1Btn : Form
    {
        Command actualCommand;
        List<Param> buttonParam;
        List<Category> listCat;
        CommandData commandData = new CommandData();
        ParamData paramData = new ParamData();
        JointPCData jointPCData = new JointPCData();
        CategoryData catData = new CategoryData();

        public A_Gest1Btn()
        {
            InitializeComponent();

            listCat = catData.readAll();
            foreach (Category item in listCat)
            {
                cb_catName.Items.Add(item.getName());
            }

            getAllImages();
        }

        public A_Gest1Btn(Command command)
        {
            InitializeComponent();
            actualCommand = command;

            buttonParam = commandData.readParamByCommand(command.getId());

            tb_propName.Text = command.getName();
            //    tb_imagePath.Text = command.getPicture();

            getAllImages();

            if (buttonParam[0].getName() == "vide")
            {
                tb_nom1.Text = "";
                tb_valor1.Text = "";
                rbtn_empty1.Checked = true;
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

            if (buttonParam[1].getName() == "vide")
            {
                tb_nom2.Text = "";
                tb_valor2.Text = "";
                rbtn_empty2.Checked = true;
            }
            else
            {
                tb_nom2.Text = buttonParam[1].getName();
                tb_valor2.Text = buttonParam[1].getValue();

                if (buttonParam[1].getIsUser())
                    rbtn_custom2.Checked = true;
                else
                    rbtn_fix2.Checked = true;
            }

            if (buttonParam[2].getName() == "vide")
            {
                tb_nom3.Text = "";
                tb_valor3.Text = "";
                rbtn_empty3.Checked = true;
            }
            else
            {
                tb_nom3.Text = buttonParam[2].getName();
                tb_valor3.Text = buttonParam[2].getValue();

                if (buttonParam[2].getIsUser())
                    rbtn_custom3.Checked = true;
                else
                    rbtn_fix3.Checked = true;
            }

            if (buttonParam[3].getName() == "vide")
            {
                tb_nom4.Text = "";
                tb_valor4.Text = "";
                rbtn_empty4.Checked = true;
            }
            else
            {
                tb_nom4.Text = buttonParam[3].getName();
                tb_valor4.Text = buttonParam[3].getValue();

                if (buttonParam[3].getIsUser())
                    rbtn_custom4.Checked = true;
                else
                    rbtn_fix4.Checked = true;
            }

            if (buttonParam[4].getName() == "vide")
            {
                tb_nom5.Text = "";
                tb_valor5.Text = "";
                rbtn_empty5.Checked = true;
            }
            else
            {
                tb_nom5.Text = buttonParam[4].getName();
                tb_valor5.Text = buttonParam[4].getValue();

                if (buttonParam[4].getIsUser())
                    rbtn_custom5.Checked = true;
                else
                    rbtn_fix5.Checked = true;
            }

            if (buttonParam[5].getName() == "vide")
            {
                tb_nom6.Text = "";
                tb_valor6.Text = "";
                rbtn_empty6.Checked = true;
            }
            else
            {
                tb_nom6.Text = buttonParam[5].getName();
                tb_valor6.Text = buttonParam[5].getValue();

                if (buttonParam[5].getIsUser())
                    rbtn_custom6.Checked = true;
                else
                    rbtn_fix6.Checked = true;
            }

            if (buttonParam[6].getName() == "vide")
            {
                tb_nom7.Text = "";
                tb_valor7.Text = "";
                rbtn_empty7.Checked = true;
            }
            else
            {
                tb_nom7.Text = buttonParam[6].getName();
                tb_valor7.Text = buttonParam[6].getValue();

                if (buttonParam[6].getIsUser())
                    rbtn_custom7.Checked = true;
                else
                    rbtn_fix7.Checked = true;
            }

            if (buttonParam[7].getName() == "vide")
            {
                tb_nom8.Text = "";
                tb_valor8.Text = "";
                rbtn_empty8.Checked = true;
            }
            else
            {
                tb_nom8.Text = buttonParam[7].getName();
                tb_valor8.Text = buttonParam[7].getValue();

                if (buttonParam[7].getIsUser())
                    rbtn_custom8.Checked = true;
                else
                    rbtn_fix8.Checked = true;
            }

            if (buttonParam[8].getName() == "vide")
            {
                tb_nom9.Text = "";
                tb_valor9.Text = "";
                rbtn_empty9.Checked = true;
            }
            else
            {
                tb_nom9.Text = buttonParam[8].getName();
                tb_valor9.Text = buttonParam[8].getValue();

                if (buttonParam[8].getIsUser())
                    rbtn_custom9.Checked = true;
                else
                    rbtn_fix9.Checked = true;
            }

            if (buttonParam[9].getName() == "vide")
            {
                tb_nom10.Text = "";
                tb_valor10.Text = "";
                rbtn_empty10.Checked = true;
            }
            else
            {
                tb_nom10.Text = buttonParam[9].getName();
                tb_valor10.Text = buttonParam[9].getValue();

                if (buttonParam[9].getIsUser())
                    rbtn_custom10.Checked = true;
                else
                    rbtn_fix10.Checked = true;
            }

            if (buttonParam[10].getName() == "vide")
            {
                tb_nom11.Text = "";
                tb_valor11.Text = "";
                rbtn_empty11.Checked = true;
            }
            else
            {
                tb_nom11.Text = buttonParam[10].getName();
                tb_valor11.Text = buttonParam[10].getValue();

                if (buttonParam[10].getIsUser())
                    rbtn_custom11.Checked = true;
                else
                    rbtn_fix11.Checked = true;
            }

            if (buttonParam[11].getName() == "vide")
            {
                tb_nom12.Text = "";
                tb_valor12.Text = "";
                rbtn_empty12.Checked = true;
            }
            else
            {
                tb_nom12.Text = buttonParam[11].getName();
                tb_valor12.Text = buttonParam[11].getValue();

                if (buttonParam[11].getIsUser())
                    rbtn_custom12.Checked = true;
                else
                    rbtn_fix12.Checked = true;
            }

            if (buttonParam[12].getName() == "vide")
            {
                tb_nom13.Text = "";
                tb_valor13.Text = "";
                rbtn_empty13.Checked = true;
            }
            else
            {
                tb_nom13.Text = buttonParam[12].getName();
                tb_valor13.Text = buttonParam[12].getValue();

                if (buttonParam[12].getIsUser())
                    rbtn_custom13.Checked = true;
                else
                    rbtn_fix13.Checked = true;
            }

            if (buttonParam[13].getName() == "vide")
            {
                tb_nom14.Text = "";
                tb_valor14.Text = "";
                rbtn_empty14.Checked = true;
            }
            else
            {
                tb_nom14.Text = buttonParam[13].getName();
                tb_valor14.Text = buttonParam[13].getValue();

                if (buttonParam[13].getIsUser())
                    rbtn_custom14.Checked = true;
                else
                    rbtn_fix14.Checked = true;
            }
        }

        private void rbtn_empty1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_empty1.Checked)
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

            if (listCat.Where(item => item.getName() == cb_catName.Text).Count() > 0)
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
                    buttonParam = new List<Param>();

                    actualCommand = new Command(tb_propName.Text, tb_imagePath.Text, listCat.Where(item => item.getName() == cb_catName.Text).FirstOrDefault().getId());
                    commandData.create(actualCommand);
                    int newCommandId = commandData.readAll().Where(item => item.getName() == actualCommand.getName()).FirstOrDefault().getId();

                    if (rbtn_empty1.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom1.Text, tb_valor1.Text, rbtn_custom1.Checked));
                    if (rbtn_empty2.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom2.Text, tb_valor2.Text, rbtn_custom2.Checked));
                    if (rbtn_empty3.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom3.Text, tb_valor3.Text, rbtn_custom3.Checked));
                    if (rbtn_empty4.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom4.Text, tb_valor4.Text, rbtn_custom4.Checked));
                    if (rbtn_empty5.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom5.Text, tb_valor5.Text, rbtn_custom5.Checked));
                    if (rbtn_empty6.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom6.Text, tb_valor6.Text, rbtn_custom6.Checked));
                    if (rbtn_empty7.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom7.Text, tb_valor7.Text, rbtn_custom7.Checked));
                    if (rbtn_empty8.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom8.Text, tb_valor8.Text, rbtn_custom8.Checked));
                    if (rbtn_empty9.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom9.Text, tb_valor9.Text, rbtn_custom9.Checked));
                    if (rbtn_empty10.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom10.Text, tb_valor10.Text, rbtn_custom10.Checked));
                    if (rbtn_empty11.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom11.Text, tb_valor11.Text, rbtn_custom11.Checked));
                    if (rbtn_empty12.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom12.Text, tb_valor12.Text, rbtn_custom12.Checked));
                    if (rbtn_empty13.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom13.Text, tb_valor13.Text, rbtn_custom13.Checked));
                    if (rbtn_empty14.Checked)
                        buttonParam.Add(new Param("vide", "vide", false));
                    else
                        buttonParam.Add(new Param(tb_nom14.Text, tb_valor14.Text, rbtn_custom14.Checked));

                    foreach (Param item in buttonParam)
                    {
                        paramData.create(item);
                        jointPCData.create(new JointPC(item.getId(), commandData.readByName(actualCommand.getName()).getId()));
                    }

                    Form.ActiveForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une catégorie.");
            }
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            if (cb_catName.Text != null && cb_catName.Text != "")
            {
                catData.create(new Category(cb_catName.Text));
                refreshComboBoxCat();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une catégorie.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_catName.Text != null && cb_catName.Text != "")
            {
                catData.delete(listCat.Where(item => item.getName() == cb_catName.Text).FirstOrDefault());
                cb_catName.Text = "";
                refreshComboBoxCat();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une catégorie.");
            }
        }

        public void refreshComboBoxCat()
        {
            cb_catName.Items.Clear();
            listCat.Clear();

            listCat = catData.readAll();
            foreach (Category item in listCat)
            {
                cb_catName.Items.Add(item.getName());
            }
        }

        public void getAllImages()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            path = path.Replace("file:\\", "");

            il_AddBtn.Images.Clear();
            lv_Image.Items.Clear();

            DirectoryInfo directory = new DirectoryInfo(@path);
            FileInfo[] Archives = directory.GetFiles("*.bmp");

            foreach (FileInfo fileinfo in Archives)
            {
                il_AddBtn.Images.Add(Image.FromFile(fileinfo.FullName));
                //lv_Image.Items.Add(Image.FromFile(fileinfo.FullName));
            }

            //  lv_Image.LargeImageList = il_AddBtn;

            //lv_Image.View = View.LargeIcon;
            il_AddBtn.ImageSize = new Size(21, 21);
            lv_Image.LargeImageList = il_AddBtn;

            for (int j = 0; j < il_AddBtn.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                lv_Image.Items.Add(item);
            }
        }

        private void Btn_imageBrowse_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + Properties.Settings.Default.DefaultImagePath;
            path = path.Replace("file:\\", "");
            //TODO Peut etre deplacer ça dans le dossier application data, pour les droits 
            //var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //var complete = Path.Combine(systemPath, Properties.Settings.Default.DefaultImagePath);

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string newImage = path + "\\" + openFileDialog2.SafeFileName;
                if (File.Exists(newImage))
                {
                    int i = 1;
                    string fileName = openFileDialog2.SafeFileName.Replace(".bmp", "");
                    newImage = path + "\\" + fileName + "(" + (i) + ").bmp";

                    while (File.Exists(newImage))
                    {
                        i++;
                        newImage = path + "\\" + fileName + "(" + (i) + ").bmp";
                    }
                }

                File.Copy(openFileDialog2.FileName, newImage);
                this.tb_imagePath.Text = newImage;
                getAllImages();
            }
        }
    }
}
