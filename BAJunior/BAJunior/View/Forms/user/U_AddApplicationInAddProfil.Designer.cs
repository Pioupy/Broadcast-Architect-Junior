namespace BAJunior.View.Forms.user
{
    partial class U_AddApplicationInAddProfil
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
            this.lv_application = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_application
            // 
            this.lv_application.Location = new System.Drawing.Point(13, 13);
            this.lv_application.Name = "lv_application";
            this.lv_application.Size = new System.Drawing.Size(399, 307);
            this.lv_application.TabIndex = 0;
            this.lv_application.UseCompatibleStateImageBehavior = false;
            this.lv_application.DoubleClick += new System.EventHandler(this.lv_application_DoubleClick);
            // 
            // U_AddApplicationInAddProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.lv_application);
            this.Name = "U_AddApplicationInAddProfil";
            this.Text = "U_AddApplicationInAddProfil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_application;
    }
}