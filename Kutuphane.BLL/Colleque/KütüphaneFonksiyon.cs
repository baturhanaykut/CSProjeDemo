using Kutuphane.Core.Abstraction;
using Kutuphane.Core.Entites;
using Kutuphane.Core.Enum;


namespace Kutuphane.BLL.Colleque
{

    public class KütüphaneFonksiyon : IKütüphaneFonksiyon
    {
        Kütüphane _kütüphane;
        public void KataloguGoruntule()
        {
            Console.WriteLine("Kütüphane Kataloğu:");
            foreach (var kitap in _kütüphane.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik}, Yazar: {kitap.Yazar}, Durum: {kitap.Durum}");
            }
        }

        public void UyeleriGoruntule()
        {
            Console.WriteLine("Üyeler:");
            foreach (var uye in _kütüphane.Uyeler)
            {
                Console.WriteLine($"- {uye.Ad} {uye.Soyad}, Üye Numarası: {uye.UyeNumarasi}");
            }
        }

        public void KitapDurumunuGuncelle(Kitap kitap, Durum durum)
        {
            kitap.Durum = durum;
        }
    }
}
