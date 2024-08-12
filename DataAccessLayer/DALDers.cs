using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();

            SqlCommand komut2 = new SqlCommand("select * from TBL_Ders", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DersAd = dr["DERSAD"].ToString();
                ent.Min = Convert.ToInt32(dr["DERSMINSKONT"].ToString());
                ent.Max = Convert.ToInt32(dr["DERSMAXSKONT"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BASVURUFORM (OGRENCIID,DERSID) values (@p1,@p2)",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",parametre.Basogrid);
            komut.Parameters.AddWithValue("@p2",parametre.Basdersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
    }
}
