using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTutorial1
{
    
    public partial class calculator : Form
    {
        char op;
        string [] num;
        bool isNumberEntered;
        public calculator()
        {
            InitializeComponent();
            this.DisplayTextBox.Enabled = false;
            this.SquareRootButton.Text = "\u221A";
            op = '\0';
        }

        private void calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "7";
            isNumberEntered = true;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "8";
            isNumberEntered = true;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "9";
            isNumberEntered = true;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "4";
            isNumberEntered = true;
        }

        private void FiftButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "5";
            isNumberEntered = true;
        }

        private void SixthButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "6";
            isNumberEntered = true;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "1";
            isNumberEntered = true;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "2";
            isNumberEntered = true;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "3";
            isNumberEntered = true;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += "0";
            isNumberEntered = true;
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text += ".";
            isNumberEntered = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text != "")
            {
               if (op != '\0')
                {
                    num = (this.DisplayTextBox.Text).Split(op);
                    double res = 0;
                    try
                    {
                        if (op == '-')
                            res = double.Parse(num[0]) - double.Parse(num[1]);
                        else if (op == '+')
                            res = double.Parse(num[0]) + double.Parse(num[1]);
                        else if (op == '/')
                            res = double.Parse(num[0]) / double.Parse(num[1]);
                        else if (op == '*')
                            res = double.Parse(num[0]) * double.Parse(num[1]);
                        else if (op == '%')
                            res = double.Parse(num[0]) % double.Parse(num[1]);
                    }
                    catch (DivideByZeroException)
                    { }
                    finally
                    {
                        this.DisplayTextBox.Text = res.ToString();
                        op = '\0';
                    }
                }
            }
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.DisplayTextBox.Text = "";
            op = '\0';
            isNumberEntered = false;
        }
        private void ModButton_Click(object sender, EventArgs e)
        {

            if (op != '\0')
            {
                num = (this.DisplayTextBox.Text).Split(op);
                double res = 0;
                try
                {
                    if (op == '-')
                        res = double.Parse(num[0]) - double.Parse(num[1]);
                    else if (op == '+')
                        res = double.Parse(num[0]) + double.Parse(num[1]);
                    else if (op == '/')
                        res = double.Parse(num[0]) / double.Parse(num[1]);
                    else if (op == '*')
                        res = double.Parse(num[0]) * double.Parse(num[1]);
                    else if (op == '%')
                        res = double.Parse(num[0]) % double.Parse(num[1]);
                }
                catch (DivideByZeroException)
                { }
                finally
                {
                    this.DisplayTextBox.Text = res.ToString()+"%";
                    op = '%';
                }
            }
            else
            {
                this.DisplayTextBox.Text += "%";
                if(isNumberEntered)
                    op = '%';
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (op != '\0')
            {
                num = (this.DisplayTextBox.Text).Split(op);
                double res = 0;
                try
                {
                    if (op == '-')
                        res = double.Parse(num[0]) - double.Parse(num[1]);
                    else if (op == '+')
                        res = double.Parse(num[0]) + double.Parse(num[1]);
                    else if (op == '/')
                        res = (double.Parse(num[0])) / (double.Parse(num[1]));
                    else if (op == '*')
                        res = double.Parse(num[0]) * double.Parse(num[1]);
                    else if (op == '%')
                        res = double.Parse(num[0]) % double.Parse(num[1]);
                }
                catch (DivideByZeroException)
                { }
                finally
                {
                    this.DisplayTextBox.Text = res.ToString()+"/";
                    if(isNumberEntered)
                           op = '/';
                }
            }
            else
            {
                this.DisplayTextBox.Text += "/";
                if(isNumberEntered)
                          op = '/';
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (op != '\0')
            {
                num = (this.DisplayTextBox.Text).Split(op);
                double res = 0;
                try
                {
                    if (op == '-')
                        res = double.Parse(num[0]) - double.Parse(num[1]);
                    else if (op == '+')
                        res = double.Parse(num[0]) + double.Parse(num[1]);
                    else if (op == '/')
                        res = double.Parse(num[0]) / double.Parse(num[1]);
                    else if (op == '*')
                        res = double.Parse(num[0]) * double.Parse(num[1]);
                    else if (op == '%')
                        res = double.Parse(num[0]) % double.Parse(num[1]);
                }
                catch (DivideByZeroException)
                { }
                finally
                {
                    this.DisplayTextBox.Text = res.ToString()+"*";
                             op = '*';
                }
            }
            else
            {
                this.DisplayTextBox.Text += "*";
                if(isNumberEntered)
                op = '*';
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (op != '\0')
            {
                num = (this.DisplayTextBox.Text).Split(op);
                double res = 0;
                try
                {
                    if (op == '-')
                        res = double.Parse(num[0]) - double.Parse(num[1]);
                    else if (op == '+')
                        res = double.Parse(num[0]) + double.Parse(num[1]);
                    else if (op == '/')
                        res = double.Parse(num[0]) / double.Parse(num[1]);
                    else if (op == '*')
                        res = double.Parse(num[0]) * double.Parse(num[1]);
                    else if (op == '%')
                        res = double.Parse(num[0]) % double.Parse(num[1]);
                }
                catch (DivideByZeroException)
                { }
                finally
                {
                    this.DisplayTextBox.Text = res.ToString()+"+";
                    op = '+';
                }
            }
            else
            {
                this.DisplayTextBox.Text += "+";
                if(isNumberEntered)
                         op = '+';
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (op != '\0')
            {
                num = (this.DisplayTextBox.Text).Split(op);
                double res = 0;
                try
                {
                    if (op == '-')
                        res = double.Parse(num[0]) - double.Parse(num[1]);
                    else if (op == '+')
                        res = double.Parse(num[0]) + double.Parse(num[1]);
                    else if (op == '/')
                        res = double.Parse(num[0]) / double.Parse(num[1]);
                    else if (op == '*')
                        res = double.Parse(num[0]) * double.Parse(num[1]);
                    else if (op == '%')
                        res = double.Parse(num[0]) % double.Parse(num[1]);
                }
                catch (DivideByZeroException)
                { }
                finally
                {
                    this.DisplayTextBox.Text = res.ToString() + "-";
                    op = '-';
                }
            }
            else
            {
                this.DisplayTextBox.Text += "-";
                if(isNumberEntered)
                op = '-';
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text != "")
            {
                if (isOnlyNumber(DisplayTextBox.Text))
                {
                    double n = double.Parse(DisplayTextBox.Text);
                    if (n >= 0)
                    {
                        double number = double.Parse(DisplayTextBox.Text);
                        DisplayTextBox.Text = Math.Sqrt(number).ToString();
                    }
                }
                else
                {
                    if (op != '\0')
                    {
                        num = (this.DisplayTextBox.Text).Split(op);
                        double res = 0;
                        try
                        {
                            if (op == '-')
                                res = double.Parse(num[0]) - double.Parse(num[1]);
                            else if (op == '+')
                                res = double.Parse(num[0]) + double.Parse(num[1]);
                            else if (op == '/')
                                res = double.Parse(num[0]) / double.Parse(num[1]);
                            else if (op == '*')
                                res = double.Parse(num[0]) * double.Parse(num[1]);
                            else if (op == '%')
                                res = double.Parse(num[0]) % double.Parse(num[1]);
                        }
                        catch (DivideByZeroException)
                        { }
                        finally
                        {

                            if (res >= 0)
                            {
                                this.DisplayTextBox.Text = Math.Sqrt(res).ToString();
                                op = '\0';
                            }
                        }
                    }
                }
            }
        }
        public bool isOnlyNumber(string str)
        {
            if (str[0] == '-')
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!(str[i] >= '0' && str[i] <= '9' || str[i] == '.'))
                        return false;
                }
                return true;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!(str[i] >= '0' && str[i] <= '9' || str[i] == '.'))
                        return false;
                }
                return true;
            }
        }
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (this.DisplayTextBox.Text != "")
            {
                string n = "";
                string txt = this.DisplayTextBox.Text;
                if (txt[0] == '-')
                {
                    n += "-";
                    string nm = txt.Substring(1,txt.Length-1);
                    num = nm.Split(op);
                    n += num[0];
                }
                else
                {
                    string nm = txt;
                    num = nm.Split(op);
                    n += num[0];
                }
                double number = double.Parse(n);
                number = -1 * number;
                if(num.Length > 1)
                    this.DisplayTextBox.Text = number.ToString()+op.ToString()+num[1].ToString();
                else
                    this.DisplayTextBox.Text = number.ToString() + op.ToString();
            }
        }
    }
}
