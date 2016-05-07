namespace BAJunior.View.Forms.user
{
    partial class U_AddProfil
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
            this.gb_application = new System.Windows.Forms.GroupBox();
            this.gb_boutons = new System.Windows.Forms.GroupBox();
            this.labelLambdaProfle = new System.Windows.Forms.Label();
            this.labelNameProfile = new System.Windows.Forms.Label();
            this.labelLambdaKeyboard = new System.Windows.Forms.Label();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_property = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_selectApplication = new System.Windows.Forms.Button();
            this.btn_addApplication = new System.Windows.Forms.Button();
            this.labelLambdaListApplication = new System.Windows.Forms.Label();
            this.labelLambdaBoutons = new System.Windows.Forms.Label();
            this.gb_application.SuspendLayout();
            this.gb_boutons.SuspendLayout();
            this.gb_property.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_application
            // 
            this.gb_application.Controls.Add(this.labelLambdaListApplication);
            this.gb_application.Controls.Add(this.btn_addApplication);
            this.gb_application.Controls.Add(this.btn_selectApplication);
            this.gb_application.Controls.Add(this.listView1);
            this.gb_application.Location = new System.Drawing.Point(781, 12);
            this.gb_application.Name = "gb_application";
            this.gb_application.Size = new System.Drawing.Size(431, 261);
            this.gb_application.TabIndex = 0;
            this.gb_application.TabStop = false;
            this.gb_application.Text = "Applications";
            // 
            // gb_boutons
            // 
            this.gb_boutons.Controls.Add(this.labelLambdaBoutons);
            this.gb_boutons.Location = new System.Drawing.Point(781, 279);
            this.gb_boutons.Name = "gb_boutons";
            this.gb_boutons.Size = new System.Drawing.Size(431, 328);
            this.gb_boutons.TabIndex = 1;
            this.gb_boutons.TabStop = false;
            this.gb_boutons.Text = "Boutons";
            // 
            // labelLambdaProfle
            // 
            this.labelLambdaProfle.AutoSize = true;
            this.labelLambdaProfle.Location = new System.Drawing.Point(18, 30);
            this.labelLambdaProfle.Name = "labelLambdaProfle";
            this.labelLambdaProfle.Size = new System.Drawing.Size(100, 17);
            this.labelLambdaProfle.TabIndex = 2;
            this.labelLambdaProfle.Text = "Nom du profil :";
            // 
            // labelNameProfile
            // 
            this.labelNameProfile.AutoSize = true;
            this.labelNameProfile.Location = new System.Drawing.Point(124, 30);
            this.labelNameProfile.Name = "labelNameProfile";
            this.labelNameProfile.Size = new System.Drawing.Size(38, 17);
            this.labelNameProfile.TabIndex = 3;
            this.labelNameProfile.Text = "label";
            // 
            // labelLambdaKeyboard
            // 
            this.labelLambdaKeyboard.AutoSize = true;
            this.labelLambdaKeyboard.Location = new System.Drawing.Point(370, 30);
            this.labelLambdaKeyboard.Name = "labelLambdaKeyboard";
            this.labelLambdaKeyboard.Size = new System.Drawing.Size(135, 17);
            this.labelLambdaKeyboard.TabIndex = 4;
            this.labelLambdaKeyboard.Text = "Clavier sélectionné :";
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Location = new System.Drawing.Point(511, 30);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(38, 17);
            this.labelKeyboard.TabIndex = 5;
            this.labelKeyboard.Text = "label";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1102, 613);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(986, 613);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 35);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gb_property
            // 
            this.gb_property.Controls.Add(this.labelKeyboard);
            this.gb_property.Controls.Add(this.labelLambdaKeyboard);
            this.gb_property.Controls.Add(this.labelNameProfile);
            this.gb_property.Controls.Add(this.labelLambdaProfle);
            this.gb_property.Location = new System.Drawing.Point(12, 12);
            this.gb_property.Name = "gb_property";
            this.gb_property.Size = new System.Drawing.Size(763, 67);
            this.gb_property.TabIndex = 8;
            this.gb_property.TabStop = false;
            this.gb_property.Text = "Propriétés";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 151);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_selectApplication
            // 
            this.btn_selectApplication.Location = new System.Drawing.Point(215, 209);
            this.btn_selectApplication.Name = "btn_selectApplication";
            this.btn_selectApplication.Size = new System.Drawing.Size(100, 36);
            this.btn_selectApplication.TabIndex = 1;
            this.btn_selectApplication.Text = "Sélectionner";
            this.btn_selectApplication.UseVisualStyleBackColor = true;
            // 
            // btn_addApplication
            // 
            this.btn_addApplication.Location = new System.Drawing.Point(321, 209);
            this.btn_addApplication.Name = "btn_addApplication";
            this.btn_addApplication.Size = new System.Drawing.Size(100, 36);
            this.btn_addApplication.TabIndex = 2;
            this.btn_addApplication.Text = "Ajouter";
            this.btn_addApplication.UseVisualStyleBackColor = true;
            // 
            // labelLambdaListApplication
            // 
            this.labelLambdaListApplication.AutoSize = true;
            this.labelLambdaListApplication.Location = new System.Drawing.Point(7, 22);
            this.labelLambdaListApplication.Name = "labelLambdaListApplication";
            this.labelLambdaListApplication.Size = new System.Drawing.Size(240, 17);
            this.labelLambdaListApplication.TabIndex = 3;
            this.labelLambdaListApplication.Text = "Liste des applications liées au profil :";
            // 
            // labelLambdaBoutons
            // 
            this.labelLambdaBoutons.AutoSize = true;
            this.labelLambdaBoutons.Location = new System.Drawing.Point(7, 18);
            this.labelLambdaBoutons.Name = "labelLambdaBoutons";
            this.labelLambdaBoutons.Size = new System.Drawing.Size(128, 17);
            this.labelLambdaBoutons.TabIndex = 0;
            this.labelLambdaBoutons.Text = "Liste des boutons :";
            // 
            // U_AddProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 660);
            this.Controls.Add(this.gb_property);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_boutons);
            this.Controls.Add(this.gb_application);
            this.Name = "U_AddProfil";
            this.Text = "New Profil";
            this.gb_application.ResumeLayout(false);
            this.gb_application.PerformLayout();
            this.gb_boutons.ResumeLayout(false);
            this.gb_boutons.PerformLayout();
            this.gb_property.ResumeLayout(false);
            this.gb_property.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_application;
        private System.Windows.Forms.GroupBox gb_boutons;
        private System.Windows.Forms.Label labelLambdaProfle;
        private System.Windows.Forms.Label labelNameProfile;
        private System.Windows.Forms.Label labelLambdaKeyboard;
        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_property;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelLambdaListApplication;
        private System.Windows.Forms.Button btn_addApplication;
        private System.Windows.Forms.Button btn_selectApplication;
        private System.Windows.Forms.Label labelLambdaBoutons;
    }
}
