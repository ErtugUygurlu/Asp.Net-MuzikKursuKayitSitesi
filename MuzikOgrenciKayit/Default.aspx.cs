using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuzikOgrenciKayit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adSoyadTxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCILERTableAdapter DT= new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
            DT.OgrenciEkle(adSoyadTxt.Text,telefonTxt.Text,mailAdresiTxt.Text,DropDownList1.SelectedItem.ToString(),DropDownList2.SelectedItem.ToString());

        }
    }
}