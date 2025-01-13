using System;

namespace kutuphane.models
{
    public class OduncModel
    {
        public int KullaniciID { get; set; }
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }
        public decimal GecikmeCezasi { get; set; }
    }

}