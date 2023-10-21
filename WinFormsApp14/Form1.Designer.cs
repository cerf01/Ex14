namespace WinFormsApp14
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            maxPanel1 = new NumericUpDown();
            minPanel1 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            maxPanel2 = new NumericUpDown();
            button6 = new Button();
            label2 = new Label();
            minPanel2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minPanel1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minPanel2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(208, 43);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 0;
            button1.Text = "Show/Hide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 271);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 1;
            button2.Text = "Show/Hide";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(maxPanel1);
            panel1.Controls.Add(minPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(102, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 145);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(132, 117);
            button4.Name = "button4";
            button4.Size = new Size(55, 25);
            button4.TabIndex = 4;
            button4.Text = "stop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(117, 89);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 3;
            button3.Text = "start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // maxPanel1
            // 
            maxPanel1.Location = new Point(197, 60);
            maxPanel1.Name = "maxPanel1";
            maxPanel1.Size = new Size(59, 23);
            maxPanel1.TabIndex = 2;
            // 
            // minPanel1
            // 
            minPanel1.Location = new Point(79, 60);
            minPanel1.Name = "minPanel1";
            minPanel1.Size = new Size(59, 23);
            minPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(192, 8);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 5;
            label3.Text = "Prime number";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(maxPanel2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(minPanel2);
            panel2.Location = new Point(102, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 149);
            panel2.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(132, 116);
            button5.Name = "button5";
            button5.Size = new Size(55, 24);
            button5.TabIndex = 6;
            button5.Text = "stop";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // maxPanel2
            // 
            maxPanel2.Location = new Point(197, 62);
            maxPanel2.Name = "maxPanel2";
            maxPanel2.Size = new Size(59, 23);
            maxPanel2.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(117, 91);
            button6.Name = "button6";
            button6.Size = new Size(82, 24);
            button6.TabIndex = 5;
            button6.Text = "start";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 40);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 3;
            // 
            // minPanel2
            // 
            minPanel2.Location = new Point(79, 62);
            minPanel2.Name = "minPanel2";
            minPanel2.Size = new Size(59, 23);
            minPanel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(181, 236);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 6;
            label4.Text = "Fibonacci sequence";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 40);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 7;
            label5.Text = "min:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 44);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 8;
            label6.Text = "max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 42);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 7;
            label7.Text = "min:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(197, 42);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 8;
            label8.Text = "max";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 458);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)minPanel1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)minPanel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private NumericUpDown maxPanel1;
        private NumericUpDown minPanel1;
        private Label label1;
        private NumericUpDown maxPanel2;
        private Label label2;
        private NumericUpDown minPanel2;
        private Button button5;
        private Button button6;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}