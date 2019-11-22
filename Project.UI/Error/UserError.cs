using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UI.Error
{
    public class UserError
    {
        public static string ErrorMessage(int code)
        {
            if (code==Convert.ToInt32(ErrorCode.BosAlan))
            {
                return "Lütfen Alanları kontrol ediniz";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitBulunamadı))
            {
                return "Aradığınız kayıt bulunamadı";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitEklendi))
            {
                return "Kayıt Eklendi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitEklenmedi))
            {
                return "Kayıt Eklenmedi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitGuncellendi))
            {
                return "Kayıt Güncellendi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitGüncellenmedi))
            {
                return "Kayıt Güncellenemedi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitSilindi))
            {
                return "Kayıt Silindi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitSilinmedi))
            {
                return "Kayıt Silinemedi";
            }
            else if (code == Convert.ToInt32(ErrorCode.KayitOncedenEklenmis))
            {
                return "Kayıt Önceden eklenmiştir";
            }
            else
            {
                return "Kayıt Eklendi";
            }
        }

        public enum ErrorCode
        {
            BosAlan=1,
            KayitBulunamadı=2,
            KayitEklendi=3,
            KayitEklenmedi=4,
            KayitSilindi=5,
            KayitSilinmedi=6,
            KayitGuncellendi=7,
            KayitGüncellenmedi=8,
            KayitOncedenEklenmis=9
        }
    }
}
