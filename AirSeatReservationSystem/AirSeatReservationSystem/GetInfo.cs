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
            if (this.name.Text == "" || this.fName.Text == "" || this.cnic.Text == "")
            {
                if (this.name.Text == "")
                    this.GetInfoErrorProvider.SetError(name,"Must be filled");
                if (this.fName.Text == "")
                    this.errorProvider1.SetError(fName, "Must be filled");
                if (this.cnic.Text == "")
                    this.errorProvider2.SetError(cnic, "Must be filled");
            }
            else
            {
                GetInfoErrorProvider.Clear();
                errorProvider2.Clear();
                errorProvider1.Clear();
                DialogResult r = MessageBox.Show("Are your sure", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    FacadeControler f = FacadeControler.getFacadeControler();
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
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "")
                GetInfoErrorProvider.SetError(name, "Must be filled");
            else
            {

                GetInfoErrorProvider.Clear();
            }
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            if (fName.Text == "")
                errorProvider1.SetError(fName, "Must be filled");
            else
                errorProvider1.Clear();
        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {
            if (cnic.Text == "")
                errorProvider2.SetError(cnic, "Must be filled");
            else
            {
                FacadeControler f = FacadeControler.getFacadeControler();
                if (f.cnicFormat(cnic.Text))
                {
                    errorProvider2.Clear();
                }
                else
                {
                    errorProvider2.SetError(cnic, "Invalid Format");
                }
            }
        }
    }
}
