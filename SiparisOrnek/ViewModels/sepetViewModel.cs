using SiparisOrnek.Models;

namespace North_DbFirst.ViewModels
{
    public class SepetViewModel
    {
        public Product Urun { get; set; }
        public short Adet { get; set; } = 0;
        public decimal AraToplam => Urun.UnitPrice.GetValueOrDefault() * Adet;
    }
}
