namespace loginRegister_sisstem
{
    partial class frm_register
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_logined = new System.Windows.Forms.Button();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(47, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.Location = new System.Drawing.Point(23, 203);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(123, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(123, 200);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(196, 20);
            this.txt_password.TabIndex = 3;
            // 
            // btn_logined
            // 
            this.btn_logined.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_logined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_logined.Location = new System.Drawing.Point(30, 273);
            this.btn_logined.Name = "btn_logined";
            this.btn_logined.Size = new System.Drawing.Size(289, 45);
            this.btn_logined.TabIndex = 4;
            this.btn_logined.Text = "Logined";
            this.btn_logined.UseVisualStyleBackColor = false;
            this.btn_logined.Click += new System.EventHandler(this.btn_logined_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(123, 106);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(196, 20);
            this.txt_surname.TabIndex = 6;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_surname.Location = new System.Drawing.Point(27, 109);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(65, 17);
            this.lbl_surname.TabIndex = 5;
            this.lbl_surname.Text = "Surname";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(123, 150);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(196, 20);
            this.txt_mail.TabIndex = 8;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.Location = new System.Drawing.Point(50, 153);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(42, 17);
            this.lbl_mail.TabIndex = 7;
            this.lbl_mail.Text = "Email";
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 367);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.btn_logined);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Name = "frm_register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_logined;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
    }
}