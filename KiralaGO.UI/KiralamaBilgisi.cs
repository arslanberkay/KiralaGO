using KiralaGO.UI.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace KiralaGO.UI
{
    public class KiralamaBilgisi
    {
        public string AracMarka { get; set; }
        public Renk Renk { get; set; }
        public int GunSayisi { get; set; }
        public decimal ToplamUcret { get; set; }

        public override string ToString()
        {
            return $"{Renk} {AracMarka} {GunSayisi} gün kiralandı. Ödenen toplam ücret : {ToplamUcret.ToString("C", new CultureInfo("tr-TR"))}";
        }
    }
}
