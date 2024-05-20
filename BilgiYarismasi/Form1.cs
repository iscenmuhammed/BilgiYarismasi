namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 0)
            {
                btnSonraki.Text = "Ba�la";
            }
            if (soruno == 1)
            {
                richTextBox1.Text = "G�l� ile me�hur olan �ehrimiz a�a��dakilerden hangisidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Erzincan";
                btnC.Text = "Isparta";
                btnD.Text = "Mu�";
                label4.Text = "Isparta";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "T�rkiye'nin en fazla ya��� alan ili a�a��dakilerden hangisidir?";
                btnA.Text = "Trabzon";
                btnB.Text = "Rize";
                btnC.Text = "Elaz��";
                btnD.Text = "Tokat";
                label4.Text = "Rize";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "K�rk Mantolu Madonna roman�n�n yazar� kimdir?";
                btnA.Text = "Halide Edip Ad�var";
                btnB.Text = "Ziya G�kalp";
                btnC.Text = "Sabahattin Ali";
                btnD.Text = "Re�at Nuri G�ntekin";
                label4.Text = "Sabahattin Ali";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Osmanl� Devletinin kurucusu olan Osmanl� ailesi hangi T�rk boyuna mensuptur?";
                btnA.Text = "Kay�";
                btnB.Text = "Bozok";
                btnC.Text = "��ok";
                btnD.Text = "K�n�k";
                label4.Text = "Kay�";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Mustafa Kemal Atat�rk, Samsun'a ne zaman ��km��t�r?";
                btnA.Text = "13 May�s 1919";
                btnB.Text = "20 Aral�k 1919";
                btnC.Text = "19 May�s 1919";
                btnD.Text = "28 Ekim 1919";
                label4.Text = "19 May�s 1919";
                btnSonraki.Text = "Sonu�lar";
            }
            if(soruno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;                
                MessageBox.Show("Do�ru Say�s�:" + dogru + "\n" + "Yanl�� Say�s�:" + yanlis + "\n" + "Puan:" + dogru * 20);
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;   
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
