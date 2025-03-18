using KiralaGO.UI.Data;
using KiralaGO.UI.Enum;
using KiralaGO.UI.Interface;
using System.Globalization;
using System.Reflection;
using System.Text.Json;

namespace KiralaGO.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<KiralamaBilgisi> kiralananAraclar = new List<KiralamaBilgisi>();

        private void AracOlustur()
        {
            //Araçlar oluþturuldu
            List<IArac> araclar = new List<IArac>
            {
         new Araba { Marka = "Nissan", Model = 2025, Renk = Renk.Gri, GunlukUcret = 1500m,  Tip = AracTipi.Otomobil },
         new Araba { Marka = "Toyota", Model = 2024, Renk = Renk.Beyaz, GunlukUcret = 1400m, Tip = AracTipi.SUV },
         new Araba { Marka = "BMW", Model = 2023, Renk = Renk.Siyah, GunlukUcret = 2500m,  Tip = AracTipi.Otomobil },
         new Araba { Marka = "Mercedes", Model = 2022, Renk = Renk.Mavi, GunlukUcret = 2300m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Ford", Model = 2025, Renk = Renk.Kýrmýzý, GunlukUcret = 1800m, Tip = AracTipi.Kamyonet },
         new Araba { Marka = "Honda", Model = 2024, Renk = Renk.Gri, GunlukUcret = 1600m, Tip = AracTipi.Minibüs },
         new Araba { Marka = "Audi", Model = 2023, Renk = Renk.Beyaz, GunlukUcret = 2700m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Volkswagen", Model = 2022, Renk = Renk.Siyah, GunlukUcret = 1900m, Tip = AracTipi.SUV },
         new Araba { Marka = "Hyundai", Model = 2025, Renk = Renk.Mavi, GunlukUcret = 1500m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Peugeot", Model = 2024, Renk = Renk.Kýrmýzý, GunlukUcret = 1700m, Tip = AracTipi.Kamyonet },
         new Araba { Marka = "Nissan", Model = 2025, Renk = Renk.Gri, GunlukUcret = 1500m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Toyota", Model = 2023, Renk = Renk.Beyaz, GunlukUcret = 1300m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "BMW", Model = 2024, Renk = Renk.Siyah, GunlukUcret = 2500m, Tip = AracTipi.SUV },
         new Araba { Marka = "Mercedes", Model = 2025, Renk = Renk.Mavi, GunlukUcret = 2700m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Audi", Model = 2022, Renk = Renk.Gri, GunlukUcret = 2200m, Tip = AracTipi.SUV },
         new Araba { Marka = "Ford", Model = 2021, Renk = Renk.Kýrmýzý, GunlukUcret = 1100m, Tip = AracTipi.SUV },
         new Araba { Marka = "Honda", Model = 2023, Renk = Renk.Beyaz, GunlukUcret = 1250m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Volkswagen", Model = 2024, Renk = Renk.Siyah, GunlukUcret = 1600m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Hyundai", Model = 2023, Renk = Renk.Gri, GunlukUcret = 1400m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Chevrolet", Model = 2022, Renk = Renk.Mavi, GunlukUcret = 1800m, Tip = AracTipi.SUV }
            };
            foreach (var arac in araclar)
            {
                cbAraclar.Items.Add(arac);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AracOlustur();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            //Araç seçme kontrolü
            if (cbAraclar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir araç seçiniz.");
                return;
            }
            //Gün sayýsý kontrolü
            if (!(int.TryParse(txtGunSayisi.Text, out int gunSayisi) && gunSayisi > 0))
            {
                MessageBox.Show("Gün sayýsý pozitif bir sayý olmalýdýr!");
                return;
            }

            IArac secilenArac = cbAraclar.SelectedItem as IArac;
            //IArac secilenArac = araclar[cbAraclar.SelectedIndex]; //araclar global alana alýnýp bu þekilde de yapýlabilir.

            //Seçilen deðer nullsa otomatik olarak combobox yazým formatý kiralandý olarak yazýldýðý için çýktý araç kiralandý olur
            if (secilenArac == null)
            {
                MessageBox.Show("Araç kiralandý.");
                return;
            }

            decimal kiralamaUcreti = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi > 5)
            {
                kiralamaUcreti *= 0.9m; //%10 indirim uygulanýr.
            }

            KiralamaBilgisi kiralamaBilgisi = new KiralamaBilgisi();
            kiralamaBilgisi.AracMarka = secilenArac.Marka;
            kiralamaBilgisi.ToplamUcret = kiralamaUcreti;
            kiralamaBilgisi.GunSayisi = gunSayisi;
            kiralamaBilgisi.Renk = secilenArac.Renk;

            lstKiralikAracGecmisi.Items.Add(kiralamaBilgisi);
            kiralananAraclar.Add(kiralamaBilgisi);
            lblKiralikAracUcreti.Text = kiralamaUcreti.ToString("C", new CultureInfo("tr-TR"));

            //Seçilen aracý comboboxta kiralandý olarak yaz.
            cbAraclar.Items[cbAraclar.SelectedIndex] = $"{secilenArac.Renk} {secilenArac.Marka} {secilenArac.Tip} ({secilenArac.GunlukUcret}) - Kiralandý";
            secilenArac.MusaitlikDurumu = false;

            //Temizle();
        }

        private void Temizle()
        {
            cbAraclar.SelectedItem = null;
            txtGunSayisi.Text = string.Empty;
            lblKiralikAracUcreti.Text = string.Empty;
        }

        //JSON dosyasýna veri eklemek ve kaydetmek için
        private void JsonVeriKaydet()  
        {
            try
            {   //Dosya ve Dizin Yolu Belirleme
                string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //.exe(çalýþtýrýlabilir dosyanýn) bulunduðu dizinin yolunu döndürür.
                string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "Data"); //Üç seviye yukarý çýkýyor (bin/Debug/net6.0/) Data adlý klasörü hedef olarak belirliyor.
                string dosyaYolu = Path.Combine(hedefDizin, "data.json"); //Data klasörünün içinde data.json adlý dosyanýn tam yolu

                //Klasör Kontrolü
                if (!Directory.Exists(hedefDizin)) //Data klasörü yoksa
                {
                    Directory.CreateDirectory(hedefDizin); //Data klasörü oluþtur.
                }

                List<KiralamaBilgisi> guncelKiralamaBilgileri;

                //Dosya Kontrolü - JSON Dosyasýnýn Okunmasý ve Mevcut Verilerin Alýnmasý
                if (!File.Exists(dosyaYolu)) //data.json dosyasý yoksa
                {
                    guncelKiralamaBilgileri = new List<KiralamaBilgisi>(); //guncelKiralamaBilgileri boþ liste olarak oluþturuluyor.
                }
                else //data.json dosyasý varsa
                {
                    string eskiJson = File.ReadAllText(dosyaYolu); //Dosya içeriði okunuyor
                    var eskiKiralamaBilgileri = JsonSerializer.Deserialize<List<KiralamaBilgisi>>(eskiJson); //JSON formatýndaki metin KiralamaBilgisi türündeki nesnelerin listesine dönüþtürülüyor

                    if (eskiKiralamaBilgileri == null) 
                    {
                        return;
                    }
                    guncelKiralamaBilgileri = eskiKiralamaBilgileri; //Okunan veriler guncelKiralamaBilgileri listesine atanýyor.
                }

                //Yeni Verileri Listeye Eklemek
                guncelKiralamaBilgileri.AddRange(kiralananAraclar); //kiralananAraclar listesindeki yeni kiralama bilgilerini guncelKiralamaBilgileri ne ekliyor.

                //Güncellenmiþ Veriyi JSON Olarak Kaydetme
                var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true }; //JSON'un güzel okunabilir olmasýný saðlar
                string yeniJson = JsonSerializer.Serialize(guncelKiralamaBilgileri, jsonAyarlar); //mevcutVeriler JSON formatýna çevriliyor.
                File.WriteAllText(dosyaYolu, yeniJson); //data.json dosyasýna yazdýrýlýyor.

                MessageBox.Show("Baþarýyla kaydedildi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKaydetJson_Click(object sender, EventArgs e)
        {
            JsonVeriKaydet();
        }
    }
}
