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
            //Ara�lar olu�turuldu
            List<IArac> araclar = new List<IArac>
            {
         new Araba { Marka = "Nissan", Model = 2025, Renk = Renk.Gri, GunlukUcret = 1500m,  Tip = AracTipi.Otomobil },
         new Araba { Marka = "Toyota", Model = 2024, Renk = Renk.Beyaz, GunlukUcret = 1400m, Tip = AracTipi.SUV },
         new Araba { Marka = "BMW", Model = 2023, Renk = Renk.Siyah, GunlukUcret = 2500m,  Tip = AracTipi.Otomobil },
         new Araba { Marka = "Mercedes", Model = 2022, Renk = Renk.Mavi, GunlukUcret = 2300m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Ford", Model = 2025, Renk = Renk.K�rm�z�, GunlukUcret = 1800m, Tip = AracTipi.Kamyonet },
         new Araba { Marka = "Honda", Model = 2024, Renk = Renk.Gri, GunlukUcret = 1600m, Tip = AracTipi.Minib�s },
         new Araba { Marka = "Audi", Model = 2023, Renk = Renk.Beyaz, GunlukUcret = 2700m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Volkswagen", Model = 2022, Renk = Renk.Siyah, GunlukUcret = 1900m, Tip = AracTipi.SUV },
         new Araba { Marka = "Hyundai", Model = 2025, Renk = Renk.Mavi, GunlukUcret = 1500m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Peugeot", Model = 2024, Renk = Renk.K�rm�z�, GunlukUcret = 1700m, Tip = AracTipi.Kamyonet },
         new Araba { Marka = "Nissan", Model = 2025, Renk = Renk.Gri, GunlukUcret = 1500m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Toyota", Model = 2023, Renk = Renk.Beyaz, GunlukUcret = 1300m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "BMW", Model = 2024, Renk = Renk.Siyah, GunlukUcret = 2500m, Tip = AracTipi.SUV },
         new Araba { Marka = "Mercedes", Model = 2025, Renk = Renk.Mavi, GunlukUcret = 2700m, Tip = AracTipi.Otomobil },
         new Araba { Marka = "Audi", Model = 2022, Renk = Renk.Gri, GunlukUcret = 2200m, Tip = AracTipi.SUV },
         new Araba { Marka = "Ford", Model = 2021, Renk = Renk.K�rm�z�, GunlukUcret = 1100m, Tip = AracTipi.SUV },
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
            //Ara� se�me kontrol�
            if (cbAraclar.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen bir ara� se�iniz.");
                return;
            }
            //G�n say�s� kontrol�
            if (!(int.TryParse(txtGunSayisi.Text, out int gunSayisi) && gunSayisi > 0))
            {
                MessageBox.Show("G�n say�s� pozitif bir say� olmal�d�r!");
                return;
            }

            IArac secilenArac = cbAraclar.SelectedItem as IArac;
            //IArac secilenArac = araclar[cbAraclar.SelectedIndex]; //araclar global alana al�n�p bu �ekilde de yap�labilir.

            //Se�ilen de�er nullsa otomatik olarak combobox yaz�m format� kiraland� olarak yaz�ld��� i�in ��kt� ara� kiraland� olur
            if (secilenArac == null)
            {
                MessageBox.Show("Ara� kiraland�.");
                return;
            }

            decimal kiralamaUcreti = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi > 5)
            {
                kiralamaUcreti *= 0.9m; //%10 indirim uygulan�r.
            }

            KiralamaBilgisi kiralamaBilgisi = new KiralamaBilgisi();
            kiralamaBilgisi.AracMarka = secilenArac.Marka;
            kiralamaBilgisi.ToplamUcret = kiralamaUcreti;
            kiralamaBilgisi.GunSayisi = gunSayisi;
            kiralamaBilgisi.Renk = secilenArac.Renk;

            lstKiralikAracGecmisi.Items.Add(kiralamaBilgisi);
            kiralananAraclar.Add(kiralamaBilgisi);
            lblKiralikAracUcreti.Text = kiralamaUcreti.ToString("C", new CultureInfo("tr-TR"));

            //Se�ilen arac� comboboxta kiraland� olarak yaz.
            cbAraclar.Items[cbAraclar.SelectedIndex] = $"{secilenArac.Renk} {secilenArac.Marka} {secilenArac.Tip} ({secilenArac.GunlukUcret}) - Kiraland�";
            secilenArac.MusaitlikDurumu = false;

            //Temizle();
        }

        private void Temizle()
        {
            cbAraclar.SelectedItem = null;
            txtGunSayisi.Text = string.Empty;
            lblKiralikAracUcreti.Text = string.Empty;
        }

        //JSON dosyas�na veri eklemek ve kaydetmek i�in
        private void JsonVeriKaydet()  
        {
            try
            {   //Dosya ve Dizin Yolu Belirleme
                string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //.exe(�al��t�r�labilir dosyan�n) bulundu�u dizinin yolunu d�nd�r�r.
                string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "Data"); //�� seviye yukar� ��k�yor (bin/Debug/net6.0/) Data adl� klas�r� hedef olarak belirliyor.
                string dosyaYolu = Path.Combine(hedefDizin, "data.json"); //Data klas�r�n�n i�inde data.json adl� dosyan�n tam yolu

                //Klas�r Kontrol�
                if (!Directory.Exists(hedefDizin)) //Data klas�r� yoksa
                {
                    Directory.CreateDirectory(hedefDizin); //Data klas�r� olu�tur.
                }

                List<KiralamaBilgisi> guncelKiralamaBilgileri;

                //Dosya Kontrol� - JSON Dosyas�n�n Okunmas� ve Mevcut Verilerin Al�nmas�
                if (!File.Exists(dosyaYolu)) //data.json dosyas� yoksa
                {
                    guncelKiralamaBilgileri = new List<KiralamaBilgisi>(); //guncelKiralamaBilgileri bo� liste olarak olu�turuluyor.
                }
                else //data.json dosyas� varsa
                {
                    string eskiJson = File.ReadAllText(dosyaYolu); //Dosya i�eri�i okunuyor
                    var eskiKiralamaBilgileri = JsonSerializer.Deserialize<List<KiralamaBilgisi>>(eskiJson); //JSON format�ndaki metin KiralamaBilgisi t�r�ndeki nesnelerin listesine d�n��t�r�l�yor

                    if (eskiKiralamaBilgileri == null) 
                    {
                        return;
                    }
                    guncelKiralamaBilgileri = eskiKiralamaBilgileri; //Okunan veriler guncelKiralamaBilgileri listesine atan�yor.
                }

                //Yeni Verileri Listeye Eklemek
                guncelKiralamaBilgileri.AddRange(kiralananAraclar); //kiralananAraclar listesindeki yeni kiralama bilgilerini guncelKiralamaBilgileri ne ekliyor.

                //G�ncellenmi� Veriyi JSON Olarak Kaydetme
                var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true }; //JSON'un g�zel okunabilir olmas�n� sa�lar
                string yeniJson = JsonSerializer.Serialize(guncelKiralamaBilgileri, jsonAyarlar); //mevcutVeriler JSON format�na �evriliyor.
                File.WriteAllText(dosyaYolu, yeniJson); //data.json dosyas�na yazd�r�l�yor.

                MessageBox.Show("Ba�ar�yla kaydedildi.");

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
