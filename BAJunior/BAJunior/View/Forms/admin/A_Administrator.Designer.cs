namespace BAJunior.View.Forms.admin
{
    partial class A_Administrator
    {
        // TODO : APPEL TOUS LES USER CONTROL DE ADMIN
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
            this.GestUsers = new System.Windows.Forms.TabControl();
            this.GestBtns = new System.Windows.Forms.TabPage();
            this.a_GestBtns2 = new BAJunior.View.Forms.admin.A_GestBtns();
            this.Gest_Users = new System.Windows.Forms.TabPage();
            this.a_GestUsers1 = new BAJunior.View.Forms.admin.A_GestUsers();
            this.GestUsers.SuspendLayout();
            this.GestBtns.SuspendLayout();
            this.Gest_Users.SuspendLayout();
            this.SuspendLayout();
            // 
            // GestUsers
            // 
            this.GestUsers.Controls.Add(this.GestBtns);
            this.GestUsers.Controls.Add(this.Gest_Users);
            this.GestUsers.Location = new System.Drawing.Point(16, 15);
            this.GestUsers.Margin = new System.Windows.Forms.Padding(4);
            this.GestUsers.Name = "GestUsers";
            this.GestUsers.SelectedIndex = 0;
            this.GestUsers.Size = new System.Drawing.Size(1316, 943);
            this.GestUsers.TabIndex = 0;
            // 
            // GestBtns
            // 
            this.GestBtns.Controls.Add(this.a_GestBtns2);
            this.GestBtns.Location = new System.Drawing.Point(4, 25);
            this.GestBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GestBtns.Name = "GestBtns";
            this.GestBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GestBtns.Size = new System.Drawing.Size(1308, 914);
            this.GestBtns.TabIndex = 0;
            this.GestBtns.Text = "Boutons";
            this.GestBtns.UseVisualStyleBackColor = true;
            // 
            // a_GestBtns2
            // 
            this.a_GestBtns2.Location = new System.Drawing.Point(83, 34);
            this.a_GestBtns2.Name = "a_GestBtns2";
            this.a_GestBtns2.Size = new System.Drawing.Size(1116, 856);
            this.a_GestBtns2.TabIndex = 1;
            // 
            // Gest_Users
            // 
            this.Gest_Users.Controls.Add(this.a_GestUsers1);
            this.Gest_Users.Location = new System.Drawing.Point(4, 25);
            this.Gest_Users.Margin = new System.Windows.Forms.Padding(4);
            this.Gest_Users.Name = "Gest_Users";
            this.Gest_Users.Padding = new System.Windows.Forms.Padding(4);
            this.Gest_Users.Size = new System.Drawing.Size(1308, 914);
            this.Gest_Users.TabIndex = 1;
            this.Gest_Users.Text = "Utilisateurs";
            this.Gest_Users.UseVisualStyleBackColor = true;
            // 
            // a_GestUsers1
            // 
            this.a_GestUsers1.Location = new System.Drawing.Point(53, 28);
            this.a_GestUsers1.Name = "a_GestUsers1";
            this.a_GestUsers1.Size = new System.Drawing.Size(1192, 833);
            this.a_GestUsers1.TabIndex = 0;
            // 
            // A_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 966);
            this.Controls.Add(this.GestUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_Administrator";
            this.Text = "Administrator";
            this.GestUsers.ResumeLayout(false);
            this.GestBtns.ResumeLayout(false);
            this.Gest_Users.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GestUsers;
        private System.Windows.Forms.TabPage GestBtns;
        private System.Windows.Forms.TabPage Gest_Users;
        private A_GestBtns a_GestBtns2;
        private A_GestUsers a_GestUsers1;
    }
}