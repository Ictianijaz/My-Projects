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
    public partial class CancelSeat : Form
    {
        string seatNo;
        public CancelSeat(string seat)
        {
            InitializeComponent();
            seatNo = seat;
        }

        private void CancelSeat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            seatReservation s = new seatReservation();
            s.Show();
            this.Hide();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (this.cnic.Text == "")
            {
                this.errorProvider1.SetError(this.cnic, "Must be filled");
            }
            else
            {
                this.errorProvider1.Clear();
                FacadeControler f = FacadeControler.getFacadeControler();
                if (f.isCnicExist(this.cnic.Text))
                {
                    DialogResult r = MessageBox.Show("Are you sure", "Confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (f.cancelSeat(seatNo))
                        {
                            MessageBox.Show("Your seat has been caceled", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            seatReservation s = new seatReservation();
                            s.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show("Your record does not find", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (r == DialogResult.Cancel)
                    {
                        seatReservation s = new seatReservation();
                        s.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {
            if (cnic.Text == "")
                errorProvider1.SetError(cnic, "Must be filled");
            else
            {
                FacadeControler f = FacadeControler.getFacadeControler();
                if (f.cnicFormat(cnic.Text))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(cnic, "Invalid Format");
                }
            }
        }
    }
}
