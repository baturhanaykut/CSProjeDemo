using Kutuphane.Core.Entites;

namespace Kutuphane.Core.Abstraction
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNumarasi { get; set; }
        List<Kitap> OduncAldigiKitaplar { get; set; }

       
    }
}
