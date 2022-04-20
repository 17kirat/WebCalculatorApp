namespace Calculator_App
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.AllClearBtn = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.BackColor = System.Drawing.Color.Maroon;
            this.DecimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecimalBtn.Location = new System.Drawing.Point(92, 201);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(45, 45);
            this.DecimalBtn.TabIndex = 0;
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecimalBtn.UseVisualStyleBackColor = false;
            this.DecimalBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display.Location = new System.Drawing.Point(3, 5);
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(215, 65);
            this.Display.TabIndex = 1;
            this.Display.Text = "0";
            // 
            // AllClearBtn
            // 
            this.AllClearBtn.BackColor = System.Drawing.Color.Black;
            this.AllClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllClearBtn.Location = new System.Drawing.Point(173, 72);
            this.AllClearBtn.Name = "AllClearBtn";
            this.AllClearBtn.Size = new System.Drawing.Size(45, 45);
            this.AllClearBtn.TabIndex = 3;
            this.AllClearBtn.Text = "AC";
            this.AllClearBtn.UseVisualStyleBackColor = false;
            this.AllClearBtn.Click += new System.EventHandler(this.AllClearBtn_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Maroon;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn9.Location = new System.Drawing.Point(88, 72);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 45);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Maroon;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn8.Location = new System.Drawing.Point(45, 72);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 45);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Maroon;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Divide.Location = new System.Drawing.Point(131, 73);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(45, 45);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.operator_click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Maroon;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiply.Location = new System.Drawing.Point(132, 114);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(45, 45);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Maroon;
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtract.Location = new System.Drawing.Point(133, 157);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(45, 45);
            this.Subtract.TabIndex = 8;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.operator_click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Maroon;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(135, 201);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(45, 45);
            this.Add.TabIndex = 9;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.operator_click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Maroon;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn7.Location = new System.Drawing.Point(1, 72);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 45);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Maroon;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn6.Location = new System.Drawing.Point(89, 113);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 45);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Maroon;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn5.Location = new System.Drawing.Point(45, 113);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 45);
            this.Btn5.TabIndex = 12;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Maroon;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn4.Location = new System.Drawing.Point(1, 113);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 45);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Maroon;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn3.Location = new System.Drawing.Point(88, 157);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 45);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Maroon;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Location = new System.Drawing.Point(44, 157);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 45);
            this.Btn2.TabIndex = 15;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Maroon;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Location = new System.Drawing.Point(1, 157);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 45);
            this.Btn1.TabIndex = 16;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.Maroon;
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroBtn.Location = new System.Drawing.Point(0, 201);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(93, 45);
            this.ZeroBtn.TabIndex = 17;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // EqualBtn
            // 
            this.EqualBtn.BackColor = System.Drawing.Color.Black;
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EqualBtn.Location = new System.Drawing.Point(175, 157);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(45, 89);
            this.EqualBtn.TabIndex = 18;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = false;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Black;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonClear.Location = new System.Drawing.Point(174, 114);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(45, 45);
            this.ButtonClear.TabIndex = 19;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equation.Location = new System.Drawing.Point(4, 7);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(40, 32);
            this.equation.TabIndex = 20;
            this.equation.Click += new System.EventHandler(this.operator_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 239);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.AllClearBtn);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.DecimalBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(235, 278);
            this.MinimumSize = new System.Drawing.Size(235, 278);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button AllClearBtn;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label equation;
    }
}

