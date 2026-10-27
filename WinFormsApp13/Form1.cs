using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        bool tam = true;

        public Form1()
        {
            InitializeComponent();

            
            foreach (Control c in grpInfo.Controls)
            {
                TextBox tb = c as TextBox;
                if (tb != null)
                {
                    tb.Size = new Size(296, 27);
                    tb.TextChanged += txt_TextChanged;
                }
            }

            Label[] labellar = { lblCSoyad, lblCAd, lblCAta, lblCDogumT, lblCDogumY, lblCCins,
                                 lblCSeriya, lblCFin, lblCAile, lblCVerilme, lblCEtib };
            foreach (Label l in labellar)
            {
                l.AutoSize = false;
                l.Size = new Size(76, 16);
                l.Font = new Font("Segoe UI", 7.5F);
                l.BackColor = Color.Transparent;
            }
            lblCSoyad.Width = 150;
            lblCAd.Width = 150;
            lblCAta.Width = 150;
            lblCDogumT.Width = 150;
            lblCDogumY.Width = 150;
            lblCCins.Width = 150;

            progressBar1.Visible = false;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            lblCSoyad.Text = txtSoyad.Text;
            lblCAd.Text = txtAd.Text;
            lblCAta.Text = txtAtaAdi.Text;
            lblCDogumT.Text = txtDogumTarixi.Text;
            lblCDogumY.Text = txtDogumYeri.Text;
            lblCCins.Text = txtCins.Text;
            lblCSeriya.Text = txtSeriya.Text;
            lblCFin.Text = txtFin.Text;
            lblCAile.Text = txtAileVeziyyeti.Text;
            lblCVerilme.Text = txtVerilmeTarixi.Text;
            lblCEtib.Text = txtEtibarlidir.Text;
        }

       
        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeriya.Text) ||
                string.IsNullOrEmpty(txtFin.Text) ||
                string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtAd.Text) ||
                string.IsNullOrEmpty(txtAtaAdi.Text) ||
                string.IsNullOrEmpty(txtCins.Text) ||
                string.IsNullOrEmpty(txtDogumTarixi.Text) ||
                string.IsNullOrEmpty(txtDogumYeri.Text) ||
                string.IsNullOrEmpty(txtAileVeziyyeti.Text) ||
                string.IsNullOrEmpty(txtVerilmeTarixi.Text) ||
                string.IsNullOrEmpty(txtEtibarlidir.Text) ||
                string.IsNullOrEmpty(txtVerenOrqan.Text))
            {
                tam = false;
            }
            else
            {
                tam = true;
            }

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                DialogResult d;
                if (tam == true)
                {
                    d = MessageBox.Show("Yadda saxlandı", "Məlumat",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    d = MessageBox.Show("Məlumatlar tam daxil edilməyib", "Məlumat",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                }
            }
        }

        
        private void btnSekil_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG faylları (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSeriya.Clear();
            txtFin.Clear();
            txtSoyad.Clear();
            txtAd.Clear();
            txtAtaAdi.Clear();
            txtCins.Clear();
            txtDogumTarixi.Clear();
            txtDogumYeri.Clear();
            txtAileVeziyyeti.Clear();
            txtVerilmeTarixi.Clear();
            txtEtibarlidir.Clear();
            txtVerenOrqan.Clear();
            picFoto.Image = null;
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen qelem = new Pen(Color.RoyalBlue, 2);
            Font basliq = new Font("Segoe UI", 10F, FontStyle.Bold);
            Font kicik = new Font("Segoe UI", 7.5F);

            g.DrawRectangle(qelem, 1, 1, pnlCard.Width - 3, pnlCard.Height - 3);
            g.DrawString("AZƏRBAYCAN RESPUBLİKASI", basliq, Brushes.DarkBlue, 16, 12);
            g.DrawString("Şəxsiyyət vəsiqəsi", kicik, Brushes.DarkBlue, 16, 32);

            string[] sol = { "Soyad:", "Ad:", "Ata adı:", "Doğum tarixi:", "Doğum yeri:", "Cins:" };
            string[] sag = { "Seriya:", "FİN:", "Ailə vəz.:", "Verilmə:", "Etibarlıdır:" };

            for (int i = 0; i < sol.Length; i++)
            {
                g.DrawString(sol[i], kicik, Brushes.Black, 112, 57 + i * 26);
                g.DrawLine(Pens.RoyalBlue, 182, 74 + i * 26, 332, 74 + i * 26);
            }
            for (int i = 0; i < sag.Length; i++)
            {
                g.DrawString(sag[i], kicik, Brushes.Black, 296, 57 + i * 26);
                g.DrawLine(Pens.RoyalBlue, 342, 74 + i * 26, 418, 74 + i * 26);
            }
        }

  
        private void picFoto_Paint(object sender, PaintEventArgs e)
        {
            if (picFoto.Image == null)
            {
                e.Graphics.DrawString("FOTO", new Font("Segoe UI", 9F, FontStyle.Bold),
                    Brushes.DarkBlue, 22, 50);
            }
        }
    }
}