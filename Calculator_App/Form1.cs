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
           result=Double.Parse(Display.Text);
            operation = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Display.Text="";
            result = 0;
            equation.Text = "";
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            EqualBtn.Focus();
            
            switch (e.KeyChar.ToString())
            {
                case "0":
                    ZeroBtn.PerformClick();break;
                case "1":
                    Btn1.PerformClick(); break;
                case "2":
                    Btn2.PerformClick(); break;
                case "3":
                    Btn3.PerformClick(); break;
                case "4":
                    Btn4.PerformClick(); break;
                case "5":
                    Btn5.PerformClick(); break;
                case "6":
                    Btn6.PerformClick(); break;
                case "7":
                    Btn7.PerformClick(); break;
                case "8":
                    Btn8.PerformClick(); break;
                case "9":
                    Btn9.PerformClick(); break;
                case "+":
                    Add.PerformClick(); break;
                case "-":
                    Subtract.PerformClick(); break;
                case "*":
                    Multiply.PerformClick(); break;
                case "/":
                    Divide.PerformClick(); break;
                case "=":
                    EqualBtn.PerformClick(); break;
                case "Enter":
                    EqualBtn.PerformClick(); break;
                default:
                    break;



            }
        }
    }
}
