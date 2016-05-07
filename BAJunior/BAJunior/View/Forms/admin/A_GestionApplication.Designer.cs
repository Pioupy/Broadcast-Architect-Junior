namespace BAJunior.View.Forms.admin
{
    partial class A_GestionApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_application = new System.Windows.Forms.Label();
            this.tb_NameApps = new System.Windows.Forms.TextBox();
            this.btn_saveApps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AppsPath = new System.Windows.Forms.TextBox();
            this.btn_appsPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // l_application
            // 
            this.l_application.AutoSize = true;
            this.l_application.Location = new System.Drawing.Point(31, 60);
            this.l_application.Name = "l_application";
            this.l_application.Size = new System.Drawing.Size(143, 17);
            this.l_application.TabIndex = 0;
            this.l_application.Text = "Nom de l\'application :";
            // 
            // tb_NameApps
            // 
            this.tb_NameApps.Location = new System.Drawing.Point(193, 57);
            this.tb_NameApps.Name = "tb_NameApps";
            this.tb_NameApps.Size = new System.Drawing.Size(230, 22);
            this.tb_NameApps.TabIndex = 1;
            // 
            // btn_saveApps
            // 
            this.btn_saveApps.Location = new System.Drawing.Point(246, 171);
            this.btn_saveApps.Name = "btn_saveApps";
            this.btn_saveApps.Size = new System.Drawing.Size(85, 33);
            this.btn_saveApps.TabIndex = 2;
            this.btn_saveApps.Text = "Valider";
            this.btn_saveApps.UseVisualStyleBackColor = true;
            this.btn_saveApps.Click += new System.EventHandler(this.btn_saveApps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chemin de l\'application :";
            // 
            // tb_AppsPath
            // 
            this.tb_AppsPath.Location = new System.Drawing.Point(193, 109);
            this.tb_AppsPath.Name = "tb_AppsPath";
            this.tb_AppsPath.Size = new System.Drawing.Size(230, 22);
            this.tb_AppsPath.TabIndex = 4;
            // 
            // btn_appsPath
            // 
            this.btn_appsPath.Location = new System.Drawing.Point(445, 104);
            this.btn_appsPath.Name = "btn_appsPath";
            this.btn_appsPath.Size = new System.Drawing.Size(85, 33);
            this.btn_appsPath.TabIndex = 5;
            this.btn_appsPath.Text = "Parcourir";
            this.btn_appsPath.UseVisualStyleBackColor = true;
            this.btn_appsPath.Click += new System.EventHandler(this.btn_appsPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "executable (*.exe)|*.exe";
            // 
            // A_GestionApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 247);
            this.Controls.Add(this.btn_appsPath);
            this.Controls.Add(this.tb_AppsPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saveApps);
            this.Controls.Add(this.tb_NameApps);
            this.Controls.Add(this.l_application);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A_GestionApplication";
            this.ShowInTaskbar = false;
            this.Text = "A_GestionApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_application;
        private System.Windows.Forms.TextBox tb_NameApps;
        private System.Windows.Forms.Button btn_saveApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AppsPath;
        private System.Windows.Forms.Button btn_appsPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}