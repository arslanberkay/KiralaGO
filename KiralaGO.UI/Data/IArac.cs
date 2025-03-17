using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralaGO.UI.Data
{
    public interface IArac
    {
        public int Model { get; set; }
        public string Marka { get; set; }
        public Renk Renk { get; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitlikDurumu { get; set; }
        public AracTipi AracTipi { get; set; }

        public void AracBilgisiGoster();
        
    }
}
