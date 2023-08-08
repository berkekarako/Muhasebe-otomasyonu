using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormGiris.Entity;

namespace WinFormGiris.Fonksiyonlar
{
    class Numaralar
    {
        WinFormDbEntities1 db = new WinFormDbEntities1();

        public string CariNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblCaris
                                 orderby s.Id descending
                                 select s).First().CariKod);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;

            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string GirisKod()
        {
            try
            {
                double numara = double.Parse((from s in db.tblStokGirisUsts
                                              orderby s.Id descending
                                              select s).First().GirisKod);
                numara++;
                string num = numara.ToString().PadLeft(8, '0');
                return num;

            }
            catch (Exception)
            {
                return "00000001";
            }
        }
        public string CikisKod()
        {
            try
            {
                double numara = double.Parse((from s in db.tblStokCikisUsts
                                              orderby s.Id descending
                                              select s).First().CikisKod);
                numara++;
                string num = numara.ToString().PadLeft(8, '0');
                return num;

            }
            catch (Exception)
            {
                return "00000001";
            }
        }


    }
}
