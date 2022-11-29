using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string numb1 = string.Empty;
        string numb2 = string.Empty;
        char operation;
        double dispaly = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            numb1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            numb1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            numb1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "10";
            this.textBox1.Text += input;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "11";
            this.textBox1.Text += input;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            numb1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn17_Click(object sender, EventArgs e)
        {

            numb1 = input;
            operation = 'C';
            input = string.Empty;
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.numb1 = string.Empty;
            this.numb2 = string.Empty;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            numb2 = input;
            double FirstNum, SecondNum;
            double.TryParse(numb1, out FirstNum);
            double.TryParse(numb2, out SecondNum);

            if (operation == '+')
            {
                dispaly = FirstNum + SecondNum;
                textBox1.Text = dispaly.ToString();
            }
            else if (operation == '-')
            {
                dispaly = FirstNum - SecondNum;
                textBox1.Text = dispaly.ToString();
            }
            else if (operation == '*')
            {
                dispaly = FirstNum * SecondNum;
                textBox1.Text = dispaly.ToString();
            }
            else if (operation == '/')
            {
                if (SecondNum != 0)
                {
                    dispaly = FirstNum / SecondNum;
                    textBox1.Text = dispaly.ToString();
                }
                else
                {
                    textBox1.Text = "zero";
                }

            }
        }
    }
}
