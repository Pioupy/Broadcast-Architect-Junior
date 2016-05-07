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
            this.SuspendLayout();
            // 
            // btn_DeleteApps
            // 
            this.btn_DeleteApps.Location = new System.Drawing.Point(720, 500);
            this.btn_DeleteApps.Name = "btn_DeleteApps";
            this.btn_DeleteApps.Size = new System.Drawing.Size(111, 41);
            this.btn_DeleteApps.TabIndex = 7;
            this.btn_DeleteApps.Text = "Supprimer";
            this.btn_DeleteApps.UseVisualStyleBackColor = true;
            this.btn_DeleteApps.Click += new System.EventHandler(this.btn_DeleteApps_Click);
            // 
            // btn_EditApps
            // 
            this.btn_EditApps.Location = new System.Drawing.Point(720, 400);
            this.btn_EditApps.Name = "btn_EditApps";
            this.btn_EditApps.Size = new System.Drawing.Size(111, 41);
            this.btn_EditApps.TabIndex = 6;
            this.btn_EditApps.Text = "Modifier";
            this.btn_EditApps.UseVisualStyleBackColor = true;
            this.btn_EditApps.Click += new System.EventHandler(this.btn_EditApps_Click);
            // 
            // btn_AddApps
            // 
            this.btn_AddApps.Location = new System.Drawing.Point(720, 300);
            this.btn_AddApps.Name = "btn_AddApps";
            this.btn_AddApps.Size = new System.Drawing.Size(111, 41);
            this.btn_AddApps.TabIndex = 5;
            this.btn_AddApps.Text = "Ajouter";
            this.btn_AddApps.UseVisualStyleBackColor = true;
            this.btn_AddApps.Click += new System.EventHandler(this.btn_AddApps_Click);
            // 
            // lv_Apps
            // 
            this.lv_Apps.Location = new System.Drawing.Point(80, 110);
            this.lv_Apps.Name = "lv_Apps";
            this.lv_Apps.Size = new System.Drawing.Size(450, 600);
            this.lv_Apps.TabIndex = 4;
            this.lv_Apps.UseCompatibleStateImageBehavior = false;
            this.lv_Apps.View = System.Windows.Forms.View.List;
            // 
            // A_GestApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_DeleteApps);
            this.Controls.Add(this.btn_EditApps);
            this.Controls.Add(this.btn_AddApps);
            this.Controls.Add(this.lv_Apps);
            this.Name = "A_GestApps";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteApps;
        private System.Windows.Forms.Button btn_EditApps;
        private System.Windows.Forms.Button btn_AddApps;
        private System.Windows.Forms.ListView lv_Apps;
    }
}
