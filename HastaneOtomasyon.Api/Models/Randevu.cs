namespace HastaneOtomasyon.Api.Models
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string? HastaNotu { get; set; }
        public string Durum { get; set; }
        public DateTime OlusurulmaTarihi { get; set; }

    }
}
