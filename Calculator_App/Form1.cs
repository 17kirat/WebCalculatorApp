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
            Display.Text += "";
            userInput += "1";
            Display.Text += userInput;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "2";
            Display.Text += userInput;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "3";
            Display.Text += userInput;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "4";
            Display.Text += userInput;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "5";
            Display.Text += userInput;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "6";
            Display.Text += userInput;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "7";
            Display.Text += userInput;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "8";
            Display.Text += userInput;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "9";
            Display.Text += userInput;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "0";
            Display.Text += userInput;
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
           
            Display.Text += ".";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            function = '=';
            first = userInput;
            userInput = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            Display.Text = "";
        }
    }
}
