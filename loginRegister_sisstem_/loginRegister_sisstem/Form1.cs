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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            frm_register register = new frm_register(this);
            register.Show();
            this.Hide();
            


        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
           
            Frm_sign sign = new Frm_sign(this);
            sign.Show();
            this.Hide();
        }
    }
}
