using Kutuphane.Core.Abstraction;
using Kutuphane.Core.Entites;
using Kutuphane.Core.Enum;

namespace Kutuphane.BLL.Colleque
{
    public class UyeFonksiyon : IUyeFonksiyon
    {
        Uye _uye;

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                _uye.OduncAldigiKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (_uye.OduncAldigiKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.OduncAlabilir;
                _uye.OduncAldigiKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı zaten sizde değil.");
            }
        }
    }
}
