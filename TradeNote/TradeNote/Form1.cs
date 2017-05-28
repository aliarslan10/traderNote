using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Klasör işlemleri için gerekli.
using System.Net; //WebClient nesnesi için.

namespace TradeNote
{
    public partial class Form1 : Form
    {
        ListBox lbDosyaAdi = new ListBox();

        public Form1()
        {
            InitializeComponent();

            /* form açılırken yapılacak işlemler */
            bKaydet.Enabled = false;
            bAnlasmaDetayi.Enabled = false;

            WebBrowser sayac = new WebBrowser();
            sayac.ScriptErrorsSuppressed = true;
            sayac.Navigate("http://program-sayaci.blogspot.com.tr/2014/07/twitter-masaustu-program-sayaci.html");

            /* klasor yaratma */
            String klasor = "traderNote";
            Directory.CreateDirectory("C:\\" + klasor);

            /* klasör içindeki dosyaları tara */
            DirectoryInfo klasorKonumu = new DirectoryInfo("C:\\traderNote");
            FileInfo[] dosyalar = klasorKonumu.GetFiles();

            /* klasör içindeki dosyaları oku */
            foreach (FileInfo dosya in dosyalar)
            {
                StreamReader oku = File.OpenText("C:\\traderNote\\" + dosya.Name);

                string veri;
                veri = oku.ReadToEnd();

                String[] parcala;

                while (veri != null)
                {
                    parcala = veri.Split('#');
                    lbSiteniz.Items.Add(parcala[0]);
                    lbSite.Items.Add(parcala[1]);
                    lbTarih1.Items.Add(parcala[2]);
                    lbTarih2.Items.Add(parcala[3]);
                    lbAnlasmaTuru.Items.Add(parcala[4]);
                    lbUcret.Items.Add(parcala[5]);
                    lbAnlasmaYeri.Items.Add(parcala[6]);
                    lbIletisim.Items.Add(parcala[7]);
                    lbEkBilgi.Items.Add(parcala[8]);
                    lbDosyaAdi.Items.Add(parcala[9]);

                    veri = oku.ReadLine();
                }

                oku.Close();
            }
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tbAnlasmaTuru.Text.Length > 0 && tbAnlasmaYeri.Text.Length > 0 && tbAnlasmaYeri.Text.Length > 0 && tbIletisim.Text.Length > 0 && tbSite.Text.Length > 0 && tbSiteniz.Text.Length > 0 && tbTarih1.Text.Length > 0 && tbTarih2.Text.Length > 0 && tbUcret.Text.Length > 0 && tbEkBilgi.Text.Length > 0)
            {
                Random rastgele_sayi = new Random();
                string sayi = (rastgele_sayi.Next(10000,9999999)).ToString();

                string dosyaAdi = tbSiteniz.Text + "_" + sayi;

                /****** DOSYAYA YAZMA İŞLEMİ ******/
                StreamWriter yaz = new StreamWriter("C:\\traderNote\\" + dosyaAdi);
                
                try
                {
                    yaz.Write(tbSiteniz.Text);
                    yaz.Write("#");
                    yaz.Write(tbSite.Text);
                    yaz.Write("#");
                    yaz.Write(tbTarih1.Text);
                    yaz.Write("#");
                    yaz.Write(tbTarih2.Text);
                    yaz.Write("#");
                    yaz.Write(tbAnlasmaTuru.Text);
                    yaz.Write("#");
                    yaz.Write(tbUcret.Text);
                    yaz.Write("#");
                    yaz.Write(tbAnlasmaYeri.Text);
                    yaz.Write("#");
                    yaz.Write(tbIletisim.Text);
                    yaz.Write("#");
                    yaz.Write(tbEkBilgi.Text);
                    yaz.Write("#");
                    yaz.Write(dosyaAdi);
                    yaz.Write("#");
                    yaz.Close();
                }

                catch
                {
                    MessageBox.Show("Veriler kaydedilirken bir hata oluştur.", "UYARI : Kaydetme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                    //LISTBOX DOLDURMA - TEXTBOX TEMİZLEME 
                    lbSite.Items.Add(tbSite.Text);
                    lbSiteniz.Items.Add(tbSiteniz.Text);
                    lbTarih1.Items.Add(tbTarih1.Text);
                    lbTarih2.Items.Add(tbTarih2.Text);
                    lbAnlasmaTuru.Items.Add(tbAnlasmaTuru.Text);
                    lbUcret.Items.Add(tbUcret.Text);
                    lbAnlasmaYeri.Items.Add(tbAnlasmaYeri.Text);
                    lbIletisim.Items.Add(tbIletisim.Text);
                    lbEkBilgi.Items.Add(tbEkBilgi.Text);
                    lbDosyaAdi.Items.Add(dosyaAdi);

                    tbAnlasmaTuru.Text = "";
                    tbAnlasmaYeri.Text = "";
                    tbEkBilgi.Text = "";
                    tbIletisim.Text = "";
                    tbSite.Text = "";
                    tbSiteniz.Text = "";
                    tbTarih1.Text = "";
                    tbTarih2.Text = "";
                    tbUcret.Text = "";

                    MessageBox.Show("Bilgileriniz kaydedildi.");
            }

            else
            {
                MessageBox.Show("Kutucukları boş bırakmayınız!\nÖNERİ : Veri girmek istemediğiniz yerlere 'YOK' yazabilirsiniz.","Hoopps!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                tbSiteniz.Text = lbSiteniz.SelectedItem.ToString();
                tbSite.Text = lbSite.SelectedItem.ToString();
                tbTarih1.Text = lbTarih1.SelectedItem.ToString();
                tbTarih2.Text = lbTarih2.SelectedItem.ToString();
                tbAnlasmaTuru.Text = lbAnlasmaTuru.SelectedItem.ToString();
                tbUcret.Text = lbUcret.SelectedItem.ToString();
                tbAnlasmaYeri.Text = lbAnlasmaYeri.SelectedItem.ToString();
                tbIletisim.Text = lbIletisim.SelectedItem.ToString();
                tbEkBilgi.Text = lbEkBilgi.SelectedItem.ToString();

                bKaydet.Enabled = true;
                bEkle.Enabled = false;
            }

            catch
            {
                MessageBox.Show("Düzenlemek istediğiniz veriyi seçmediniz!","Hoopps",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
                try
                {
                    DialogResult sonuc = MessageBox.Show("Veriyi silmek istediğinizden emin misiniz?\n*Silinen veri geri alınamaz.", "Hoopps!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(sonuc == DialogResult.Yes)
                        {
                        File.Delete("C:\\traderNote\\" + lbDosyaAdi.Items[lbSiteniz.SelectedIndex]);

                        lbSiteniz.Items.Clear();
                        lbSite.Items.Clear();
                        lbTarih1.Items.Clear();
                        lbTarih2.Items.Clear();
                        lbAnlasmaTuru.Items.Clear();
                        lbUcret.Items.Clear();
                        lbAnlasmaYeri.Items.Clear();
                        lbIletisim.Items.Clear();
                        lbEkBilgi.Items.Clear();
                        lbDosyaAdi.Items.Clear();

                        yenile();
                    }
                }

                catch
                {
                    MessageBox.Show("Silmek istediğiniz şarkıyı seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void bGoruntule_Click(object sender, EventArgs e)
        {
            if(lbIletisim.SelectedIndex != -1)
            {
                lblSiteniz.Text = lbSiteniz.SelectedItem.ToString();
                lblSite.Text = lbSite.SelectedItem.ToString();
                lblTarih1.Text = lbTarih1.SelectedItem.ToString();
                lblTarih2.Text = lbTarih2.SelectedItem.ToString();
                lblAnlasmaTuru.Text = lbAnlasmaTuru.SelectedItem.ToString();
                lblUcret.Text = lbUcret.SelectedItem.ToString();
                lblAnlasmaYeri.Text = lbAnlasmaYeri.SelectedItem.ToString();
                lblIletisim.Text = lbIletisim.SelectedItem.ToString();
                lblEkBilgi.Text = lbEkBilgi.SelectedItem.ToString();

                bAnlasmaDetayi.Enabled = true;
            }

            else
            {
                MessageBox.Show("Detaylarını görüntülemek istediğiniz anlaşmayı seçmediniz!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tbAnlasmaTuru.Text.Length > 0 && tbAnlasmaYeri.Text.Length > 0 && tbAnlasmaYeri.Text.Length > 0 && tbIletisim.Text.Length > 0 && tbSite.Text.Length > 0 && tbSiteniz.Text.Length > 0 && tbTarih1.Text.Length > 0 && tbTarih2.Text.Length > 0 && tbUcret.Text.Length > 0)
            {
                bEkle.Enabled = true;
                bKaydet.Enabled = false;

                StreamWriter yaz = new StreamWriter("C:\\traderNote\\" + lbDosyaAdi.SelectedItem.ToString());

                try
                {
                    yaz.Write(tbSiteniz.Text);
                    yaz.Write("#");
                    yaz.Write(tbSite.Text);
                    yaz.Write("#");
                    yaz.Write(tbTarih1.Text);
                    yaz.Write("#");
                    yaz.Write(tbTarih2.Text);
                    yaz.Write("#");
                    yaz.Write(tbAnlasmaTuru.Text);
                    yaz.Write("#");
                    yaz.Write(tbUcret.Text);
                    yaz.Write("#");
                    yaz.Write(tbAnlasmaYeri.Text);
                    yaz.Write("#");
                    yaz.Write(tbIletisim.Text);
                    yaz.Write("#");
                    yaz.Write(tbEkBilgi.Text);
                    yaz.Write("#");
                    yaz.Write(lbDosyaAdi.SelectedItem.ToString());
                    yaz.Write("#");
                    yaz.Close();
                }

                catch
                {
                    MessageBox.Show("Veriler kaydedilirken bir hata oluştur.", "UYARI : Kaydetme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //LISTBOX DOLDURMA - TEXTBOX TEMİZLEME 
                lbSite.Items.Add(tbSite.Text);
                lbSiteniz.Items.Add(tbSiteniz.Text);
                lbTarih1.Items.Add(tbTarih1.Text);
                lbTarih2.Items.Add(tbTarih2.Text);
                lbAnlasmaTuru.Items.Add(tbAnlasmaTuru.Text);
                lbUcret.Items.Add(tbUcret.Text);
                lbAnlasmaYeri.Items.Add(tbAnlasmaYeri.Text);
                lbIletisim.Items.Add(tbIletisim.Text);
                lbEkBilgi.Items.Add(tbEkBilgi.Text);

                tbAnlasmaTuru.Text = "";
                tbAnlasmaYeri.Text = "";
                tbEkBilgi.Text = "";
                tbIletisim.Text = "";
                tbSite.Text = "";
                tbSiteniz.Text = "";
                tbTarih1.Text = "";
                tbTarih2.Text = "";
                tbUcret.Text = "";

                MessageBox.Show("Bilgileriniz kaydedildi.");

                //********** LISTBOX GÜNCELLEME ************//
                lbSiteniz.Items.Clear();
                lbSite.Items.Clear();
                lbTarih1.Items.Clear();
                lbTarih2.Items.Clear();
                lbAnlasmaTuru.Items.Clear();
                lbUcret.Items.Clear();
                lbAnlasmaYeri.Items.Clear();
                lbIletisim.Items.Clear();
                lbEkBilgi.Items.Clear();
                lbDosyaAdi.Items.Clear();

                yenile();
            }

            else
            {
                MessageBox.Show("Kutucukları boş bırakmayınız!\nÖNERİ : Veri girmek istemediğiniz yerlere 'YOK' yazabilirsiniz.", "Hoopps!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void yenile()
        {
            /* klasör içindeki dosyaları tara */
            DirectoryInfo klasorKonumu = new DirectoryInfo("C:\\traderNote");
            FileInfo[] dosyalar = klasorKonumu.GetFiles();

            /* klasör içindeki dosyaları oku */
            foreach (FileInfo dosya in dosyalar)
            {
                StreamReader oku = File.OpenText("C:\\traderNote\\" + dosya.Name);

                string veri;
                veri = oku.ReadToEnd();

                String[] parcala;

                while (veri != null)
                {
                    parcala = veri.Split('#');
                    lbSiteniz.Items.Add(parcala[0]);
                    lbSite.Items.Add(parcala[1]);
                    lbTarih1.Items.Add(parcala[2]);
                    lbTarih2.Items.Add(parcala[3]);
                    lbAnlasmaTuru.Items.Add(parcala[4]);
                    lbUcret.Items.Add(parcala[5]);
                    lbAnlasmaYeri.Items.Add(parcala[6]);
                    lbIletisim.Items.Add(parcala[7]);
                    lbEkBilgi.Items.Add(parcala[8]);
                    lbDosyaAdi.Items.Add(parcala[9]);

                    veri = oku.ReadLine();
                }

                oku.Close();
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                e.Cancel = false;
            }

            else
            {
                e.Cancel = true;
            }
        }

        private void lbSiteniz_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbSiteniz.SelectedIndex;
            lbTarih1.SelectedIndex = lbSiteniz.SelectedIndex;
            lbTarih2.SelectedIndex = lbSiteniz.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbSiteniz.SelectedIndex;
            lbUcret.SelectedIndex = lbSiteniz.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbSiteniz.SelectedIndex;
            lbIletisim.SelectedIndex = lbSiteniz.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbSiteniz.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbSiteniz.SelectedIndex;
        }

        private void lbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSiteniz.SelectedIndex = lbSite.SelectedIndex;
            lbTarih1.SelectedIndex = lbSite.SelectedIndex;
            lbTarih2.SelectedIndex = lbSite.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbSite.SelectedIndex;
            lbUcret.SelectedIndex = lbSite.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbSite.SelectedIndex;
            lbIletisim.SelectedIndex = lbSite.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbSite.SelectedIndex;
            lbDosyaAdi.SelectedIndex =lbSite.SelectedIndex;
        }

        private void lbTarih1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbTarih1.SelectedIndex;
            lbSiteniz.SelectedIndex = lbTarih1.SelectedIndex;
            lbTarih2.SelectedIndex = lbTarih1.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbTarih1.SelectedIndex;
            lbUcret.SelectedIndex = lbTarih1.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbTarih1.SelectedIndex;
            lbIletisim.SelectedIndex = lbTarih1.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbTarih1.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbTarih1.SelectedIndex;
        }

        private void lbAnlasmaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbTarih1.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbTarih2.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbSiteniz.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbUcret.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbIletisim.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbAnlasmaTuru.SelectedIndex;
        }

        private void lbUcret_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbUcret.SelectedIndex;
            lbTarih1.SelectedIndex = lbUcret.SelectedIndex;
            lbTarih2.SelectedIndex = lbUcret.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbUcret.SelectedIndex;
            lbSiteniz.SelectedIndex = lbUcret.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbUcret.SelectedIndex;
            lbIletisim.SelectedIndex = lbUcret.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbUcret.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbUcret.SelectedIndex;
        }

        private void lbAnlasmaYeri_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbTarih1.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbTarih2.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbUcret.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbSiteniz.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbIletisim.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbAnlasmaYeri.SelectedIndex;
        }

        private void lbIletisim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbIletisim.SelectedIndex;
            lbTarih1.SelectedIndex = lbIletisim.SelectedIndex;
            lbTarih2.SelectedIndex = lbIletisim.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbIletisim.SelectedIndex;
            lbUcret.SelectedIndex = lbIletisim.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbIletisim.SelectedIndex;
            lbSiteniz.SelectedIndex = lbIletisim.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbIletisim.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbIletisim.SelectedIndex;
        }

        private void lbEkBilgi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbTarih1.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbTarih2.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbUcret.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbIletisim.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbSiteniz.SelectedIndex = lbEkBilgi.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbEkBilgi.SelectedIndex;
        }

        private void lbTarih2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSite.SelectedIndex = lbTarih2.SelectedIndex;
            lbSiteniz.SelectedIndex = lbTarih2.SelectedIndex;
            lbTarih1.SelectedIndex = lbTarih2.SelectedIndex;
            lbAnlasmaTuru.SelectedIndex = lbTarih2.SelectedIndex;
            lbUcret.SelectedIndex = lbTarih2.SelectedIndex;
            lbAnlasmaYeri.SelectedIndex = lbTarih2.SelectedIndex;
            lbIletisim.SelectedIndex = lbTarih2.SelectedIndex;
            lbEkBilgi.SelectedIndex = lbTarih2.SelectedIndex;
            lbDosyaAdi.SelectedIndex = lbTarih2.SelectedIndex;
        }

        private void bAnlasmaDetayi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblEkBilgi.Text, "Anlaşmaya Ait Detaylar");
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
