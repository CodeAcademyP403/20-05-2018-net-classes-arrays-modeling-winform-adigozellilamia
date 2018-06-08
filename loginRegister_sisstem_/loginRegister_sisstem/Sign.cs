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
    public partial class Frm_sign : Form
    {
        Form form;
        private Form1 form1;
        public Frm_sign(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();

            Login user = new Login();

        }
        

        List<Login> user = new List<Login>();

        private void Database()
        {

            Login user1 = new Login();
            
            user1.Username = "Lamia";
            user1.Password = "123123";
            user.Add(user1);

            Login user2 = new Login();


            user2.Username = "Zuleyxa";
            user2.Password = "123123";
            user.Add(user2);
        }

        private void btn_signed_Click(object sender, EventArgs e)
        {
            Database();
            
            foreach (Login usr in user)
            {
              
                if(txt_username.Text == usr.Username)
                {
                    if (txt_username.Text == usr.Username && txt_password.Text.ToString() == usr.Password)
                    {
                        MessageBox.Show(usr.Username, usr.Password);
                        MessageBox.Show("You are succesfull signed");
                        break;
                    }
                    else
                    {

                        MessageBox.Show("Email or password invalid");
                        break;
                    }
                }
                

            }

        }

        private void Frm_sign_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }


}
