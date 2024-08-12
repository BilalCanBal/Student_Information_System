﻿using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int BLLTalepEkle(EntityBasvuruForm p)
        {
            if(p.Basogrid != null && p.Basdersid != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
