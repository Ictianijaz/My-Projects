using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace AirSeatReservationSystem
{
    public partial class GetInfo : Form
    {
        string seatNo;
        public GetInfo(string seat)
        {
            InitializeComponent();
            seatNo = seat;
        }

        private void GetInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            seatReservation s = new seatReservation();
            s.Show();
            this.Hide();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are your sure", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (this.name.Text == "" || this.fName.Text == "" || this.cnic.Text == "")
                {
                    if (this.name.Text == "")
                    {
                        DialogResult res = MessageBox.Show("Enter your name", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (res == DialogResult.Cancel)
                        {
                            seatReservation s = new seatReservation();
                            s.Show();
                            this.Hide();
                        }
                    }
                    if (this.fName.Text == "")
                    {
                        DialogResult rr = MessageBox.Show("Enter your father name", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (rr == DialogResult.Cancel)
                        {
                            seatReservation s = new seatReservation();
                            s.Show();
                            this.Hide();
                        }
                    }
                    if (this.cnic.Text == "")
                    {
                        DialogResult rrr = MessageBox.Show("Enter your cnic", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (rrr == DialogResult.Cancel)
                        {
                            seatReservation s = new seatReservation();
                            s.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    FacadeControler f = FacadeControler.getFacadeControler();
                    if (f.cnicFormat(this.cnic.Text))
                    {
                        string[] info = new string[4];
                        info[0] = this.name.Text;
                        info[1] = this.fName.Text;
                        info[2] = this.cnic.Text;
                        info[3] = this.seatNo;
                        f.getInfo(info);
                        MessageBox.Show("Your seat reserved successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        seatReservation s = new seatReservation();
                        s.Show();
                        this.Hide();
                    }
                    else
                    {
                        DialogResult rre = MessageBox.Show("CNIC must be numeric and must have length 13", "Error message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (rre == DialogResult.Cancel)
                        {
                            seatReservation s = new seatReservation();
                            s.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                seatReservation s = new seatReservation();
                s.Show();
                this.Hide();
            }
        }
    }
}
