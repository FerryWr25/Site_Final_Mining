using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining.UDC.Admin
{
    public partial class Dashboard : System.Web.UI.UserControl
    {
        private connectionClass con;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count(*) as get FROM public.\"userFix\" where level='2';");
            jml_userActive.Text = pengguna.Rows[0]["get"].ToString();
        }

    }
}