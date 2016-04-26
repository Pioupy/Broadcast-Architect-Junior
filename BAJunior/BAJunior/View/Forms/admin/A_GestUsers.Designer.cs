namespace BAJunior.View.Forms.admin
{
    partial class A_GestUsers
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
            this.lv_User = new System.Windows.Forms.ListView();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_User
            // 
            this.lv_User.Location = new System.Drawing.Point(78, 104);
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(487, 717);
            this.lv_User.TabIndex = 0;
            this.lv_User.UseCompatibleStateImageBehavior = false;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(888, 316);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(111, 41);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.Text = "Ajouter";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(888, 417);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(111, 41);
            this.btn_EditUser.TabIndex = 2;
            this.btn_EditUser.Text = "Modifier";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(888, 507);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(111, 41);
            this.btn_DeleteUser.TabIndex = 3;
            this.btn_DeleteUser.Text = "Supprimer";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // A_GestUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.lv_User);
            this.Name = "A_GestUsers";
            this.Size = new System.Drawing.Size(1246, 890);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_DeleteUser;
    }
}
