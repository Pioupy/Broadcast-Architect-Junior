﻿namespace BAJunior.View.Forms.user
{
    partial class U_choixprofils
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
            this.clavier1 = new BAJunior.View.Forms.user.Clavier();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(862, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconexionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // déconexionToolStripMenuItem
            // 
            this.déconexionToolStripMenuItem.Name = "déconexionToolStripMenuItem";
            this.déconexionToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.déconexionToolStripMenuItem.Text = "Déconexion";
            // 
            // cb_Profils
            // 
            this.cb_Profils.FormattingEnabled = true;
            this.cb_Profils.Location = new System.Drawing.Point(60, 40);
            this.cb_Profils.Name = "cb_Profils";
            this.cb_Profils.Size = new System.Drawing.Size(228, 24);
            this.cb_Profils.TabIndex = 1;
            // 
            // btn_AddProfil
            // 
            this.btn_AddProfil.Location = new System.Drawing.Point(406, 40);
            this.btn_AddProfil.Name = "btn_AddProfil";
            this.btn_AddProfil.Size = new System.Drawing.Size(90, 30);
            this.btn_AddProfil.TabIndex = 2;
            this.btn_AddProfil.Text = "Ajouter";
            this.btn_AddProfil.UseVisualStyleBackColor = true;
            // 
            // btn_EditProfil
            // 
            this.btn_EditProfil.Location = new System.Drawing.Point(586, 40);
            this.btn_EditProfil.Name = "btn_EditProfil";
            this.btn_EditProfil.Size = new System.Drawing.Size(90, 30);
            this.btn_EditProfil.TabIndex = 3;
            this.btn_EditProfil.Text = "Editer";
            this.btn_EditProfil.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProfil
            // 
            this.btn_DeleteProfil.Location = new System.Drawing.Point(733, 40);
            this.btn_DeleteProfil.Name = "btn_DeleteProfil";
            this.btn_DeleteProfil.Size = new System.Drawing.Size(90, 30);
            this.btn_DeleteProfil.TabIndex = 4;
            this.btn_DeleteProfil.Text = "Supprimer";
            this.btn_DeleteProfil.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(653, 266);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(170, 55);
            this.btn_Load.TabIndex = 5;
            this.btn_Load.Text = "Charger dans la console";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // clavier1
            // 
            this.clavier1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clavier1.Location = new System.Drawing.Point(48, 107);
            this.clavier1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clavier1.Name = "clavier1";
            this.clavier1.Size = new System.Drawing.Size(539, 373);
            this.clavier1.TabIndex = 6;
            // 
            // U_choixprofils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 516);
            this.Controls.Add(this.clavier1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_DeleteProfil);
            this.Controls.Add(this.btn_EditProfil);
            this.Controls.Add(this.btn_AddProfil);
            this.Controls.Add(this.cb_Profils);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "U_choixprofils";
            this.Text = "U_choixprofils";
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
        private Clavier clavier1;
    }
}