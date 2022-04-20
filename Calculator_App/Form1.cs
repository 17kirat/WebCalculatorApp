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
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if( (Display.Text == "0") ||(operation_pressed))
                 Display.Text="";
            operation_pressed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if(!Display.Text.Contains("."))
                    Display.Text= Display.Text + btn.Text;
            }
            else
            Display.Text = Display.Text + btn.Text;

        }

        private void AllClearBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result != 0)
            {
                EqualBtn.PerformClick();
                operation_pressed=true;
                operation=btn.Text;
                equation.Text = result + "" + operation;

            }
            else
            {
                operation = btn.Text;
                result = Double.Parse(Display.Text);
                operation_pressed = true;
                equation.Text = result + "" + operation;

            }
            
          
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    Display.Text = (result + Double.Parse(Display.Text)).ToString();
                        break;
                case "-":
                    Display.Text = (result - Double.Parse(Display.Text)).ToString();
                    break;
                case "*":
                    Display.Text = (result * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (result / Double.Parse(Display.Text)).ToString();
                    break;
                default:
                    break;
            }
           result=Int32.Parse(Display.Text);
            operation = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Display.Text="";
            result = 0;
        }
    }
}
