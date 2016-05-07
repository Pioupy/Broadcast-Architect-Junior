namespace BAJunior.View.Forms.admin
{
    partial class A_GestBtns
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
            this.lv_Button = new System.Windows.Forms.ListView();
            this.btn_DeleteBtn = new System.Windows.Forms.Button();
            this.btn_EditBtn = new System.Windows.Forms.Button();
            this.btn_AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Button
            // 
            this.lv_Button.Location = new System.Drawing.Point(80, 110);
            this.lv_Button.Name = "lv_Button";
            this.lv_Button.Size = new System.Drawing.Size(450, 600);
            this.lv_Button.TabIndex = 0;
            this.lv_Button.UseCompatibleStateImageBehavior = false;
            this.lv_Button.View = System.Windows.Forms.View.List;
            // 
            // btn_DeleteBtn
            // 
            this.btn_DeleteBtn.Location = new System.Drawing.Point(720, 500);
            this.btn_DeleteBtn.Name = "btn_DeleteBtn";
            this.btn_DeleteBtn.Size = new System.Drawing.Size(111, 41);
            this.btn_DeleteBtn.TabIndex = 6;
            this.btn_DeleteBtn.Text = "Supprimer";
            this.btn_DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // btn_EditBtn
            // 
            this.btn_EditBtn.Location = new System.Drawing.Point(720, 400);
            this.btn_EditBtn.Name = "btn_EditBtn";
            this.btn_EditBtn.Size = new System.Drawing.Size(111, 41);
            this.btn_EditBtn.TabIndex = 5;
            this.btn_EditBtn.Text = "Modifier";
            this.btn_EditBtn.UseVisualStyleBackColor = true;
            this.btn_EditBtn.Click += new System.EventHandler(this.btn_EditBtn_Click);
            // 
            // btn_AddBtn
            // 
            this.btn_AddBtn.Location = new System.Drawing.Point(720, 300);
            this.btn_AddBtn.Name = "btn_AddBtn";
            this.btn_AddBtn.Size = new System.Drawing.Size(111, 41);
            this.btn_AddBtn.TabIndex = 4;
            this.btn_AddBtn.Text = "Ajouter";
            this.btn_AddBtn.UseVisualStyleBackColor = true;
            this.btn_AddBtn.Click += new System.EventHandler(this.btn_AddBtn_Click);
            // 
            // A_GestBtns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_DeleteBtn);
            this.Controls.Add(this.btn_EditBtn);
            this.Controls.Add(this.btn_AddBtn);
            this.Controls.Add(this.lv_Button);
            this.Name = "A_GestBtns";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Button;
        private System.Windows.Forms.Button btn_DeleteBtn;
        private System.Windows.Forms.Button btn_EditBtn;
        private System.Windows.Forms.Button btn_AddBtn;
    }
}
