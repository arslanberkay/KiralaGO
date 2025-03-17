using KiralaGO.UI.Data;
using KiralaGO.UI.Enum;
using KiralaGO.UI.Interface;

namespace KiralaGO.UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        List<KiralamaBilgisi> kiralananAraclar = new List<KiralamaBilgisi>();
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
         new Araba { Marka = "Peugeot", Model = 2024, Renk = Renk.Kýrmýzý, GunlukUcret = 1700m, Tip = AracTipi.Kamyonet }
            };

        private void AracOlustur()
        {
            foreach (var arac in araclar)
            {
                cbAraclar.Items.Add(arac.AracBilgisiGoster());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AracOlustur();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (cbAraclar.SelectedIndex == -1 || !int.TryParse(txtGunSayisi.Text, out int gunSayisi) || gunSayisi < 0)
            {
                MessageBox.Show("Lütfen geçerli bir araç seçiniz veya bir araç süresi giriniz.");
                return;
            }

            IArac secilenArac = araclar[cbAraclar.SelectedIndex];

            if (!secilenArac.MusaitlikDurumu)
            {
                MessageBox.Show("Bu araç þuanda kirada");
            }
            decimal toplamUcret = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi >= 5)
            {
                toplamUcret *= 0.9m;
            }

            KiralamaBilgisi kiralamaBilgisi = new KiralamaBilgisi
            {
                AracModel = secilenArac.Model.ToString(),
                GunSayisi = gunSayisi,
                ToplamUcret = toplamUcret,

            };

            kiralananAraclar.Add(kiralamaBilgisi);
            lstKiralikAracGecmisi.Items.Add(kiralamaBilgisi);

            secilenArac.MusaitlikDurumu = false;

            cbAraclar.Items[cbAraclar.SelectedIndex] = $"{secilenArac.Model} - {secilenArac.Tip} - {secilenArac.GunlukUcret} - Kiralandý";

            lblKiralikAracUcreti.Text = $"Toplam ücret : {toplamUcret}";


        }
    }
}
