namespace Encrypt
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 281);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(530, 31);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(580, 279);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 2;
            button1.Text = "Encode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 145);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 31);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter Text (Uppercase):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Number(-26 to 26):";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 360);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(530, 31);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 438);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(530, 31);
            textBox5.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(580, 360);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 4;
            button2.Text = "Input Code";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(580, 438);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 5;
            button3.Text = "Output Code";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 527);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(530, 31);
            textBox6.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(580, 527);
            button4.Name = "button4";
            button4.Size = new Size(124, 34);
            button4.TabIndex = 7;
            button4.Text = "Sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(716, 966);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
        private Button button4;
    }
}
