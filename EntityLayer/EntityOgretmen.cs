using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPEntityLayerroje
{
    public class EntityOgretmen
    {

        private int id;
        private string adSoyad;
        private int brans;

        public int Id { get => id; set => id = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public int Brans { get => brans; set => brans = value; }

    }
}