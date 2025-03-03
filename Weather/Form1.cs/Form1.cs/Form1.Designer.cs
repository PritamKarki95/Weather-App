namespace Form1.cs
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
            txtcity = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtwindm = new TextBox();
            txthumidity = new TextBox();
            txtmintemp = new TextBox();
            txtmaxtemp = new TextBox();
            button1 = new Button();
            label6 = new Label();
            txtwindk = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtcountry = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 44);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter City";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 313);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 1;
            label2.Text = "Maximum Temperature";
            // 
            // txtcity
            // 
            txtcity.Location = new Point(208, 70);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(212, 27);
            txtcity.TabIndex = 2;
            txtcity.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 362);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 3;
            label3.Text = "Minimum Temperature";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 453);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "Wind Speed (mph)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 506);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 5;
            label5.Text = "Wind Speed (kph)";
            // 
            // txtwindm
            // 
            txtwindm.Location = new Point(307, 450);
            txtwindm.Name = "txtwindm";
            txtwindm.Size = new Size(184, 27);
            txtwindm.TabIndex = 6;
            txtwindm.TextAlign = HorizontalAlignment.Center;
            // 
            // txthumidity
            // 
            txthumidity.Location = new Point(307, 400);
            txthumidity.Name = "txthumidity";
            txthumidity.Size = new Size(184, 27);
            txthumidity.TabIndex = 7;
            txthumidity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtmintemp
            // 
            txtmintemp.Location = new Point(307, 355);
            txtmintemp.Name = "txtmintemp";
            txtmintemp.Size = new Size(184, 27);
            txtmintemp.TabIndex = 8;
            txtmintemp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtmaxtemp
            // 
            txtmaxtemp.Location = new Point(307, 306);
            txtmaxtemp.Name = "txtmaxtemp";
            txtmaxtemp.Size = new Size(184, 27);
            txtmaxtemp.TabIndex = 9;
            txtmaxtemp.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(426, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 407);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Humidity";
            // 
            // txtwindk
            // 
            txtwindk.Location = new Point(307, 499);
            txtwindk.Name = "txtwindk";
            txtwindk.Size = new Size(184, 27);
            txtwindk.TabIndex = 12;
            txtwindk.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(293, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 93);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 121);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 14;
            label7.Text = "Condition";
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(219, 252);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(223, 27);
            txtcountry.TabIndex = 15;
            txtcountry.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 556);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 16;
            label8.Text = "Current User Location";
            label8.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 549);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 696);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(txtcountry);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(txtwindk);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtmaxtemp);
            Controls.Add(txtmintemp);
            Controls.Add(txthumidity);
            Controls.Add(txtwindm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcity;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtwindm;
        private TextBox txthumidity;
        private TextBox txtmintemp;
        private TextBox txtmaxtemp;
        private Button button1;
        private Label label6;
        private TextBox txtwindk;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtcountry;
        private Label label8;
        private TextBox textBox1;
    }
}
