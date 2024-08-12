using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace MvcProje
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false) 
            {
            List<EntityDers> EntDers = BLLDers.BllListele();
            DropDownList1.DataSource = EntDers;
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind(); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basdersid = Convert.ToInt32(DropDownList1.SelectedValue);
            ent.Basogrid = Convert.ToInt32(Textbox1.Text);
            BLLDers.BLLTalepEkle(ent);
        }
    }
}