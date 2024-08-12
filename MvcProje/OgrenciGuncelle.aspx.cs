using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using System.Data;
using BusinessLogicLayer;

namespace MvcProje
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TextId1.Text = x.ToString();
            TextId1.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrencics.BLLDetay(x);
                TextAd.Text = OgrList[0].Ad.ToString();
                TextSoyad.Text = OgrList[0].Soyad.ToString();
                TextNumara.Text = OgrList[0].Numara.ToString();
                TextFoto.Text = OgrList[0].Fotograf.ToString();
                TextSifre.Text = OgrList[0].Sifre.ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextAd.Text;
            ent.Soyad = TextSoyad.Text;
            ent.Numara = TextNumara.Text;
            ent.Sifre = TextSifre.Text;
            ent.Fotograf = TextFoto.Text;
            ent.Id = Convert.ToInt32(TextId1.Text);
            BLLOgrencics.BLLGuncelle(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}