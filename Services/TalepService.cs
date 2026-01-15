using EfeKutuphane.DAL;
using System.Data;
using System;

namespace EfeKutuphane.Services
{
    public class TalepService
    {
        TalepDAL _talepDal = new TalepDAL();
        public DataTable Listele() => _talepDal.TalepleriGetir();
        public void YeniTalep(int uId, int kId)
        {
            if (!_talepDal.TalepOlustur(uId, kId))
                throw new Exception("Talep oluşturulamadı!");
        }
        public void Onayla(int tId, int uId, int kId)
        {
            if (!_talepDal.TalepOnayla(tId, uId, kId))
                throw new Exception("Talep onaylanırken bir hata oluştu!");
        }
    }
}