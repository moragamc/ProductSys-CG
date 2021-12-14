using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Connection String
       // string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True;";
        //btn_Submit Click event
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor digite UserName y  Password");
                count = 0;
                return;
            }
            else
            {
                count = 1;
            }
            try
            {
                if (count == 1)
                {
                    MessageBox.Show("Login Exitoso!");
                    this.Hide();
                    Movies fm = new Movies();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Fallido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
