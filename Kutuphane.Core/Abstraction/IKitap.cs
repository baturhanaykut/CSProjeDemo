using Kutuphane.Core.Enum;

namespace Kutuphane.Core.Abstraction
{
    public interface IKitap
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }
    }
}
