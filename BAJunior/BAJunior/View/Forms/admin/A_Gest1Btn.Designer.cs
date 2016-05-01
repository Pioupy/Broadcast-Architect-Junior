namespace BAJunior.View.Forms.admin
{
    partial class A_Gest1Btn
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addCat = new System.Windows.Forms.Button();
            this.cb_catName = new System.Windows.Forms.ComboBox();
            this.tb_propName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBrowseBtn = new System.Windows.Forms.Button();
            this.tb_imagePath = new System.Windows.Forms.TextBox();
            this.lv_Image = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ParameterImagePB = new System.Windows.Forms.PictureBox();
            this.addParameterBtn = new System.Windows.Forms.Button();
            this.parameterNameCB = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addCat);
            this.groupBox1.Controls.Add(this.cb_catName);
            this.groupBox1.Controls.Add(this.tb_propName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriétés";
            // 
            // btn_addCat
            // 
            this.btn_addCat.Location = new System.Drawing.Point(261, 78);
            this.btn_addCat.Name = "btn_addCat";
            this.btn_addCat.Size = new System.Drawing.Size(29, 24);
            this.btn_addCat.TabIndex = 6;
            this.btn_addCat.Text = "+";
            this.btn_addCat.UseVisualStyleBackColor = true;
            // 
            // cb_catName
            // 
            this.cb_catName.FormattingEnabled = true;
            this.cb_catName.Location = new System.Drawing.Point(91, 78);
            this.cb_catName.Name = "cb_catName";
            this.cb_catName.Size = new System.Drawing.Size(164, 24);
            this.cb_catName.TabIndex = 5;
            // 
            // tb_propName
            // 
            this.tb_propName.Location = new System.Drawing.Point(59, 35);
            this.tb_propName.Name = "tb_propName";
            this.tb_propName.Size = new System.Drawing.Size(231, 22);
            this.tb_propName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catégorie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageBrowseBtn);
            this.groupBox2.Controls.Add(this.tb_imagePath);
            this.groupBox2.Controls.Add(this.lv_Image);
            this.groupBox2.Location = new System.Drawing.Point(3, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // imageBrowseBtn
            // 
            this.imageBrowseBtn.Location = new System.Drawing.Point(215, 147);
            this.imageBrowseBtn.Name = "imageBrowseBtn";
            this.imageBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.imageBrowseBtn.TabIndex = 2;
            this.imageBrowseBtn.Text = "Parcourir";
            this.imageBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // tb_imagePath
            // 
            this.tb_imagePath.Location = new System.Drawing.Point(10, 147);
            this.tb_imagePath.Name = "tb_imagePath";
            this.tb_imagePath.Size = new System.Drawing.Size(199, 22);
            this.tb_imagePath.TabIndex = 1;
            // 
            // lv_Image
            // 
            this.lv_Image.Location = new System.Drawing.Point(10, 32);
            this.lv_Image.Name = "lv_Image";
            this.lv_Image.Size = new System.Drawing.Size(280, 97);
            this.lv_Image.TabIndex = 0;
            this.lv_Image.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ParameterImagePB);
            this.groupBox3.Controls.Add(this.addParameterBtn);
            this.groupBox3.Controls.Add(this.parameterNameCB);
            this.groupBox3.Location = new System.Drawing.Point(524, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paramètres";
            // 
            // ParameterImagePB
            // 
            this.ParameterImagePB.Location = new System.Drawing.Point(10, 63);
            this.ParameterImagePB.Name = "ParameterImagePB";
            this.ParameterImagePB.Size = new System.Drawing.Size(280, 57);
            this.ParameterImagePB.TabIndex = 2;
            this.ParameterImagePB.TabStop = false;
            // 
            // addParameterBtn
            // 
            this.addParameterBtn.Location = new System.Drawing.Point(261, 31);
            this.addParameterBtn.Name = "addParameterBtn";
            this.addParameterBtn.Size = new System.Drawing.Size(29, 24);
            this.addParameterBtn.TabIndex = 1;
            this.addParameterBtn.Text = "+";
            this.addParameterBtn.UseVisualStyleBackColor = true;
            // 
            // parameterNameCB
            // 
            this.parameterNameCB.FormattingEnabled = true;
            this.parameterNameCB.Location = new System.Drawing.Point(10, 32);
            this.parameterNameCB.Name = "parameterNameCB";
            this.parameterNameCB.Size = new System.Drawing.Size(245, 24);
            this.parameterNameCB.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // A_Gest1Btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "A_Gest1Btn";
            this.Size = new System.Drawing.Size(843, 579);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParameterImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_propName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_addCat;
        private System.Windows.Forms.ComboBox cb_catName;
        private System.Windows.Forms.Button imageBrowseBtn;
        private System.Windows.Forms.TextBox tb_imagePath;
        private System.Windows.Forms.ListView lv_Image;
        private System.Windows.Forms.PictureBox ParameterImagePB;
        private System.Windows.Forms.Button addParameterBtn;
        private System.Windows.Forms.ComboBox parameterNameCB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
