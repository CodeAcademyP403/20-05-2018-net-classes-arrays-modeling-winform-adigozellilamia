namespace loginRegister_sisstem
{
    partial class Frm_sign
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_signed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(120, 132);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(196, 20);
            this.txt_password.TabIndex = 10;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.Location = new System.Drawing.Point(24, 135);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(120, 85);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 20);
            this.txt_username.TabIndex = 8;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(44, 88);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(45, 17);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Name";
            // 
            // btn_signed
            // 
            this.btn_signed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signed.Location = new System.Drawing.Point(87, 229);
            this.btn_signed.Name = "btn_signed";
            this.btn_signed.Size = new System.Drawing.Size(175, 37);
            this.btn_signed.TabIndex = 11;
            this.btn_signed.Text = "Sign";
            this.btn_signed.UseVisualStyleBackColor = true;
            this.btn_signed.Click += new System.EventHandler(this.btn_signed_Click);
            // 
            // Frm_sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 318);
            this.Controls.Add(this.btn_signed);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Name = "Frm_sign";
            this.Text = "Sign";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_sign_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_signed;
    }
}