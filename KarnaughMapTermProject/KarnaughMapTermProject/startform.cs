using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarnaughMapTermProject
{
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void startform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void startform_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                this.label1.Text = "Loading ";
                for (int j = 0; j < 3; j++)
                {
                    this.label1.Text += " - ";
                    await Task.Delay(500);
                }
            }
            homeForm h = new homeForm();
            h.Show();
            this.Hide();
        }
    }
}
