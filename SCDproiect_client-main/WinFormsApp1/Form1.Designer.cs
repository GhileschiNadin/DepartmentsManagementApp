namespace WinFormsApp1
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button2 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            button5 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            button6 = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "All employees";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(425, 87);
            button1.Name = "button1";
            button1.Size = new Size(184, 29);
            button1.TabIndex = 2;
            button1.Text = "load Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 50);
            label2.TabIndex = 3;
            label2.Text = "Director's App";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 146);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "Departments";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(222, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(425, 142);
            button3.Name = "button3";
            button3.Size = new Size(184, 29);
            button3.TabIndex = 7;
            button3.Text = "load Departments";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 200);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 8;
            label4.Text = "Employees per department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 253);
            label5.Name = "label5";
            label5.Size = new Size(182, 20);
            label5.TabIndex = 9;
            label5.Text = "Managers per department";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(222, 200);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(222, 253);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(425, 196);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 12;
            button2.Text = "load Employees per Dep";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(425, 249);
            button4.Name = "button4";
            button4.Size = new Size(184, 29);
            button4.TabIndex = 13;
            button4.Text = "load Managers per Dep";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(20, 389);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1051, 157);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 306);
            label6.Name = "label6";
            label6.Size = new Size(238, 31);
            label6.TabIndex = 15;
            label6.Text = "Write your email here:";
            // 
            // button5
            // 
            button5.Location = new Point(338, 552);
            button5.Name = "button5";
            button5.Size = new Size(347, 29);
            button5.TabIndex = 16;
            button5.Text = "Send email to all the selected employees";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(723, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(339, 164);
            listBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(723, 87);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 18;
            label7.Text = "Selected Employees";
            // 
            // button6
            // 
            button6.Location = new Point(781, 284);
            button6.Name = "button6";
            button6.Size = new Size(229, 29);
            button6.TabIndex = 19;
            button6.Text = "Add Employees";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.Location = new Point(283, 298);
            label8.Name = "label8";
            label8.Size = new Size(473, 58);
            label8.TabIndex = 20;
            label8.Text = "You can add employees to the mail list by selecting an employee from the \"All Employees\" and then click on \"Add Employee\" button.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 356);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 27);
            textBox1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 363);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 22;
            label9.Text = "Subject:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 613);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button2;
        private Button button4;
        private RichTextBox richTextBox1;
        private Label label6;
        private Button button5;
        private ListBox listBox1;
        private Label label7;
        private Button button6;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
    }
}