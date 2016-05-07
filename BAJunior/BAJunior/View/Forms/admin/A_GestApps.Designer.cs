namespace BAJunior.View.Forms.admin
{
    partial class A_GestApps
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
            this.btn_DeleteApps = new System.Windows.Forms.Button();
            this.btn_EditApps = new System.Windows.Forms.Button();
            this.btn_AddApps = new System.Windows.Forms.Button();
            this.lv_Apps = new System.Windows.Forms.ListView();
            this.btn_saveApps = new System.Windows.Forms.Button();
            this.tb_NameApps = new System.Windows.Forms.TextBox();
            this.l_application = new System.Windows.Forms.Label();
            this.tb_ApplicationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FindApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DeleteApps
            // 
            this.btn_DeleteApps.Location = new System.Drawing.Point(720, 500);
            this.btn_DeleteApps.Name = "btn_DeleteApps";
            this.btn_DeleteApps.Size = new System.Drawing.Size(85, 33);
            this.btn_DeleteApps.TabIndex = 7;
            this.btn_DeleteApps.Text = "Supprimer";
            this.btn_DeleteApps.UseVisualStyleBackColor = true;
            // 
            // btn_EditApps
            // 
            this.btn_EditApps.Location = new System.Drawing.Point(720, 442);
            this.btn_EditApps.Name = "btn_EditApps";
            this.btn_EditApps.Size = new System.Drawing.Size(85, 33);
            this.btn_EditApps.TabIndex = 6;
            this.btn_EditApps.Text = "Modifier";
            this.btn_EditApps.UseVisualStyleBackColor = true;
            // 
            // btn_AddApps
            // 
            this.btn_AddApps.Location = new System.Drawing.Point(720, 376);
            this.btn_AddApps.Name = "btn_AddApps";
            this.btn_AddApps.Size = new System.Drawing.Size(85, 33);
            this.btn_AddApps.TabIndex = 5;
            this.btn_AddApps.Text = "Ajouter";
            this.btn_AddApps.UseVisualStyleBackColor = true;
            // 
            // lv_Apps
            // 
            this.lv_Apps.Location = new System.Drawing.Point(30, 100);
            this.lv_Apps.Name = "lv_Apps";
            this.lv_Apps.Size = new System.Drawing.Size(450, 600);
            this.lv_Apps.TabIndex = 4;
            this.lv_Apps.UseCompatibleStateImageBehavior = false;
            this.lv_Apps.View = System.Windows.Forms.View.List;
            this.lv_Apps.SelectedIndexChanged += new System.EventHandler(this.lv_Apps_SelectedIndexChanged);
            // 
            // btn_saveApps
            // 
            this.btn_saveApps.Location = new System.Drawing.Point(720, 221);
            this.btn_saveApps.Name = "btn_saveApps";
            this.btn_saveApps.Size = new System.Drawing.Size(85, 33);
            this.btn_saveApps.TabIndex = 10;
            this.btn_saveApps.Text = "Valider";
            this.btn_saveApps.UseVisualStyleBackColor = true;
            this.btn_saveApps.Click += new System.EventHandler(this.btn_saveApps_Click);
            // 
            // tb_NameApps
            // 
            this.tb_NameApps.Location = new System.Drawing.Point(657, 139);
            this.tb_NameApps.Name = "tb_NameApps";
            this.tb_NameApps.Size = new System.Drawing.Size(230, 22);
            this.tb_NameApps.TabIndex = 9;
            // 
            // l_application
            // 
            this.l_application.AutoSize = true;
            this.l_application.Location = new System.Drawing.Point(504, 142);
            this.l_application.Name = "l_application";
            this.l_application.Size = new System.Drawing.Size(147, 17);
            this.l_application.TabIndex = 8;
            this.l_application.Text = "Nom de l\'application : ";
            // 
            // tb_ApplicationFolder
            // 
            this.tb_ApplicationFolder.Location = new System.Drawing.Point(657, 173);
            this.tb_ApplicationFolder.Name = "tb_ApplicationFolder";
            this.tb_ApplicationFolder.Size = new System.Drawing.Size(230, 22);
            this.tb_ApplicationFolder.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chemin de l\'application :";
            // 
            // btn_FindApplication
            // 
            this.btn_FindApplication.Location = new System.Drawing.Point(906, 173);
            this.btn_FindApplication.Name = "btn_FindApplication";
            this.btn_FindApplication.Size = new System.Drawing.Size(75, 23);
            this.btn_FindApplication.TabIndex = 13;
            this.btn_FindApplication.Text = "Parcourir";
            this.btn_FindApplication.UseVisualStyleBackColor = true;
            // 
            // A_GestApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_FindApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ApplicationFolder);
            this.Controls.Add(this.btn_saveApps);
            this.Controls.Add(this.tb_NameApps);
            this.Controls.Add(this.l_application);
            this.Controls.Add(this.btn_DeleteApps);
            this.Controls.Add(this.btn_EditApps);
            this.Controls.Add(this.btn_AddApps);
            this.Controls.Add(this.lv_Apps);
            this.Name = "A_GestApps";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteApps;
        private System.Windows.Forms.Button btn_EditApps;
        private System.Windows.Forms.Button btn_AddApps;
        private System.Windows.Forms.ListView lv_Apps;
        private System.Windows.Forms.Button btn_saveApps;
        private System.Windows.Forms.TextBox tb_NameApps;
        private System.Windows.Forms.Label l_application;
        private System.Windows.Forms.TextBox tb_ApplicationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_FindApplication;
    }
}
