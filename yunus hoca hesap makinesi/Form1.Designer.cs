namespace yunus_hoca_hesap_makinesi
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(358, 73);
            label1.Name = "label1";
            label1.Size = new Size(69, 35);
            label1.TabIndex = 0;
            label1.Text = "kare ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(569, 73);
            label2.Name = "label2";
            label2.Size = new Size(144, 35);
            label2.TabIndex = 1;
            label2.Text = "dikdörtgen ";
            // 
            // button1
            // 
            button1.Location = new Point(314, 276);
            button1.Name = "button1";
            button1.Size = new Size(142, 49);
            button1.TabIndex = 2;
            button1.Text = "kare alan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 155);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 3;
            label3.Text = "kısa kenar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 221);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "uzun kenar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(688, 171);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 8;
            label6.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 171);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 9;
            label5.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 171);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 10;
            label7.Text = "kare alan:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(552, 171);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 11;
            label8.Text = "dikdörtgen alan ";
            label8.Click += label8_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(552, 276);
            button2.Name = "button2";
            button2.Size = new Size(144, 49);
            button2.TabIndex = 12;
            button2.Text = "dikdötrgen alan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(451, 370);
            button3.Name = "button3";
            button3.Size = new Size(108, 68);
            button3.TabIndex = 13;
            button3.Text = "temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
    }
}