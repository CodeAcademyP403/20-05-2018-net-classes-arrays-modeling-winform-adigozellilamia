using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginRegister_sisstem
{
    public partial class frm_register : Form
    {
        Form form;
        private Form1 form1;

        public frm_register(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void btn_logined_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_surname.Text != "" && txt_mail.Text != "" && txt_password.Text != "")
            {

                MessageBox.Show("You are succesfull register");

                Frm_sign sign = new Frm_sign(this.form1);
                sign.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Do not leave it blank");
            }
            

        }

        private void frm_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
