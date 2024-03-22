
namespace Kutuphane.Core.Entites
{
    public class Kütüphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public Kütüphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        
    }
}
