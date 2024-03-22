using Kutuphane.Core.Entites;
using Kutuphane.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Core.Abstraction
{
    public interface IKütüphaneFonksiyon
    {
        void KataloguGoruntule();
        void UyeleriGoruntule();
        void KitapDurumunuGuncelle(Kitap kitap, Durum durum);

    }
}
