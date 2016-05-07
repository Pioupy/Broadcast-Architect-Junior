namespace BAJunior.View.Forms.user
{
    partial class U_PreConfAddProfil
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
            this.labelNameProfile = new System.Windows.Forms.Label();
            this.tb_nameProfile = new System.Windows.Forms.TextBox();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.labelApplication = new System.Windows.Forms.Label();
            this.cb_keyboard = new System.Windows.Forms.ComboBox();
            this.cb_application = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameProfile
            // 
            this.labelNameProfile.AutoSize = true;
            this.labelNameProfile.Location = new System.Drawing.Point(12, 25);
            this.labelNameProfile.Name = "labelNameProfile";
            this.labelNameProfile.Size = new System.Drawing.Size(101, 17);
            this.labelNameProfile.TabIndex = 0;
            this.labelNameProfile.Text = "Nom du Profil :";
            // 
            // tb_nameProfile
            // 
            this.tb_nameProfile.Location = new System.Drawing.Point(260, 22);
            this.tb_nameProfile.Name = "tb_nameProfile";
            this.tb_nameProfile.Size = new System.Drawing.Size(187, 22);
            this.tb_nameProfile.TabIndex = 1;
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Location = new System.Drawing.Point(12, 61);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(160, 17);
            this.labelKeyboard.TabIndex = 2;
            this.labelKeyboard.Text = "Sélectionner un clavier :";
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Location = new System.Drawing.Point(12, 96);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(242, 17);
            this.labelApplication.TabIndex = 3;
            this.labelApplication.Text = "Sélectionner l\'application par défaut :";
            // 
            // cb_keyboard
            // 
            this.cb_keyboard.FormattingEnabled = true;
            this.cb_keyboard.Location = new System.Drawing.Point(260, 58);
            this.cb_keyboard.Name = "cb_keyboard";
            this.cb_keyboard.Size = new System.Drawing.Size(187, 24);
            this.cb_keyboard.TabIndex = 4;
            // 
            // cb_application
            // 
            this.cb_application.FormattingEnabled = true;
            this.cb_application.Location = new System.Drawing.Point(260, 93);
            this.cb_application.Name = "cb_application";
            this.cb_application.Size = new System.Drawing.Size(187, 24);
            this.cb_application.TabIndex = 5;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(358, 133);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(89, 31);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Suivant";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(231, 133);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 31);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // U_PreConfAddProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 182);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cb_application);
            this.Controls.Add(this.cb_keyboard);
            this.Controls.Add(this.labelApplication);
            this.Controls.Add(this.labelKeyboard);
            this.Controls.Add(this.tb_nameProfile);
            this.Controls.Add(this.labelNameProfile);
            this.Name = "U_PreConfAddProfil";
            this.Text = "U_PreConfAddProfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameProfile;
        private System.Windows.Forms.TextBox tb_nameProfile;
        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.ComboBox cb_keyboard;
        private System.Windows.Forms.ComboBox cb_application;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_cancel;
    }
}