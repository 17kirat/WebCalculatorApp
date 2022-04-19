namespace Calculator_App
{
    partial class Form1
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
            this.ClearBtn = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.BackColor = System.Drawing.Color.Maroon;
            this.DecimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecimalBtn.Location = new System.Drawing.Point(2, 177);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(76, 30);
            this.DecimalBtn.TabIndex = 0;
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecimalBtn.UseVisualStyleBackColor = false;
            this.DecimalBtn.Click += new System.EventHandler(this.DecimalBtn_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display.Location = new System.Drawing.Point(5, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(298, 52);
            this.Display.TabIndex = 1;
            this.Display.Text = "0";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Black;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearBtn.Location = new System.Drawing.Point(2, 65);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(226, 30);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "AC";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Maroon;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn9.Location = new System.Drawing.Point(152, 92);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(76, 30);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Maroon;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn8.Location = new System.Drawing.Point(77, 92);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(76, 30);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Maroon;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Divide.Location = new System.Drawing.Point(227, 65);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(76, 30);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Maroon;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiply.Location = new System.Drawing.Point(227, 92);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(76, 30);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.Color.Maroon;
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtract.Location = new System.Drawing.Point(227, 119);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(76, 30);
            this.Subtract.TabIndex = 8;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Maroon;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(227, 148);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(76, 30);
            this.Add.TabIndex = 9;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Maroon;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn7.Location = new System.Drawing.Point(2, 92);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(76, 30);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Maroon;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn6.Location = new System.Drawing.Point(152, 119);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(76, 30);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Maroon;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn5.Location = new System.Drawing.Point(77, 119);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(76, 30);
            this.Btn5.TabIndex = 12;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Maroon;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn4.Location = new System.Drawing.Point(2, 119);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(76, 30);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Maroon;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn3.Location = new System.Drawing.Point(152, 148);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(76, 30);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Maroon;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Location = new System.Drawing.Point(77, 148);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(76, 30);
            this.Btn2.TabIndex = 15;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(2, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.Maroon;
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroBtn.Location = new System.Drawing.Point(77, 177);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(76, 30);
            this.ZeroBtn.TabIndex = 17;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // EqualBtn
            // 
            this.EqualBtn.BackColor = System.Drawing.Color.Black;
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EqualBtn.Location = new System.Drawing.Point(152, 177);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(151, 30);
            this.EqualBtn.TabIndex = 18;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = false;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 227);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.DecimalBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button ClearBtn;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button EqualBtn;
    }
}

