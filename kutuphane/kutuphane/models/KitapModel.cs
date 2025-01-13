namespace kutuphane.models
{
    public class KitapModel
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Kategori { get; set; }
        public int StokSayisi { get; set; }
    }
}