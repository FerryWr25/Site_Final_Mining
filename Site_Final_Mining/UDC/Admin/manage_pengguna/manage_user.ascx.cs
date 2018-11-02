using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining.UDC.Admin.manage_pengguna
{
    public partial class manage_user : System.Web.UI.UserControl
    {
        private connectionClass con;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT * FROM public.user_register order by \"tanggalDaftar\" asc ;");
            for (int i = 0; i < pengguna.Rows.Count; i++)
            {
                pengguna.Rows[i]["pathPhoto"] = "~/admin-lte/img/" + pengguna.Rows[i]["pathPhoto"].ToString();
            }
            this.tabelPendaftar.DataSource = pengguna;
            this.tabelPendaftar.DataBind();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.tabelPendaftar.PageIndex = e.NewPageIndex;
            this.tabelPendaftar.DataBind();
        }
    }
}