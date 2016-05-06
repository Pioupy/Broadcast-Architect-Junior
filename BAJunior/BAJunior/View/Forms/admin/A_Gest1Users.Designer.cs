namespace BAJunior.View.Forms.admin
{
    partial class A_Gest1Users
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.rbtn_yes = new System.Windows.Forms.RadioButton();
            this.rbtn_no = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(122, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(186, 22);
            this.tb_id.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(122, 62);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(186, 22);
            this.tb_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiant : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_no);
            this.panel1.Controls.Add(this.rbtn_yes);
            this.panel1.Location = new System.Drawing.Point(122, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 31);
            this.panel1.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(135, 136);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Valider";
            this.btn_save.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Administrateur ?";
            // 
            // A_Gest1Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 171);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Name = "A_Gest1Users";
            this.Text = "Gestion utilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_no;
        private System.Windows.Forms.RadioButton rbtn_yes;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
    }
}