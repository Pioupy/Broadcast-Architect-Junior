namespace BAJunior.View.Forms.admin
{
    partial class Suppression
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteYes = new System.Windows.Forms.Button();
            this.btn_DeleteNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voulez-vous vraiment supprimer cet élément ?";
            // 
            // btn_DeleteYes
            // 
            this.btn_DeleteYes.Location = new System.Drawing.Point(86, 116);
            this.btn_DeleteYes.Name = "btn_DeleteYes";
            this.btn_DeleteYes.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteYes.TabIndex = 1;
            this.btn_DeleteYes.Text = "Oui";
            this.btn_DeleteYes.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteNo
            // 
            this.btn_DeleteNo.Location = new System.Drawing.Point(245, 116);
            this.btn_DeleteNo.Name = "btn_DeleteNo";
            this.btn_DeleteNo.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteNo.TabIndex = 2;
            this.btn_DeleteNo.Text = "Non";
            this.btn_DeleteNo.UseVisualStyleBackColor = true;
            // 
            // Suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 187);
            this.Controls.Add(this.btn_DeleteNo);
            this.Controls.Add(this.btn_DeleteYes);
            this.Controls.Add(this.label1);
            this.Name = "Suppression";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteYes;
        private System.Windows.Forms.Button btn_DeleteNo;
    }
}