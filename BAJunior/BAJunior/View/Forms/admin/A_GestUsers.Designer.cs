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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_no = new System.Windows.Forms.RadioButton();
            this.rbtn_yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_User
            // 
            this.lv_User.Location = new System.Drawing.Point(80, 111);
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(450, 600);
            this.lv_User.TabIndex = 0;
            this.lv_User.UseCompatibleStateImageBehavior = false;
            this.lv_User.View = System.Windows.Forms.View.List;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(720, 300);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(111, 41);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.Text = "Ajouter";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(720, 400);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(111, 41);
            this.btn_EditUser.TabIndex = 2;
            this.btn_EditUser.Text = "Modifier";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(720, 500);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(111, 41);
            this.btn_DeleteUser.TabIndex = 3;
            this.btn_DeleteUser.Text = "Supprimer";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Administrateur ?";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(733, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Valider";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_no);
            this.panel1.Controls.Add(this.rbtn_yes);
            this.panel1.Location = new System.Drawing.Point(720, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 31);
            this.panel1.TabIndex = 12;
            // 
            // rbtn_no
            // 
            this.rbtn_no.AutoSize = true;
            this.rbtn_no.Location = new System.Drawing.Point(62, 7);
            this.rbtn_no.Name = "rbtn_no";
            this.rbtn_no.Size = new System.Drawing.Size(55, 21);
            this.rbtn_no.TabIndex = 1;
            this.rbtn_no.TabStop = true;
            this.rbtn_no.Text = "Non";
            this.rbtn_no.UseVisualStyleBackColor = true;
            // 
            // rbtn_yes
            // 
            this.rbtn_yes.AutoSize = true;
            this.rbtn_yes.Location = new System.Drawing.Point(4, 7);
            this.rbtn_yes.Name = "rbtn_yes";
            this.rbtn_yes.Size = new System.Drawing.Size(51, 21);
            this.rbtn_yes.TabIndex = 0;
            this.rbtn_yes.TabStop = true;
            this.rbtn_yes.Text = "Oui";
            this.rbtn_yes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mot de passe : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identifiant : ";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(720, 148);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(186, 22);
            this.tb_password.TabIndex = 9;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(720, 111);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(186, 22);
            this.tb_id.TabIndex = 8;
            // 
            // A_GestUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.lv_User);
            this.Name = "A_GestUsers";
            this.Size = new System.Drawing.Size(1024, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_no;
        private System.Windows.Forms.RadioButton rbtn_yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_id;
    }
}
