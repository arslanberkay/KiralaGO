using KiralaGO.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralaGO.UI.Interface
{
    public interface IArac
    {
        int Model { get; set; }
        string Marka { get; set; }
        Renk Renk { get; set; }
        decimal GunlukUcret { get; set; }
        bool MusaitlikDurumu { get; set; }
        AracTipi Tip { get; set; }

        string AracBilgisiGoster();

    }
}
