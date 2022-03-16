/**********************************************************************************************
**                                      SAKARYA ÜNİVERSİTESİ
**                            BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                 BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                       2021 YAZ DÖNEMİ
**
**                            ÖDEV NUMARASI.......: 2
**                            ÖĞRENCİ ADI.........: YASEMİN ARSLAN
**                            ÖĞRENCİ NUMARASI....: S201210992
**            DERSİN ALINDIĞI GRUP: 1. ÖĞRETİM A
***********************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_2
{

    public partial class Form1 : Form
    {

        // Abstract Urun sinifi
        abstract public class Urun
        {
            // Ad, Marka, Model, Ozellik, StokAdedi, HamFiyat, SecilenAdedi
            protected string Ad { get; set; }
            protected string Marka { get; set; }
            protected string Ozellik { get; set; }

            private int stokadedi;
            protected int StokAdedi
            {
                get
                {
                    return stokadedi;
                }
                set
                {
                    if (value < 0)
                        stokadedi = 0;
                    else
                        stokadedi = value;
                }
            }

            private int hamfiyat;
            protected int HamFiyat
            {
                get
                {
                    return hamfiyat;
                }
                set
                {
                    if (value < 0)
                        hamfiyat = 0;
                    else
                        hamfiyat = value;
                }
            }

            private int secilenadedi;
            protected int SecilenAdedi
            {
                get
                {
                    return secilenadedi;
                }
                set
                {
                    if (value < 0)
                        secilenadedi = 0;
                    else if (value > stokadedi)
                        secilenadedi = stokadedi;
                    else
                        secilenadedi = value;
                }
            }

            private int siparisadedi;
            protected int SiparisAdedi
            {
                get
                {
                    return siparisadedi;
                }
                set
                {
                    if (value < 0)
                        siparisadedi = 0;
                    else
                        siparisadedi = value;
                }
            }

            private int siparisfiyati;
            protected int SiparisFiyati
            {
                get
                {
                    return siparisfiyati;
                }
                set
                {
                    if (value < 0)
                        siparisfiyati = 0;
                    else
                        siparisfiyati = value;
                }
            }

            // Butun tureyen siniflarin olusturmasi gereken fonksyon
            abstract public int KdvUygula();

            public string getAd()
            {
                return Ad;
            }

            public string getMarka()
            {
                return Marka;
            }

            public int getHamFiyat()
            {
                return HamFiyat;
            }

            public void setSiparisAdedi(int adet)
            {
                SiparisAdedi = adet;
            }

            public int getSiparisAdedi()
            {
                return SiparisAdedi;
            }

            public void setSiparisFiyati(int fiyat)
            {
                SiparisFiyati = fiyat;
            }

            public int getSiparisFiyati()
            {
                return SiparisFiyati;
            }

            public void setStokAdedi(int stok)
            {
                StokAdedi = stok;
            }

            public int getStokAdedi()
            {
                return StokAdedi;
            }

            public void getSecilenAdedi(int secilen)
            {
                SecilenAdedi = secilen;
            }

            public int getSecilenAdedi()
            {
                return SecilenAdedi;
            }

            public void setSecilenAdedi(int n)
            {
                this.SecilenAdedi = n;
            }

            public Urun(string ad, string marka, int hamfiyat)
            {
                Random rnd = new Random();

                this.Ad = ad;
                this.Marka = marka;
                this.HamFiyat = hamfiyat;
                this.StokAdedi = rnd.Next(1, 100);
                this.Ozellik = "";
                this.SecilenAdedi = 0;
                this.SiparisAdedi = 0;
                this.SiparisFiyati = 0;
            }

        }

        class Buzdolabi : Urun
        {
            private string enerjisinifi;

            private int ichacim;
            private int Ichacim
            {
                get
                {
                    return this.ichacim;
                }
                set
                {
                    if (value < 0)
                        this.ichacim = 0;
                    else
                        this.ichacim = value;
                }
            }

            override public int KdvUygula()
            {
                return (int)(HamFiyat * 1.05 * SecilenAdedi);
            }

            public Buzdolabi(string marka, int hamfiyat, int ichacim, string enerjisinifi) : base("Buzdolabi", marka, hamfiyat)
            {
                this.Ichacim = ichacim;
                this.enerjisinifi = enerjisinifi;
            }
        }

        class LedTv : Urun
        {
            private double ekranboyutu;
            private double Ekranboyutu

            {
                get
                {
                    return this.ekranboyutu;
                }
                set
                {
                    if (value < 0)
                        this.ekranboyutu = 0.0;
                    else
                        this.ekranboyutu = value;
                }
            }

            private string ekrancozunurlugu;

            override public int KdvUygula()
            {
                return (int)(HamFiyat * 1.18 * SecilenAdedi);
            }

            public LedTv(string marka, int hamfiyat, double ekranboyutu, string ekrancozunurlugu) : base("LedTv", marka, hamfiyat)
            {
                this.Ekranboyutu = ekranboyutu;
                this.ekrancozunurlugu = ekrancozunurlugu;

            }
        }

        class CepTel : Urun
        {
            private int dahiliHafiza;
            private int DahiliHafiza
            {
                get
                {
                    return this.dahiliHafiza;
                }
                set
                {
                    if (value < 0)
                        this.dahiliHafiza = 0;
                    else
                        this.dahiliHafiza = value;
                }
            }

            private int ramKapasitesi;
            private int RamKapasitesi
            {
                get
                {
                    return this.ramKapasitesi;
                }
                set
                {
                    if (value < 0)
                        this.ramKapasitesi = 0;
                    else
                        this.ramKapasitesi = value;
                }
            }

            private int pilGucu;
            private int PilGucu
            {
                get
                {
                    return this.pilGucu;
                }
                set
                {
                    if (value < 0)
                        this.pilGucu = 0;
                    else
                        this.pilGucu = value;
                }
            }

            override public int KdvUygula()
            {
                return (int)(HamFiyat * 1.20 * SecilenAdedi);
            }


            public CepTel(string marka, int hamfiyat, int dahiliHafiza, int ramKapasitesi, int pilGucu) : base("CepTel", marka, hamfiyat)
            {
                this.DahiliHafiza = dahiliHafiza;
                this.RamKapasitesi = ramKapasitesi;
                this.PilGucu = pilGucu;
            }
        }

        class Laptop : Urun
        {
            private double ekranboyutu;
            private double Ekranboyutu

            {
                get
                {
                    return this.ekranboyutu;
                }
                set
                {
                    if (value < 0)
                        this.ekranboyutu = 0.0;
                    else
                        this.ekranboyutu = value;
                }
            }

            private string ekrancozunurlugu;

            private int dahiliHafiza;
            private int DahiliHafiza
            {
                get
                {
                    return this.dahiliHafiza;
                }
                set
                {
                    if (value < 0)
                        this.dahiliHafiza = 0;
                    else
                        this.dahiliHafiza = value;
                }
            }

            private int ramKapasitesi;
            private int RamKapasitesi
            {
                get
                {
                    return this.ramKapasitesi;
                }
                set
                {
                    if (value < 0)
                        this.ramKapasitesi = 0;
                    else
                        this.ramKapasitesi = value;
                }
            }

            private int pilGucu;
            private int PilGucu
            {
                get
                {
                    return this.pilGucu;
                }
                set
                {
                    if (value < 0)
                        this.pilGucu = 0;
                    else
                        this.pilGucu = value;
                }
            }

            override public int KdvUygula()
            {
                return (int)(HamFiyat * 1.15 * SecilenAdedi);
            }


            public Laptop(string marka, int hamfiyat, double ekranboyutu, string ekrancozunurlugu, int dahiliHafiza, int ramKapasitesi, int pilGucu) : base("Laptop", marka, hamfiyat)
            {
                this.Ekranboyutu = ekranboyutu;
                this.ekrancozunurlugu = ekrancozunurlugu;
                this.DahiliHafiza = dahiliHafiza;
                this.RamKapasitesi = ramKapasitesi;
                this.PilGucu = pilGucu;
            }
        }

        public class Sepet
        {
            private int KDVtoplam;
            private List<Urun> Urunler = new List<Urun>();

            public void SepeteUrunEkle(Urun u)
            {
                if (u.getSecilenAdedi() > 0)
                {
                    int sec = u.getSecilenAdedi();
                    int kdv = u.KdvUygula();
                    u.setStokAdedi(u.getStokAdedi() - sec);
                    u.setSecilenAdedi(0);
                    u.setSiparisAdedi(sec);
                    u.setSiparisFiyati(kdv);
                    Urunler.Add(u);
                    KDVtoplam += kdv;
                }
            }

            public void SepetiTemizle()
            {
                KDVtoplam = 0;
                foreach (Urun u in Urunler)
                {
                    u.setStokAdedi(u.getSiparisAdedi() + u.getStokAdedi());
                    u.setSiparisAdedi(0);
                    u.setSiparisFiyati(0);
                }
                Urunler.Clear();
            }

            public List<Urun> getUrunler()
            {
                return Urunler;
            }

            public int getSepetFiyati()
            {
                return KDVtoplam;
            }

            public Sepet()
            {
                KDVtoplam = 0;
            }
        }


        private Buzdolabi b1;
        private LedTv l1;
        private CepTel c1;
        private Laptop p1;
        private Sepet sepet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // objelerimizi olusturalim
            sepet = new Sepet();
            // 4 farkli urun yeterli
            b1 = new Buzdolabi("Arcelik", 1400, 114, "A+");
            l1 = new LedTv("Sony", 3600, 13, "1024x768");
            c1 = new CepTel("Samsung", 2300, 128, 16, 4200);
            p1 = new Laptop("Monster", 14800, 15, "1440x800", 128, 16, 4200);

            // formdaki text leri guncelleyelim.
            txtKDVToplam.Text = "" + 0 + " TL";

            txtStok1.Text = "" + b1.getStokAdedi();
            txtFiyat1.Text = "" + b1.getHamFiyat() + " TL";
            txtAdet1.Value = b1.getSecilenAdedi();

            txtAdet1.Minimum = 0;
            txtAdet1.Maximum = b1.getStokAdedi();


            txtStok2.Text = "" + l1.getStokAdedi();
            txtFiyat2.Text = "" + l1.getHamFiyat() + " TL";
            txtAdet2.Value = l1.getSecilenAdedi();

            txtAdet2.Minimum = 0;
            txtAdet2.Maximum = l1.getStokAdedi();


            txtStok3.Text = "" + c1.getStokAdedi();
            txtFiyat3.Text = "" + c1.getHamFiyat() + " TL";
            txtAdet3.Value = c1.getSecilenAdedi();

            txtAdet3.Minimum = 0;
            txtAdet3.Maximum = c1.getStokAdedi();

            txtStok4.Text = "" + p1.getStokAdedi();
            txtFiyat4.Text = "" + p1.getHamFiyat() + " TL";
            txtAdet4.Value = p1.getSecilenAdedi();

            txtAdet4.Minimum = 0;
            txtAdet4.Maximum = p1.getStokAdedi();
        }

        // secilen urun degistirildiginde urunun icindeki elemani guncelleyelim
        private void txtAdet1_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)txtAdet1.Value;
            b1.setSecilenAdedi(x);
        }

        private void txtAdet2_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)txtAdet2.Value;
            l1.setSecilenAdedi(x);
        }

        private void txtAdet3_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)txtAdet3.Value;
            c1.setSecilenAdedi(x);
        }

        private void txtAdet4_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)txtAdet4.Value;
            p1.setSecilenAdedi(x);
        }

        // sepete ekle butonuna bastigimizda, once sepeti temizleyelim, sonrasinda urunleri ekleyelim.
        // urunlerin secili olup olmadigini sepet icerisindeki fonksyon kontrol edecektir.
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            sepet.SepetiTemizle();
            lstBoxAdet.Items.Clear();
            lstBoxUrun.Items.Clear();
            lstBoxKDVFiyat.Items.Clear();
            txtKDVToplam.Text = "" + 0 + " TL";

            sepet.SepeteUrunEkle(b1);
            sepet.SepeteUrunEkle(l1);
            sepet.SepeteUrunEkle(c1);
            sepet.SepeteUrunEkle(p1);
            int toplam = sepet.getSepetFiyati();
            updateSatinAlinan(sepet.getUrunler());

            txtKDVToplam.Text = "" + toplam + " TL";

            txtStok1.Text = "" + b1.getStokAdedi();
            txtAdet1.Value = b1.getSecilenAdedi();
            txtAdet1.Maximum = b1.getStokAdedi();

            txtStok2.Text = "" + l1.getStokAdedi();
            txtAdet2.Value = l1.getSecilenAdedi();
            txtAdet2.Maximum = l1.getStokAdedi();

            txtStok3.Text = "" + c1.getStokAdedi();
            txtAdet3.Value = c1.getSecilenAdedi();
            txtAdet3.Maximum = c1.getStokAdedi();

            txtStok4.Text = "" + p1.getStokAdedi();
            txtAdet4.Value = p1.getSecilenAdedi();
            txtAdet4.Maximum = p1.getStokAdedi();
        }

        // sepeti temizle tusuna bastigimizda sepeti temizleyelim
        // sonra urunleri eski hallerine geri dondurelim
        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {
            sepet.SepetiTemizle();
            lstBoxAdet.Items.Clear();
            lstBoxUrun.Items.Clear();
            lstBoxKDVFiyat.Items.Clear();
            txtKDVToplam.Text = "" + 0 + " TL";

            txtStok1.Text = "" + b1.getStokAdedi();
            txtAdet1.Value = b1.getSecilenAdedi();
            txtAdet1.Maximum = b1.getStokAdedi();

            txtStok2.Text = "" + l1.getStokAdedi();
            txtAdet2.Value = l1.getSecilenAdedi();
            txtAdet2.Maximum = l1.getStokAdedi();

            txtStok3.Text = "" + c1.getStokAdedi();
            txtAdet3.Value = c1.getSecilenAdedi();
            txtAdet3.Maximum = c1.getStokAdedi();

            txtStok4.Text = "" + p1.getStokAdedi();
            txtAdet4.Value = p1.getSecilenAdedi();
            txtAdet4.Maximum = p1.getStokAdedi();
        }

        // sag taraftaki yerleri sepete ekleye bastiktan sonra guncellemek icin
        private void updateSatinAlinan(List<Urun> Urunler)
        {
            lstBoxAdet.Items.Clear();
            foreach (Urun u in Urunler)
            {
                lstBoxAdet.Items.Add(u.getSiparisAdedi());
                lstBoxUrun.Items.Add(u.getAd());
                lstBoxKDVFiyat.Items.Add(u.getSiparisFiyati());
            }
        }

    }
}
