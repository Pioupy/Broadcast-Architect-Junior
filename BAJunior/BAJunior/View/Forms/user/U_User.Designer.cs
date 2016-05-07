namespace BAJunior.View.Forms.user
{
    partial class U_User
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
            this.u_AddProfil = new BAJunior.View.Forms.user.U_AddProfil();
            this.SuspendLayout();
            // 
            // u_AddProfil
            // 
            this.u_AddProfil.Location = new System.Drawing.Point(12, 12);
            this.u_AddProfil.Name = "u_AddProfil";
            this.u_AddProfil.Size = new System.Drawing.Size(1107, 574);
            this.u_AddProfil.TabIndex = 0;
            // 
            // U_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 527);
            this.Controls.Add(this.u_AddProfil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "U_User";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private U_AddProfil u_AddProfil;
    }
}