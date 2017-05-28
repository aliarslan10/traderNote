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

namespace TradeNote //NAMESPACE AYNI OLMALI !!!!
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(25);
            sayac++;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }

            if(sayac == 1)
            {
                guncelleme_kontrol();
            }
        }

        /*** GÜNCELLEME İLE İLGİLİ İŞLEMLER ***/

        private void guncelleme_kontrol()
        {

        try{

            if (kontrol())
            {
                DialogResult sonuc = MessageBox.Show("Bir yeni güncelleme var.\nGüncellemeyi şimdi yüklemek ister misin?", "1 Yeni Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    try
                    {
                        WebBrowser web = new WebBrowser();
                        web.ScriptErrorsSuppressed = false;
                        web.Navigate("http://www.aliarslan.hol.es/traderNote.rar");

                    }

                    catch
                    {
                        MessageBox.Show("Yüklerken hata oluştu. Bilgisayarınızda internet explorer tarayıcısı olduğundan veya düzgün çalıştığından emin olun.");
                    }

                    MessageBox.Show("İlginiz için teşekkürler! traderNote programının eski sürümünü silip artık indirilen bu güncel sürümünü kullanabilirsiniz. Yeni sürüm ile beraber daha önceki kayıtlarınız da otomatik olarak bu yeni sürüme aktarılmaktadır. Bu yeni sürüm ile ilgili detaylı bilgilere www.blogkafem.net adresinden ulaşabilirsiniz. [Ali Arslan]", "Yükleme Tamamlandı!");
                }
            }

        }

       catch
         {
             MessageBox.Show("Güncelleme kontrolü yapılamadı! Lütfen internet bağlantınızın olup olmadığını kontrol ediniz veya daha sonra tekrar deneyiniz!", "Hata : Sunucuya bağlanılamıyor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
}

        private Boolean kontrol()
        {
                Boolean sonuc;

                WebClient kullanici = new WebClient(); 
                Stream site_adresi = kullanici.OpenRead("http://aliarslan.hol.es/update.php?v=" + "2");

                StreamReader oku = new StreamReader(site_adresi);
                String icerik = oku.ReadToEnd();

                if (icerik == "GUNCELLE")
                {
                    sonuc = true;
                }

                else
                {
                    sonuc = false;
                    MessageBox.Show("traderNote programının en güncel sürümünü kullanmaktasınız.", "Güncelleme Yok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return sonuc;
            }
    }
}
