using KiralaGO.UI.Data;

namespace KiralaGO.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ArabaOlustur()
        {
            List<Araba> arabalar = new List<Araba>
        {
            new Araba {Marka = "Cupra", Model = 2025, GunlukUcret = 2000,AracTipi = AracTipi.Otomobil,Renk = Renk.Titanyum},
            new Araba { Marka = "BMW", Model = 2023, GunlukUcret = 2500, AracTipi = AracTipi.SUV, Renk = Renk.Siyah },
            new Araba { Marka = "Mercedes", Model = 2024, GunlukUcret = 2700, AracTipi = AracTipi.Otomobil, Renk = Renk.Beyaz },
            new Araba { Marka = "Toyota", Model = 2022, GunlukUcret = 1500, AracTipi = AracTipi.Minibüs, Renk = Renk.Gri },
            new Araba { Marka = "Honda", Model = 2021, GunlukUcret = 1300, AracTipi = AracTipi.Otomobil, Renk = Renk.Kýrmýzý },
            new Araba { Marka = "Volvo", Model = 2020, GunlukUcret = 1800, AracTipi = AracTipi.Kamyonet, Renk = Renk.Lacivert },
            new Araba { Marka = "Ford", Model = 2023, GunlukUcret = 1600, AracTipi = AracTipi.Kamyon, Renk = Renk.Mavi }
        };
            foreach (Araba araba in arabalar)
            {
                cbArabalar.Items.Add(araba);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArabaOlustur();
           
        }
    }
}
