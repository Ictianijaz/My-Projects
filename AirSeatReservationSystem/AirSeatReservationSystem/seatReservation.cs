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
    public partial class seatReservation : Form
    {
        FacadeControler f;
        public seatReservation()
        {
            InitializeComponent();
            this.label1.BackColor = Color.Green;
            this.label2.BackColor = Color.Gray;
            this.label3.BackColor = Color.Aqua;
            f = FacadeControler.getFacadeControler();

        }
        private void isFull()
        {
            string[] seats = new string[20] { "71J", "71K", "72A", "72B", "72J", "72K", "73A", "73B", "73J", "73K", "77A", "77B", "77J", "77K", "78B", "78A", "78J", "78K", "79J", "79K" };
            bool flage = false;
            foreach (string s in seats)
            {
                if (f.checkSeatExistance(s))
                    flage = true;
                else
                    flage = false;
            }
            if (flage == true)
            {
                MessageBox.Show("Plane is ready to fly", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.deleteFile();
                Application.Exit();
            }
        }
        private void color()
        {
            if (f.checkSeatExistance(k_71.Text))
                k_71.BackColor = Color.Green;
            else
                k_71.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_71.Text))
                j_71.BackColor = Color.Green;
            else
                j_71.BackColor = Color.Gray;

            if (f.checkSeatExistance(a_72.Text))
                a_72.BackColor = Color.Green;
            else
                a_72.BackColor = Color.Gray;
            if (f.checkSeatExistance(b_72.Text))
                b_72.BackColor = Color.Green;
            else
                b_72.BackColor = Color.Gray;
            if (f.checkSeatExistance(k_72.Text))
                k_72.BackColor = Color.Green;
            else
                k_72.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_72.Text))
                j_72.BackColor = Color.Green;
            else
                j_72.BackColor = Color.Gray;

            if (f.checkSeatExistance(a_73.Text))
                a_73.BackColor = Color.Green;
            else
                a_73.BackColor = Color.Gray;
            if (f.checkSeatExistance(b_73.Text))
                b_73.BackColor = Color.Green;
            else
                b_73.BackColor = Color.Gray;
            if (f.checkSeatExistance(k_73.Text))
                k_73.BackColor = Color.Green;
            else
                k_73.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_73.Text))
                j_73.BackColor = Color.Green;
            else
                j_73.BackColor = Color.Gray;

            if (f.checkSeatExistance(a_77.Text))
                a_77.BackColor = Color.Green;
            else
                a_77.BackColor = Color.Gray;
            if (f.checkSeatExistance(b_77.Text))
                b_77.BackColor = Color.Green;
            else
                b_77.BackColor = Color.Gray;
            if (f.checkSeatExistance(k_77.Text))
                k_77.BackColor = Color.Green;
            else
                k_77.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_77.Text))
                j_77.BackColor = Color.Green;
            else
                j_77.BackColor = Color.Gray;

            if (f.checkSeatExistance(a_78.Text))
                a_78.BackColor = Color.Green;
            else
                a_78.BackColor = Color.Gray;
            if (f.checkSeatExistance(b_78.Text))
                b_78.BackColor = Color.Green;
            else
                b_78.BackColor = Color.Gray;
            if (f.checkSeatExistance(k_78.Text))
                k_78.BackColor = Color.Green;
            else
                k_78.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_78.Text))
                j_78.BackColor = Color.Green;
            else
                j_78.BackColor = Color.Gray;


            if (f.checkSeatExistance(k_79.Text))
                k_79.BackColor = Color.Green;
            else
                k_79.BackColor = Color.Gray;
            if (f.checkSeatExistance(j_79.Text))
                j_79.BackColor = Color.Green;
            else
                j_79.BackColor = Color.Gray;
        }
        private void seatReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void seatReservation_Load(object sender, EventArgs e)
        {
            this.color();
            this.isFull();
        }

        private void k_71_Click(object sender, EventArgs e)
        {
            if (k_71.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_71.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(k_71.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_71_Click(object sender, EventArgs e)
        {
            if (j_71.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_71.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_71.Text);
                c.Show();
                this.Hide();
            }
        }

        private void k_72_Click(object sender, EventArgs e)
        {

            if (k_72.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_72.Text);
                info.Show();
                this.Hide();

            }
            else
            {
                CancelSeat c = new CancelSeat(k_72.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_72_Click(object sender, EventArgs e)
        {
            if (j_72.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_72.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_72.Text);
                c.Show();
                this.Hide();
            }
        }

        private void b_72_Click(object sender, EventArgs e)
        {
            if (b_72.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(b_72.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(b_72.Text);
                c.Show();
                this.Hide();
            }
        }

        private void a_72_Click(object sender, EventArgs e)
        {
            if (a_72.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(a_72.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(a_72.Text);
                c.Show();
                this.Hide();
            }
        }

        private void k_73_Click(object sender, EventArgs e)
        {
            if (k_73.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_73.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(k_73.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_73_Click(object sender, EventArgs e)
        {
            if (j_73.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_73.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_73.Text);
                c.Show();
                this.Hide();
            }
        }

        private void b_73_Click(object sender, EventArgs e)
        {
            if (b_73.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(b_73.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(b_73.Text);
                c.Show();
                this.Hide();
            }
        }

        private void a_73_Click(object sender, EventArgs e)
        {
            if (a_73.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(a_73.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(a_73.Text);
                c.Show();
                this.Hide();
            }
        }

        private void k_77_Click(object sender, EventArgs e)
        {
            if (k_77.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_77.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(k_77.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_77_Click(object sender, EventArgs e)
        {
            if (j_77.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_77.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_77.Text);
                c.Show();
                this.Hide();
            }
        }

        private void b_77_Click(object sender, EventArgs e)
        {
            if (b_77.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(b_77.Text);
                info.Show();
                this.Hide();
            }

            else
            {
                CancelSeat c = new CancelSeat(b_77.Text);
                c.Show();
                this.Hide();
            }
        }

        private void a_77_Click(object sender, EventArgs e)
        {
            if (a_77.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(a_77.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(a_77.Text);
                c.Show();
                this.Hide();
            }
        }

        private void k_78_Click(object sender, EventArgs e)
        {
            if (k_78.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_78.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(k_78.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_78_Click(object sender, EventArgs e)
        {
            if (j_78.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_78.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_78.Text);
                c.Show();
                this.Hide();
            }
        }

        private void b_78_Click(object sender, EventArgs e)
        {
            if (b_78.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(b_78.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(b_78.Text);
                c.Show();
                this.Hide();
            }
        }

        private void a_78_Click(object sender, EventArgs e)
        {
            if (a_78.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(a_78.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(a_78.Text);
                c.Show();
                this.Hide();
            }
        }

        private void k_79_Click(object sender, EventArgs e)
        {
            if (k_79.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(k_79.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(k_79.Text);
                c.Show();
                this.Hide();
            }
        }

        private void j_79_Click(object sender, EventArgs e)
        {
            if (j_79.BackColor == Color.Gray)
            {
                GetInfo info = new GetInfo(j_79.Text);
                info.Show();
                this.Hide();
            }
            else
            {
                CancelSeat c = new CancelSeat(j_79.Text);
                c.Show();
                this.Hide();
            }
        }
    }
}
