using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;
        
namespace BusinessLogicLayer
{
    public class BLLOgrencics
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null)
            {
                return DALOgreci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgreci.OgrenciListesi();
        }
        public static bool OgrenciSil(int p)
        {
            if(p != null)
            {
                return DALOgreci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLDetay(int p)
        {
            return DALOgreci.OgrenciDetay(p);
        }
        public static bool BLLGuncelle(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null && p.Id > 0)
            {
                return DALOgreci.OgrenciGuncele(p);
            }
            return false;
        }
    }
}
