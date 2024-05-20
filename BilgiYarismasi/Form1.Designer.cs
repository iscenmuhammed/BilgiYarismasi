namespace BilgiYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblsoruno = new Label();
            lbldogru = new Label();
            lblyanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(-1, -2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(471, 169);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightSeaGreen;
            btnA.Location = new Point(37, 173);
            btnA.Name = "btnA";
            btnA.Size = new Size(173, 67);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.LightSeaGreen;
            btnB.Location = new Point(241, 173);
            btnB.Name = "btnB";
            btnB.Size = new Size(173, 67);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.LightSeaGreen;
            btnC.Location = new Point(37, 265);
            btnC.Name = "btnC";
            btnC.Size = new Size(173, 67);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.LightSeaGreen;
            btnD.Location = new Point(241, 265);
            btnD.Name = "btnD";
            btnD.Size = new Size(173, 67);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(511, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(511, 60);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(516, 108);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Font = new Font("Segoe UI", 10.8F);
            lblsoruno.Location = new Point(587, 19);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(22, 25);
            lblsoruno.TabIndex = 8;
            lblsoruno.Text = "0";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Font = new Font("Segoe UI", 10.8F);
            lbldogru.Location = new Point(571, 60);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(22, 25);
            lbldogru.TabIndex = 9;
            lbldogru.Text = "0";
            // 
            // lblyanlis
            // 
            lblyanlis.AutoSize = true;
            lblyanlis.Font = new Font("Segoe UI", 10.8F);
            lblyanlis.Location = new Point(571, 108);
            lblyanlis.Name = "lblyanlis";
            lblyanlis.Size = new Size(22, 25);
            lblyanlis.TabIndex = 10;
            lblyanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.LightSeaGreen;
            btnSonraki.Location = new Point(499, 148);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(124, 45);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(472, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 353);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 353);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(720, 352);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblyanlis);
            Controls.Add(lbldogru);
            Controls.Add(lblsoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblsoruno;
        private Label lbldogru;
        private Label lblyanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
