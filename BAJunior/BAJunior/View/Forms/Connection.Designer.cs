namespace BAJunior.View.Forms
{
    partial class Connection
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(38, 41);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(90, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Nom d\'utilisateur :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(38, 115);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(80, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Mot de passe : ";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(41, 57);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(163, 20);
            this.tb_Login.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(41, 132);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(163, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // btn_Connection
            // 
            this.btn_Connection.Location = new System.Drawing.Point(197, 188);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(75, 23);
            this.btn_Connection.TabIndex = 4;
            this.btn_Connection.Text = "Connexion";
            this.btn_Connection.UseVisualStyleBackColor = true;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Connection);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Connection;


    }
}