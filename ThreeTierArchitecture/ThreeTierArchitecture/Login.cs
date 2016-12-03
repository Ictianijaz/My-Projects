using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logicLayer;

namespace ThreeTierArchitecture
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void logi_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || password.Text == "")
            {
                if (id.Text == "")
                    MessageBox.Show("Enter your id");
                if (password.Text == "")
                    MessageBox.Show("Enter your password");
            }
            else
            {
                FacadeControler f = FacadeControler.getFacadeControler();
                if (f.check(id.Text, password.Text))
                {
                    MessageBox.Show("Login Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to login");
                }
            }
        }
    }
}
