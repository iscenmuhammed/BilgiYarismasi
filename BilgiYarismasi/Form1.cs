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
                btnSonraki.Text = "Baþla";
            }
            if (soruno == 1)
            {
                richTextBox1.Text = "Gülü ile meþhur olan þehrimiz aþaðýdakilerden hangisidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Erzincan";
                btnC.Text = "Isparta";
                btnD.Text = "Muþ";
                label4.Text = "Isparta";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye'nin en fazla yaðýþ alan ili aþaðýdakilerden hangisidir?";
                btnA.Text = "Trabzon";
                btnB.Text = "Rize";
                btnC.Text = "Elazýð";
                btnD.Text = "Tokat";
                label4.Text = "Rize";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Kürk Mantolu Madonna romanýnýn yazarý kimdir?";
                btnA.Text = "Halide Edip Adývar";
                btnB.Text = "Ziya Gökalp";
                btnC.Text = "Sabahattin Ali";
                btnD.Text = "Reþat Nuri Güntekin";
                label4.Text = "Sabahattin Ali";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Osmanlý Devletinin kurucusu olan Osmanlý ailesi hangi Türk boyuna mensuptur?";
                btnA.Text = "Kayý";
                btnB.Text = "Bozok";
                btnC.Text = "Üçok";
                btnD.Text = "Kýnýk";
                label4.Text = "Kayý";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk, Samsun'a ne zaman çýkmýþtýr?";
                btnA.Text = "13 Mayýs 1919";
                btnB.Text = "20 Aralýk 1919";
                btnC.Text = "19 Mayýs 1919";
                btnD.Text = "28 Ekim 1919";
                label4.Text = "19 Mayýs 1919";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;                
                MessageBox.Show("Doðru Sayýsý:" + dogru + "\n" + "Yanlýþ Sayýsý:" + yanlis + "\n" + "Puan:" + dogru * 20);
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
