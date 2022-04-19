using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
          
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            function = '.';
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            function = '=';
        }

        private void Add_Click(object sender, EventArgs e)
        {
            function = '+';

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            function = 'C';
        }
    }
}
