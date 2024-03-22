using Kutuphane.Core.Abstraction;
using Kutuphane.Core.Enum;

namespace Kutuphane.Core.Entites
{
    public abstract class Kitap : IKitap
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }
    }
}
