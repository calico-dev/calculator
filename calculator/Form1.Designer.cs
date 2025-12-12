namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            equals = new Button();
            dot = new Button();
            zero = new Button();
            posneg = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            plus = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            back = new Button();
            clearall = new Button();
            squareroot = new Button();
            square = new Button();
            reciprocal = new Button();
            clearentry = new Button();
            percent = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // equals
            // 
            equals.BackColor = Color.PowderBlue;
            equals.ForeColor = SystemColors.ControlText;
            equals.Location = new Point(253, 384);
            equals.Name = "equals";
            equals.Size = new Size(76, 49);
            equals.TabIndex = 0;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            equals.Click += equals_Click;
            // 
            // dot
            // 
            dot.BackColor = SystemColors.ControlLight;
            dot.Location = new Point(171, 383);
            dot.Name = "dot";
            dot.Size = new Size(76, 50);
            dot.TabIndex = 1;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.ControlLight;
            zero.Location = new Point(89, 384);
            zero.Name = "zero";
            zero.Size = new Size(76, 50);
            zero.TabIndex = 2;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // posneg
            // 
            posneg.BackColor = SystemColors.ControlLight;
            posneg.Location = new Point(7, 383);
            posneg.Name = "posneg";
            posneg.Size = new Size(76, 50);
            posneg.TabIndex = 3;
            posneg.Text = "+/-";
            posneg.UseVisualStyleBackColor = false;
            posneg.Click += posneg_Click;
            // 
            // one
            // 
            one.BackColor = SystemColors.ControlLight;
            one.Location = new Point(7, 327);
            one.Name = "one";
            one.Size = new Size(76, 50);
            one.TabIndex = 4;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // two
            // 
            two.BackColor = SystemColors.ControlLight;
            two.Location = new Point(89, 327);
            two.Name = "two";
            two.Size = new Size(76, 50);
            two.TabIndex = 5;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // three
            // 
            three.BackColor = SystemColors.ControlLight;
            three.Location = new Point(171, 327);
            three.Name = "three";
            three.Size = new Size(76, 50);
            three.TabIndex = 6;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // six
            // 
            six.BackColor = SystemColors.ControlLight;
            six.Location = new Point(171, 271);
            six.Name = "six";
            six.Size = new Size(76, 50);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // five
            // 
            five.BackColor = SystemColors.ControlLight;
            five.Location = new Point(89, 271);
            five.Name = "five";
            five.Size = new Size(76, 50);
            five.TabIndex = 8;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // four
            // 
            four.BackColor = SystemColors.ControlLight;
            four.Location = new Point(7, 271);
            four.Name = "four";
            four.Size = new Size(76, 50);
            four.TabIndex = 9;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // seven
            // 
            seven.BackColor = SystemColors.ControlLight;
            seven.Location = new Point(7, 215);
            seven.Name = "seven";
            seven.Size = new Size(76, 50);
            seven.TabIndex = 10;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.BackColor = SystemColors.ControlLight;
            eight.Location = new Point(89, 215);
            eight.Name = "eight";
            eight.Size = new Size(76, 50);
            eight.TabIndex = 11;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.BackColor = SystemColors.ControlLight;
            nine.Location = new Point(171, 215);
            nine.Name = "nine";
            nine.Size = new Size(76, 50);
            nine.TabIndex = 12;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.Silver;
            plus.Location = new Point(253, 328);
            plus.Name = "plus";
            plus.Size = new Size(76, 50);
            plus.TabIndex = 13;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // subtract
            // 
            subtract.BackColor = Color.Silver;
            subtract.Location = new Point(253, 271);
            subtract.Name = "subtract";
            subtract.Size = new Size(76, 50);
            subtract.TabIndex = 14;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.Silver;
            multiply.Location = new Point(253, 216);
            multiply.Name = "multiply";
            multiply.Size = new Size(76, 50);
            multiply.TabIndex = 15;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.Silver;
            divide.Location = new Point(253, 160);
            divide.Name = "divide";
            divide.Size = new Size(76, 50);
            divide.TabIndex = 16;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // back
            // 
            back.BackColor = Color.Silver;
            back.Location = new Point(253, 104);
            back.Name = "back";
            back.Size = new Size(76, 50);
            back.TabIndex = 17;
            back.Text = "←";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // clearall
            // 
            clearall.BackColor = Color.Silver;
            clearall.Location = new Point(171, 104);
            clearall.Name = "clearall";
            clearall.Size = new Size(76, 50);
            clearall.TabIndex = 18;
            clearall.Text = "C";
            clearall.UseVisualStyleBackColor = false;
            clearall.Click += clearall_Click;
            // 
            // squareroot
            // 
            squareroot.BackColor = Color.Silver;
            squareroot.Location = new Point(171, 160);
            squareroot.Name = "squareroot";
            squareroot.Size = new Size(76, 50);
            squareroot.TabIndex = 19;
            squareroot.Text = "2√x";
            squareroot.UseVisualStyleBackColor = false;
            squareroot.Click += squareroot_Click;
            // 
            // square
            // 
            square.BackColor = Color.Silver;
            square.Location = new Point(89, 160);
            square.Name = "square";
            square.Size = new Size(76, 50);
            square.TabIndex = 20;
            square.Text = "x²";
            square.UseVisualStyleBackColor = false;
            square.Click += square_Click;
            // 
            // reciprocal
            // 
            reciprocal.BackColor = Color.Silver;
            reciprocal.Location = new Point(7, 160);
            reciprocal.Name = "reciprocal";
            reciprocal.Size = new Size(76, 50);
            reciprocal.TabIndex = 21;
            reciprocal.Text = "1/x";
            reciprocal.UseVisualStyleBackColor = false;
            reciprocal.Click += reciprocal_Click;
            // 
            // clearentry
            // 
            clearentry.BackColor = Color.Silver;
            clearentry.Location = new Point(89, 104);
            clearentry.Name = "clearentry";
            clearentry.Size = new Size(76, 50);
            clearentry.TabIndex = 22;
            clearentry.Text = "CE";
            clearentry.UseVisualStyleBackColor = false;
            clearentry.Click += clearentry_Click;
            // 
            // percent
            // 
            percent.BackColor = Color.Silver;
            percent.Location = new Point(7, 104);
            percent.Name = "percent";
            percent.Size = new Size(76, 50);
            percent.TabIndex = 23;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = false;
            percent.Click += percent_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(7, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 81);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(347, 445);
            Controls.Add(textBox1);
            Controls.Add(percent);
            Controls.Add(clearentry);
            Controls.Add(reciprocal);
            Controls.Add(square);
            Controls.Add(squareroot);
            Controls.Add(clearall);
            Controls.Add(back);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(subtract);
            Controls.Add(plus);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(posneg);
            Controls.Add(zero);
            Controls.Add(dot);
            Controls.Add(equals);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button equals;
        private Button dot;
        private Button zero;
        private Button posneg;
        private Button one;
        private Button two;
        private Button three;
        private Button six;
        private Button five;
        private Button four;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button plus;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button back;
        private Button clearall;
        private Button squareroot;
        private Button square;
        private Button reciprocal;
        private Button clearentry;
        private Button percent;
        private TextBox textBox1;
    }
}
