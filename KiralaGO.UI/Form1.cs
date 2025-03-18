using KiralaGO.UI.Data;
using KiralaGO.UI.Enum;
using KiralaGO.UI.Interface;
using System.Globalization;

namespace KiralaGO.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            lblKiralikAracUcreti.Text = kiralamaUcreti.ToString("C", new CultureInfo("tr-TR"));

            //Seçilen aracý comboboxta kiralandý olarak yaz.
            cbAraclar.Items[cbAraclar.SelectedIndex] = $"{secilenArac.Renk} {secilenArac.Marka} {secilenArac.Tip} ({secilenArac.GunlukUcret}) - Kiralandý";
            secilenArac.MusaitlikDurumu = false;
        }

        private void Temizle()
        {
            cbAraclar.SelectedItem = null;
            txtGunSayisi.Text = string.Empty;
            lblKiralikAracUcreti.Text = string.Empty;
        }
    }
}
