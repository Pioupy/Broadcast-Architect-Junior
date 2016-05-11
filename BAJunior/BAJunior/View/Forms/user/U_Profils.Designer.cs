namespace BAJunior.View.Forms.user
{
    partial class U_Profils
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Profils = new System.Windows.Forms.ComboBox();
            this.btn_AddProfil = new System.Windows.Forms.Button();
            this.btn_EditProfil = new System.Windows.Forms.Button();
            this.btn_DeleteProfil = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.intellipad = new BAJunior.View.Forms.user.K_Intellipad();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconexionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // déconexionToolStripMenuItem
            // 
            this.déconexionToolStripMenuItem.Name = "déconexionToolStripMenuItem";
            this.déconexionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.déconexionToolStripMenuItem.Text = "Déconexion";
            // 
            // cb_Profils
            // 
            this.cb_Profils.FormattingEnabled = true;
            this.cb_Profils.Location = new System.Drawing.Point(45, 32);
            this.cb_Profils.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Profils.Name = "cb_Profils";
            this.cb_Profils.Size = new System.Drawing.Size(172, 21);
            this.cb_Profils.TabIndex = 1;
            // 
            // btn_AddProfil
            // 
            this.btn_AddProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AddProfil.Location = new System.Drawing.Point(304, 32);
            this.btn_AddProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddProfil.Name = "btn_AddProfil";
            this.btn_AddProfil.Size = new System.Drawing.Size(68, 24);
            this.btn_AddProfil.TabIndex = 2;
            this.btn_AddProfil.Text = "Ajouter";
            this.btn_AddProfil.UseVisualStyleBackColor = true;
            this.btn_AddProfil.Click += new System.EventHandler(this.btn_AddProfil_Click);
            // 
            // btn_EditProfil
            // 
            this.btn_EditProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EditProfil.Location = new System.Drawing.Point(440, 32);
            this.btn_EditProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EditProfil.Name = "btn_EditProfil";
            this.btn_EditProfil.Size = new System.Drawing.Size(68, 24);
            this.btn_EditProfil.TabIndex = 3;
            this.btn_EditProfil.Text = "Editer";
            this.btn_EditProfil.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProfil
            // 
            this.btn_DeleteProfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DeleteProfil.Location = new System.Drawing.Point(550, 32);
            this.btn_DeleteProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteProfil.Name = "btn_DeleteProfil";
            this.btn_DeleteProfil.Size = new System.Drawing.Size(68, 24);
            this.btn_DeleteProfil.TabIndex = 4;
            this.btn_DeleteProfil.Text = "Supprimer";
            this.btn_DeleteProfil.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Load.Location = new System.Drawing.Point(490, 216);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(128, 45);
            this.btn_Load.TabIndex = 5;
            this.btn_Load.Text = "Charger dans la console";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // intellipad
            // 
            this.intellipad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intellipad.Location = new System.Drawing.Point(36, 87);
            this.intellipad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intellipad.Name = "intellipad";
            this.intellipad.Size = new System.Drawing.Size(404, 303);
            this.intellipad.TabIndex = 6;
            // 
            // U_Profils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 419);
            this.Controls.Add(this.intellipad);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_DeleteProfil);
            this.Controls.Add(this.btn_EditProfil);
            this.Controls.Add(this.btn_AddProfil);
            this.Controls.Add(this.cb_Profils);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "U_Profils";
            this.Text = " ";
            this.Load += new System.EventHandler(this.U_choixprofils_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconexionToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_Profils;
        private System.Windows.Forms.Button btn_AddProfil;
        private System.Windows.Forms.Button btn_EditProfil;
        private System.Windows.Forms.Button btn_DeleteProfil;
        private System.Windows.Forms.Button btn_Load;
        private K_Intellipad intellipad;
    }
}