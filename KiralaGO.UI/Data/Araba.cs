using KiralaGO.UI.Enum;
using KiralaGO.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralaGO.UI.Data
{
    public class Araba : IArac
    {
        public string Marka { get; set; }
        public Renk Renk { get; set; }
        public bool MusaitlikDurumu { get; set; } = true;
        public AracTipi Tip { get; set; }

        private int _model;
        public int Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Model yılı negatif olamaz!");
                }
                _model = value;
            }
        }

        private decimal _gunlukUcret;
        public decimal GunlukUcret
        {
            get
            {
                return _gunlukUcret;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Günlük ücret negatif olamaz!");
                }
                _gunlukUcret = value;
            }
        }

        public string AracBilgisiGoster()
        {
            return $"{Marka} - {Tip} - {GunlukUcret} - Listelendi";
        }

        public override string ToString()
        {
            return $"{Renk} {Marka} {Tip} ({GunlukUcret}TL) - Uygun";
        }

    }
}
