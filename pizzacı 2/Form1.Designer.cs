namespace pizzacı_2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(280, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 35);
            label1.TabIndex = 0;
            label1.Text = "KOPERNİK PİZZASI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "ad soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "telefon No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "adres";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 259);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "pizza boyu";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 300);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "içecekler";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 187);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 66);
            textBox3.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "sucuk";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(169, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "sosis";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(33, 91);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 24);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "zeytin";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(166, 91);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(65, 24);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "kaşar";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Location = new Point(330, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 151);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "pizza malzemeleri";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 478);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(183, 478);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 17;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(339, 478);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(150, 104);
            listBox3.TabIndex = 18;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(499, 478);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(150, 104);
            listBox4.TabIndex = 19;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Location = new Point(655, 478);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(150, 104);
            listBox5.TabIndex = 20;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 20;
            listBox6.Location = new Point(811, 478);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(150, 104);
            listBox6.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 442);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 22;
            label7.Text = "ad soyad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 442);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 23;
            label8.Text = "telefon No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 442);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 24;
            label9.Text = "adres";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(546, 442);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 25;
            label10.Text = "pizza boy ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(698, 442);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 26;
            label11.Text = "içecekler";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(856, 442);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 27;
            label12.Text = "seçilenler";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(902, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(10, 10);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(136, 65);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 65);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(136, 29);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 29);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(290, 341);
            button1.Name = "button1";
            button1.Size = new Size(158, 58);
            button1.TabIndex = 29;
            button1.Text = "SİPARİŞ AL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 341);
            button2.Name = "button2";
            button2.Size = new Size(124, 58);
            button2.TabIndex = 30;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "küçük", "orta ", "büyük" });
            comboBox1.Location = new Point(99, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 31;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "su", "kola", "fanta", "soda" });
            comboBox2.Location = new Point(99, 300);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(961, 594);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}