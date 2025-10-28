namespace HastaneOtomasyon.Api.Models
{
    public class Recete
    {
        public int ReceteID { get; set; }
        public int RandevuID { get; set; }
        public string Ilaclar { get; set; }
        public DateTime YazilmaTarihi { get; set; }
    }
}
