namespace WinFormsApp13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpCard = new GroupBox();
            pnlPreview = new Panel();
            pnlCard = new Panel();
            picFoto = new PictureBox();
            lblCSoyad = new Label();
            lblCAd = new Label();
            lblCAta = new Label();
            lblCDogumT = new Label();
            lblCDogumY = new Label();
            lblCCins = new Label();
            lblCSeriya = new Label();
            lblCFin = new Label();
            lblCAile = new Label();
            lblCVerilme = new Label();
            lblCEtib = new Label();
            btnSekil = new Button();
            grpInfo = new GroupBox();
            lblSeriya = new Label();
            txtSeriya = new TextBox();
            lblFin = new Label();
            txtFin = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblAd = new Label();
            txtAd = new TextBox();
            lblAtaAdi = new Label();
            txtAtaAdi = new TextBox();
            lblCins = new Label();
            txtCins = new TextBox();
            lblDogumTarixi = new Label();
            txtDogumTarixi = new TextBox();
            lblDogumYeri = new Label();
            txtDogumYeri = new TextBox();
            lblAileVeziyyeti = new Label();
            txtAileVeziyyeti = new TextBox();
            lblVerilmeTarixi = new Label();
            txtVerilmeTarixi = new TextBox();
            lblEtibarlidir = new Label();
            txtEtibarlidir = new TextBox();
            lblVerenOrqan = new Label();
            txtVerenOrqan = new TextBox();
            progressBar1 = new ProgressBar();
            btnTemizle = new Button();
            btnSaxla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            grpCard.SuspendLayout();
            pnlPreview.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            
            grpCard.Controls.Add(pnlPreview);
            grpCard.Controls.Add(btnSekil);
            grpCard.Location = new Point(12, 12);
            grpCard.Name = "grpCard";
            grpCard.Size = new Size(470, 520);
            grpCard.TabIndex = 0;
            grpCard.TabStop = false;
            grpCard.Text = "Şəxsiyyət vəsiqəsi";
             
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderStyle = BorderStyle.FixedSingle;
            pnlPreview.Controls.Add(pnlCard);
            pnlPreview.Location = new Point(12, 22);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(446, 440);
            pnlPreview.TabIndex = 0;
           
            pnlCard.BackColor = Color.FromArgb(221, 232, 246);
            pnlCard.Controls.Add(picFoto);
            pnlCard.Controls.Add(lblCSoyad);
            pnlCard.Controls.Add(lblCAd);
            pnlCard.Controls.Add(lblCAta);
            pnlCard.Controls.Add(lblCDogumT);
            pnlCard.Controls.Add(lblCDogumY);
            pnlCard.Controls.Add(lblCCins);
            pnlCard.Controls.Add(lblCSeriya);
            pnlCard.Controls.Add(lblCFin);
            pnlCard.Controls.Add(lblCAile);
            pnlCard.Controls.Add(lblCVerilme);
            pnlCard.Controls.Add(lblCEtib);
            pnlCard.Location = new Point(9, 80);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(424, 250);
            pnlCard.TabIndex = 0;
            pnlCard.Paint += pnlCard_Paint;
           
            picFoto.BackColor = Color.FromArgb(184, 200, 225);
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(14, 56);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(90, 120);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            picFoto.Paint += picFoto_Paint;
            
            lblCSoyad.Location = new Point(182, 56);
            lblCSoyad.Name = "lblCSoyad";
            lblCSoyad.Size = new Size(100, 23);
            lblCSoyad.TabIndex = 1;
            
            lblCAd.Location = new Point(182, 82);
            lblCAd.Name = "lblCAd";
            lblCAd.Size = new Size(100, 23);
            lblCAd.TabIndex = 2;
          
            lblCAta.Location = new Point(182, 108);
            lblCAta.Name = "lblCAta";
            lblCAta.Size = new Size(100, 23);
            lblCAta.TabIndex = 3;
           
            lblCDogumT.Location = new Point(182, 134);
            lblCDogumT.Name = "lblCDogumT";
            lblCDogumT.Size = new Size(100, 23);
            lblCDogumT.TabIndex = 4;
            
            lblCDogumY.Location = new Point(182, 160);
            lblCDogumY.Name = "lblCDogumY";
            lblCDogumY.Size = new Size(100, 23);
            lblCDogumY.TabIndex = 5;
            
            lblCCins.Location = new Point(182, 186);
            lblCCins.Name = "lblCCins";
            lblCCins.Size = new Size(100, 23);
            lblCCins.TabIndex = 6;
            
            lblCSeriya.Location = new Point(342, 56);
            lblCSeriya.Name = "lblCSeriya";
            lblCSeriya.Size = new Size(100, 23);
            lblCSeriya.TabIndex = 7;
            
            lblCFin.Location = new Point(342, 82);
            lblCFin.Name = "lblCFin";
            lblCFin.Size = new Size(100, 23);
            lblCFin.TabIndex = 8;
            
            lblCAile.Location = new Point(342, 108);
            lblCAile.Name = "lblCAile";
            lblCAile.Size = new Size(100, 23);
            lblCAile.TabIndex = 9;
           
            lblCVerilme.Location = new Point(342, 134);
            lblCVerilme.Name = "lblCVerilme";
            lblCVerilme.Size = new Size(100, 23);
            lblCVerilme.TabIndex = 10;
            
            lblCEtib.Location = new Point(342, 160);
            lblCEtib.Name = "lblCEtib";
            lblCEtib.Size = new Size(100, 23);
            lblCEtib.TabIndex = 11;
           
            btnSekil.Location = new Point(12, 472);
            btnSekil.Name = "btnSekil";
            btnSekil.Size = new Size(446, 34);
            btnSekil.TabIndex = 1;
            btnSekil.Text = "Şəkil yüklə...";
            btnSekil.UseVisualStyleBackColor = true;
            btnSekil.Click += btnSekil_Click;
            
            grpInfo.Controls.Add(lblSeriya);
            grpInfo.Controls.Add(txtSeriya);
            grpInfo.Controls.Add(lblFin);
            grpInfo.Controls.Add(txtFin);
            grpInfo.Controls.Add(lblSoyad);
            grpInfo.Controls.Add(txtSoyad);
            grpInfo.Controls.Add(lblAd);
            grpInfo.Controls.Add(txtAd);
            grpInfo.Controls.Add(lblAtaAdi);
            grpInfo.Controls.Add(txtAtaAdi);
            grpInfo.Controls.Add(lblCins);
            grpInfo.Controls.Add(txtCins);
            grpInfo.Controls.Add(lblDogumTarixi);
            grpInfo.Controls.Add(txtDogumTarixi);
            grpInfo.Controls.Add(lblDogumYeri);
            grpInfo.Controls.Add(txtDogumYeri);
            grpInfo.Controls.Add(lblAileVeziyyeti);
            grpInfo.Controls.Add(txtAileVeziyyeti);
            grpInfo.Controls.Add(lblVerilmeTarixi);
            grpInfo.Controls.Add(txtVerilmeTarixi);
            grpInfo.Controls.Add(lblEtibarlidir);
            grpInfo.Controls.Add(txtEtibarlidir);
            grpInfo.Controls.Add(lblVerenOrqan);
            grpInfo.Controls.Add(txtVerenOrqan);
            grpInfo.Location = new Point(494, 12);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(504, 520);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Vəsiqə məlumatları";
           
            lblSeriya.Location = new Point(16, 36);
            lblSeriya.Name = "lblSeriya";
            lblSeriya.Size = new Size(170, 20);
            lblSeriya.TabIndex = 0;
            lblSeriya.Text = "Seriya və nömrə:";
           
            txtSeriya.Location = new Point(190, 32);
            txtSeriya.Name = "txtSeriya";
            txtSeriya.Size = new Size(100, 27);
            txtSeriya.TabIndex = 1;
            
            lblFin.Location = new Point(16, 74);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(170, 20);
            lblFin.TabIndex = 2;
            lblFin.Text = "FİN kod:";
          
            txtFin.Location = new Point(190, 70);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 27);
            txtFin.TabIndex = 3;
           
            lblSoyad.Location = new Point(16, 112);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(170, 20);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad:";
            
            txtSoyad.Location = new Point(190, 108);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 27);
            txtSoyad.TabIndex = 5;
          
            lblAd.Location = new Point(16, 150);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(170, 20);
            lblAd.TabIndex = 6;
            lblAd.Text = "Ad:";
            
            txtAd.Location = new Point(190, 146);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 27);
            txtAd.TabIndex = 7;
           
            lblAtaAdi.Location = new Point(16, 188);
            lblAtaAdi.Name = "lblAtaAdi";
            lblAtaAdi.Size = new Size(170, 20);
            lblAtaAdi.TabIndex = 8;
            lblAtaAdi.Text = "Ata adı:";
           
            txtAtaAdi.Location = new Point(190, 184);
            txtAtaAdi.Name = "txtAtaAdi";
            txtAtaAdi.Size = new Size(100, 27);
            txtAtaAdi.TabIndex = 9;
             
            lblCins.Location = new Point(16, 226);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(170, 20);
            lblCins.TabIndex = 10;
            lblCins.Text = "Cins:";
          
            txtCins.Location = new Point(190, 222);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(100, 27);
            txtCins.TabIndex = 11;
            
            lblDogumTarixi.Location = new Point(16, 264);
            lblDogumTarixi.Name = "lblDogumTarixi";
            lblDogumTarixi.Size = new Size(170, 20);
            lblDogumTarixi.TabIndex = 12;
            lblDogumTarixi.Text = "Doğum tarixi:";
            
            txtDogumTarixi.Location = new Point(190, 260);
            txtDogumTarixi.Name = "txtDogumTarixi";
            txtDogumTarixi.Size = new Size(100, 27);
            txtDogumTarixi.TabIndex = 13;
          
            lblDogumYeri.Location = new Point(16, 302);
            lblDogumYeri.Name = "lblDogumYeri";
            lblDogumYeri.Size = new Size(170, 20);
            lblDogumYeri.TabIndex = 14;
            lblDogumYeri.Text = "Doğum yeri:";
            
            txtDogumYeri.Location = new Point(190, 298);
            txtDogumYeri.Name = "txtDogumYeri";
            txtDogumYeri.Size = new Size(100, 27);
            txtDogumYeri.TabIndex = 15;
           
            lblAileVeziyyeti.Location = new Point(16, 340);
            lblAileVeziyyeti.Name = "lblAileVeziyyeti";
            lblAileVeziyyeti.Size = new Size(170, 20);
            lblAileVeziyyeti.TabIndex = 16;
            lblAileVeziyyeti.Text = "Ailə vəziyyəti:";
           
            txtAileVeziyyeti.Location = new Point(190, 336);
            txtAileVeziyyeti.Name = "txtAileVeziyyeti";
            txtAileVeziyyeti.Size = new Size(100, 27);
            txtAileVeziyyeti.TabIndex = 17;
            
            lblVerilmeTarixi.Location = new Point(16, 378);
            lblVerilmeTarixi.Name = "lblVerilmeTarixi";
            lblVerilmeTarixi.Size = new Size(170, 20);
            lblVerilmeTarixi.TabIndex = 18;
            lblVerilmeTarixi.Text = "Verilmə tarixi:";
            
            txtVerilmeTarixi.Location = new Point(190, 374);
            txtVerilmeTarixi.Name = "txtVerilmeTarixi";
            txtVerilmeTarixi.Size = new Size(100, 27);
            txtVerilmeTarixi.TabIndex = 19;
            
            lblEtibarlidir.Location = new Point(16, 416);
            lblEtibarlidir.Name = "lblEtibarlidir";
            lblEtibarlidir.Size = new Size(170, 20);
            lblEtibarlidir.TabIndex = 20;
            lblEtibarlidir.Text = "Etibarlıdır:";
            
            txtEtibarlidir.Location = new Point(190, 412);
            txtEtibarlidir.Name = "txtEtibarlidir";
            txtEtibarlidir.Size = new Size(100, 27);
            txtEtibarlidir.TabIndex = 21;
             
            lblVerenOrqan.Location = new Point(16, 454);
            lblVerenOrqan.Name = "lblVerenOrqan";
            lblVerenOrqan.Size = new Size(170, 20);
            lblVerenOrqan.TabIndex = 22;
            lblVerenOrqan.Text = "Verən orqan:";
          
            txtVerenOrqan.Location = new Point(190, 450);
            txtVerenOrqan.Name = "txtVerenOrqan";
            txtVerenOrqan.Size = new Size(100, 27);
            txtVerenOrqan.TabIndex = 23;
            
            progressBar1.Location = new Point(12, 546);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(740, 26);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            
            btnTemizle.Location = new Point(772, 542);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(105, 34);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Təmizlə";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
           
            btnSaxla.Location = new Point(893, 542);
            btnSaxla.Name = "btnSaxla";
            btnSaxla.Size = new Size(105, 34);
            btnSaxla.TabIndex = 4;
            btnSaxla.Text = "Yadda saxla";
            btnSaxla.UseVisualStyleBackColor = true;
            btnSaxla.Click += btnSaxla_Click;
            
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            
            openFileDialog1.Filter = "PNG faylları (*.png)|*.png";
            openFileDialog1.Title = "Şəkil seçin";
           
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1010, 590);
            Controls.Add(grpCard);
            Controls.Add(grpInfo);
            Controls.Add(progressBar1);
            Controls.Add(btnTemizle);
            Controls.Add(btnSaxla);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
            grpCard.ResumeLayout(false);
            pnlPreview.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblCSoyad, lblCAd, lblCAta, lblCDogumT, lblCDogumY, lblCCins;
        private System.Windows.Forms.Label lblCSeriya, lblCFin, lblCAile, lblCVerilme, lblCEtib;
        private System.Windows.Forms.Button btnSekil;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblSeriya, lblFin, lblSoyad, lblAd, lblAtaAdi, lblCins;
        private System.Windows.Forms.Label lblDogumTarixi, lblDogumYeri, lblAileVeziyyeti, lblVerilmeTarixi, lblEtibarlidir, lblVerenOrqan;
        private System.Windows.Forms.TextBox txtSeriya, txtFin, txtSoyad, txtAd, txtAtaAdi, txtCins;
        private System.Windows.Forms.TextBox txtDogumTarixi, txtDogumYeri, txtAileVeziyyeti, txtVerilmeTarixi, txtEtibarlidir, txtVerenOrqan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSaxla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}