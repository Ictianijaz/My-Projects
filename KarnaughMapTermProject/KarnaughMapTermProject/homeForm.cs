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
using System.Threading;

namespace KarnaughMapTermProject
{
    public partial class homeForm : Form
    {
        int[,] arr;       
        public homeForm()
        {

            InitializeComponent();
            arr = new int[2,2];
            truthT3.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            truthT3.AutoSize = true;
            k_map_3.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            k_map_3.AutoSize = true;
            this.AutoScroll = true;
            sFunction.Enabled = false;
            gFunction.Enabled = false;
            truth2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            k_map_2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            truth2.AutoSize = true;
            onePanel.Visible = false;
            twoPanel.Visible = false;
            fourVpanel.Visible = false;
            simplify.Visible = false;
            sPanel.Visible = false;
            gPanel.Visible = false;
            truth1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            truth1.AutoSize = true;
            k_map_1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }
        private void truthT3BT1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT1.Text);
            if (i == 0)
                truthT3BT1.Text = "1";
            else
                truthT3BT1.Text = "0";
            k_map_3_L_1.Text = truthT3BT1.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT2.Text);
            if (i == 0)
                truthT3BT2.Text = "1";
            else
                truthT3BT2.Text = "0";
            k_map_3_L_2.Text = truthT3BT2.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT3.Text);
            if (i == 0)
                truthT3BT3.Text = "1";
            else
                truthT3BT3.Text = "0";
            k_map_3_L_4.Text = truthT3BT3.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT4.Text);
            if (i == 0)
                truthT3BT4.Text = "1";
            else
                truthT3BT4.Text = "0";
            k_map_3_L_3.Text = truthT3BT4.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT5_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT5.Text);
            if (i == 0)
                truthT3BT5.Text = "1";
            else
                truthT3BT5.Text = "0";
            k_map_3_L_5.Text = truthT3BT5.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT6_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT6.Text);
            if (i == 0)
                truthT3BT6.Text = "1";
            else
                truthT3BT6.Text = "0";
            k_map_3_L_6.Text = truthT3BT6.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT7_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT7.Text);
            if (i == 0)
                truthT3BT7.Text = "1";
            else
                truthT3BT7.Text = "0";
            k_map_3_L_8.Text = truthT3BT7.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT8_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT8.Text);
            if (i == 0)
                truthT3BT8.Text = "1";
            else
                truthT3BT8.Text = "0";
            k_map_3_L_7.Text = truthT3BT8.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT9_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT9.Text);
            if (i == 0)
                truthT3BT9.Text = "1";
            else
                truthT3BT9.Text = "0";
            k_map_3_L_13.Text = truthT3BT9.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT10_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT10.Text);
            if (i == 0)
                truthT3BT10.Text = "1";
            else
                truthT3BT10.Text = "0";
            k_map_3_L_14.Text = truthT3BT10.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT11_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT11.Text);
            if (i == 0)
                truthT3BT11.Text = "1";
            else
                truthT3BT11.Text = "0";
            k_map_3_L_16.Text = truthT3BT11.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT12_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT12.Text);
            if (i == 0)
                truthT3BT12.Text = "1";
            else
                truthT3BT12.Text = "0";
            k_map_3_L_15.Text = truthT3BT12.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT13_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT13.Text);
            if (i == 0)
                truthT3BT13.Text = "1";
            else
                truthT3BT13.Text = "0";
            k_map_3_L_9.Text = truthT3BT13.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT14_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT14.Text);
            if (i == 0)
                truthT3BT14.Text = "1";
            else
                truthT3BT14.Text = "0";
            k_map_3_L_10.Text = truthT3BT14.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT15_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT15.Text);
            if (i == 0)
                truthT3BT15.Text = "1";
            else
                truthT3BT15.Text = "0";
            k_map_3_L_12.Text = truthT3BT15.Text;
            this.getEquation("k_map_3");
        }

        private void truthT3BT16_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truthT3BT16.Text);
            if (i == 0)
                truthT3BT16.Text = "1";
            else
                truthT3BT16.Text = "0";
            k_map_3_L_11.Text = truthT3BT16.Text;
            this.getEquation("k_map_3");
        }
        public void getEquation(string k_map)
        {
            if (k_map == "k_map_3")
            {
                int count = 1;
                int[,] arr2 = new int[k_map_3.RowCount, k_map_3.ColumnCount];
                for (int i = 0; i < k_map_3.RowCount; i++)
                {
                    for (int j = 0; j < k_map_3.ColumnCount; j++)
                    {
                        Control[] l = this.Controls.Find("k_map_3_L_" + count, true);
                        arr2[i, j] = int.Parse(l[0].Text);
                        count++;
                    }
                }
                FacadeControler f = FacadeControler.getFacadeControler();
                this.gFunction.Text = f.getEquation(arr2, k_map_3.RowCount, k_map_3.ColumnCount);
            }
            else if (k_map == "k_map_1")
            {
                int count = 1;
                for (int i = 0; i < k_map_1.RowCount; i++)
                {
                    for (int j = 0; j < k_map_1.ColumnCount; j++)
                    {
                        Control[] l = this.Controls.Find("k_map_1_L_" + count, true);
                        arr[i, j] = int.Parse(l[0].Text);
                        count++;
                    }
                }
                FacadeControler f = FacadeControler.getFacadeControler();
                this.gFunction.Text = f.getEquation(arr, k_map_1.RowCount, k_map_1.ColumnCount);
            }
            else if (k_map == "k_map_2")
            {
                int[,] arr2 = new int[k_map_2.RowCount, k_map_2.ColumnCount];
                int count = 1;
                for (int i = 0; i < k_map_2.RowCount; i++)
                {
                    for (int j = 0; j < k_map_2.ColumnCount; j++)
                    {
                        Control[] l = this.Controls.Find("k_map_2_L_" + count, true);
                        arr2[i, j] = int.Parse(l[0].Text);
                        count++;
                    }
                }
                FacadeControler f = FacadeControler.getFacadeControler();
                this.gFunction.Text = f.getEquation(arr2, k_map_2.RowCount, k_map_2.ColumnCount);
            }
        }
        public void changeColor(string k_map)
        {
            this.sFunction.Text = "";
            if (k_map == "k_map_1")
            {
                for (int i = 0; i < k_map_1.RowCount; i++)
                {
                    for (int j = 0; j < k_map_1.ColumnCount; j++)
                    {
                        k_map_1.GetControlFromPosition(j, i).BackColor = SystemColors.GradientInactiveCaption;
                    }
                }
            }
        }

        private void simplify_Click(object sender, EventArgs e)
        {
            this.Result();
        }
        public async void Result()
        {
            int count1 = 0;
            int row = -1;
            int col = -1;
            for (int i = 0; i < k_map_1.RowCount; i++)
            {
                for (int j = 0; j < k_map_1.ColumnCount; j++)
                {
                    if (arr[i, j] == 1)
                    {
                        count1++;
                        row = i;
                        col = j;
                    }
                }
            }
            if (count1 == 4)
            {
                for (int i = 0; i < k_map_1.RowCount; i++)
                {
                    for (int j = 0; j < k_map_1.ColumnCount; j++)
                    {
                        k_map_1.GetControlFromPosition(j, i).BackColor = Color.Green;
                    }
                }
                this.sFunction.Text = "1";
            }
            else if (count1 == 1)
            {
                k_map_1.GetControlFromPosition(col, row).BackColor = Color.Gray;
                this.sFunction.Text = this.gFunction.Text;
            }
            //first condition end
            if (arr[0,0] == 1 && arr[0, 1] == 0 && arr[1, 0] == 0 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Green;
                this.sFunction.Text = this.gFunction.Text;
            }
            if (arr[0, 0] == 0 && arr[0, 1] == 1 && arr[1, 0] == 1 && arr[1, 1] == 0)
            {
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Gray;
                this.sFunction.Text = this.gFunction.Text;
            }
            if (arr[0, 0] == 1 && arr[0, 1] == 1 && arr[1, 0] == 0 && arr[1, 1] == 0)
            {
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Green;
                this.sFunction.Text = "A'";
            }
            if (arr[0, 0] == 0 && arr[0, 1] == 0 && arr[1, 0] == 1 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Gray;
                this.sFunction.Text = "A";
            }
            if (arr[0, 0] == 1 && arr[0, 1] == 0 && arr[1, 0] == 1 && arr[1, 1] == 0)
            {
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Green;
                this.sFunction.Text = "B'";
            }
            if (arr[0, 0] == 0 && arr[0, 1] == 1 && arr[1, 0] == 0 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Gray;
                this.sFunction.Text = "B";
            }
            if (arr[0, 0] == 1 && arr[0, 1] == 1 && arr[1, 0] == 1 && arr[1, 1] == 0)
            {
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Green;
                this.sFunction.Text = "A'";
                await Task.Delay(1000);
                k_map_1.GetControlFromPosition(1, 0).BackColor = SystemColors.GradientInactiveCaption;
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Gray;
                this.sFunction.Text += "+B'";
            }
            if (arr[0, 0] == 1 && arr[0, 1] == 0 && arr[1, 0] == 1 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Green;
                this.sFunction.Text = "A";
                await Task.Delay(1000);
                k_map_1.GetControlFromPosition(1, 1).BackColor = SystemColors.GradientInactiveCaption;
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Gray;
                this.sFunction.Text += "+B'";
            }
            if (arr[0, 0] == 0 && arr[0, 1] == 1 && arr[1, 0] == 1 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(0, 1).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Green;
                this.sFunction.Text = "A";
                await Task.Delay(1000);
                k_map_1.GetControlFromPosition(0, 1).BackColor = SystemColors.GradientInactiveCaption;
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Gray;
                this.sFunction.Text += "+B";
            }
            if (arr[0, 0] == 1 && arr[0, 1] == 1 && arr[1, 0] == 0 && arr[1, 1] == 1)
            {
                k_map_1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Green;
                this.sFunction.Text = "A'";
                await Task.Delay(1000);
                k_map_1.GetControlFromPosition(0, 0).BackColor = SystemColors.GradientInactiveCaption;
                k_map_1.GetControlFromPosition(1, 0).BackColor = Color.Gray;
                k_map_1.GetControlFromPosition(1, 1).BackColor = Color.Gray;
                this.sFunction.Text += "+B";
            }
        }
        
        private void twoV_Click(object sender, EventArgs e)
        {
            twoPanel.Visible = false;
            onePanel.Visible = true;
            fourVpanel.Visible = false;
            simplify.Visible = true;
            gPanel.Visible = true;
            sPanel.Visible = true;
            gFunction.Text = "";
        }

        private void threeV_Click(object sender, EventArgs e)
        {
            twoPanel.Visible = true;
            onePanel.Visible = false;
            fourVpanel.Visible = false;
            simplify.Visible = false;
            gPanel.Visible = true;
            sPanel.Visible = false;
            gFunction.Text = "";
        }

        private void fourV_Click(object sender, EventArgs e)
        {
            twoPanel.Visible = false;
            onePanel.Visible = false;
            fourVpanel.Visible = true;
            simplify.Visible = false;
            gPanel.Visible = true;
            sPanel.Visible = false;
            gFunction.Text = "";
        }

        private void truth1BT1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth1BT1.Text);
            if (i == 0)
                truth1BT1.Text = "1";
            else
                truth1BT1.Text = "0";
            k_map_1_L_1.Text = truth1BT1.Text;
            this.getEquation("k_map_1");
            this.changeColor("k_map_1");
        }

        private void truth1BT2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth1BT2.Text);
            if (i == 0)
                truth1BT2.Text = "1";
            else
                truth1BT2.Text = "0";
            k_map_1_L_2.Text = truth1BT2.Text;
            this.getEquation("k_map_1");
            this.changeColor("k_map_1");
        }

        private void truth1BT3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth1BT3.Text);
            if (i == 0)
                truth1BT3.Text = "1";
            else
                truth1BT3.Text = "0";
            k_map_1_L_3.Text = truth1BT3.Text;
            this.getEquation("k_map_1");
            this.changeColor("k_map_1");
        }

        private void truth1BT4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth1BT4.Text);
            if (i == 0)
                truth1BT4.Text = "1";
            else
                truth1BT4.Text = "0";
            k_map_1_L_4.Text = truth1BT4.Text;
            this.getEquation("k_map_1");
            this.changeColor("k_map_1");
        }

        private void truth2BT1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT1.Text);
            if (i == 0)
                truth2BT1.Text = "1";
            else
                truth2BT1.Text = "0";
            k_map_2_L_1.Text = truth2BT1.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT2.Text);
            if (i == 0)
                truth2BT2.Text = "1";
            else
                truth2BT2.Text = "0";
            k_map_2_L_2.Text = truth2BT2.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT3.Text);
            if (i == 0)
                truth2BT3.Text = "1";
            else
                truth2BT3.Text = "0";
            k_map_2_L_3.Text = truth2BT3.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT4.Text);
            if (i == 0)
                truth2BT4.Text = "1";
            else
                truth2BT4.Text = "0";
            k_map_2_L_4.Text = truth2BT4.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT5_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT5.Text);
            if (i == 0)
                truth2BT5.Text = "1";
            else
                truth2BT5.Text = "0";
            k_map_2_L_7.Text = truth2BT5.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT6_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT6.Text);
            if (i == 0)
                truth2BT6.Text = "1";
            else
                truth2BT6.Text = "0";
            k_map_2_L_8.Text = truth2BT2.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT7_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT7.Text);
            if (i == 0)
                truth2BT7.Text = "1";
            else
                truth2BT7.Text = "0";
            k_map_2_L_5.Text = truth2BT7.Text;
            this.getEquation("k_map_2");
        }

        private void truth2BT8_Click(object sender, EventArgs e)
        {
            int i = int.Parse(truth2BT8.Text);
            if (i == 0)
                truth2BT8.Text = "1";
            else
                truth2BT8.Text = "0";
            k_map_2_L_6.Text = truth2BT8.Text;
            this.getEquation("k_map_2");
        }
    }
}

