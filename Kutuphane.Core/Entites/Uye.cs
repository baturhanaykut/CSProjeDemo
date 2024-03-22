using Kutuphane.Core.Abstraction;
using Kutuphane.Core.Enum;

namespace Kutuphane.Core.Entites
{
    public class Uye : IUye
    {
        public int UyeNumarasi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Kitap> OduncAldigiKitaplar { get; set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncAldigiKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncAldigiKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAldigiKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.OduncAlabilir;
                OduncAldigiKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı zaten sizde değil.");
            }
        }
    }
}
