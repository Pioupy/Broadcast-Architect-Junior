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
            this.Administrator = new System.Windows.Forms.TabControl();
            this.GestBtns = new System.Windows.Forms.TabPage();
            this.GestUsers = new System.Windows.Forms.TabPage();
            this.GestApps = new System.Windows.Forms.TabPage();
            this.a_GestBtns1 = new BAJunior.View.Forms.admin.A_GestBtns();
            this.a_GestUsers1 = new BAJunior.View.Forms.admin.A_GestUsers();
            this.a_GestApps1 = new BAJunior.View.Forms.admin.A_GestApps();
            this.Administrator.SuspendLayout();
            this.GestBtns.SuspendLayout();
            this.GestUsers.SuspendLayout();
            this.GestApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Administrator.Controls.Add(this.GestBtns);
            this.Administrator.Controls.Add(this.GestUsers);
            this.Administrator.Controls.Add(this.GestApps);
            this.Administrator.Location = new System.Drawing.Point(16, 15);
            this.Administrator.Margin = new System.Windows.Forms.Padding(4);
            this.Administrator.Name = "Administrator";
            this.Administrator.SelectedIndex = 0;
            this.Administrator.Size = new System.Drawing.Size(1316, 943);
            this.Administrator.TabIndex = 0;
            // 
            // GestBtns
            // 
            this.GestBtns.Controls.Add(this.a_GestBtns1);
            this.GestBtns.Location = new System.Drawing.Point(4, 25);
            this.GestBtns.Margin = new System.Windows.Forms.Padding(4);
            this.GestBtns.Name = "GestBtns";
            this.GestBtns.Padding = new System.Windows.Forms.Padding(4);
            this.GestBtns.Size = new System.Drawing.Size(1308, 914);
            this.GestBtns.TabIndex = 0;
            this.GestBtns.Text = "Boutons";
            this.GestBtns.UseVisualStyleBackColor = true;
            // 
            // GestUsers
            // 
            this.GestUsers.Controls.Add(this.a_GestUsers1);
            this.GestUsers.Location = new System.Drawing.Point(4, 25);
            this.GestUsers.Margin = new System.Windows.Forms.Padding(4);
            this.GestUsers.Name = "GestUsers";
            this.GestUsers.Padding = new System.Windows.Forms.Padding(4);
            this.GestUsers.Size = new System.Drawing.Size(1308, 914);
            this.GestUsers.TabIndex = 1;
            this.GestUsers.Text = "Utilisateurs";
            this.GestUsers.UseVisualStyleBackColor = true;
            // 
            // GestApps
            // 
            this.GestApps.Controls.Add(this.a_GestApps1);
            this.GestApps.Location = new System.Drawing.Point(4, 25);
            this.GestApps.Name = "GestApps";
            this.GestApps.Padding = new System.Windows.Forms.Padding(3);
            this.GestApps.Size = new System.Drawing.Size(1308, 914);
            this.GestApps.TabIndex = 2;
            this.GestApps.Text = "Applications";
            this.GestApps.UseVisualStyleBackColor = true;
            // 
            // a_GestBtns1
            // 
            this.a_GestBtns1.Location = new System.Drawing.Point(15, 15);
            this.a_GestBtns1.Name = "a_GestBtns1";
            this.a_GestBtns1.Size = new System.Drawing.Size(1286, 876);
            this.a_GestBtns1.TabIndex = 0;
            // 
            // a_GestUsers1
            // 
            this.a_GestUsers1.Location = new System.Drawing.Point(15, 15);
            this.a_GestUsers1.Name = "a_GestUsers1";
            this.a_GestUsers1.Size = new System.Drawing.Size(1246, 890);
            this.a_GestUsers1.TabIndex = 0;
            // 
            // a_GestApps1
            // 
            this.a_GestApps1.Location = new System.Drawing.Point(15, 15);
            this.a_GestApps1.Name = "a_GestApps1";
            this.a_GestApps1.Size = new System.Drawing.Size(1280, 870);
            this.a_GestApps1.TabIndex = 0;
            // 
            // A_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 966);
            this.Controls.Add(this.Administrator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "A_Administrator";
            this.Text = "Administrator";
            this.Administrator.ResumeLayout(false);
            this.GestBtns.ResumeLayout(false);
            this.GestUsers.ResumeLayout(false);
            this.GestApps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Administrator;
        private System.Windows.Forms.TabPage GestBtns;
        private System.Windows.Forms.TabPage GestUsers;
        private A_GestUsers a_GestUsers1;
        private A_GestBtns a_GestBtns1;
        private System.Windows.Forms.TabPage GestApps;
        private A_GestApps a_GestApps1;
    }
}