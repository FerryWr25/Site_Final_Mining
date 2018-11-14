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
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT * FROM public.user_register order by \"tanggalDaftar\" asc ;");
            for (int i = 0; i < pengguna.Rows.Count; i++)
            {
                pengguna.Rows[i]["pathPhoto"] = "~/admin-lte/img/" + pengguna.Rows[i]["pathPhoto"].ToString();
                this.tabelPendaftar.DataSource = pengguna;
                this.tabelPendaftar.DataBind();
            }
            
        }
        protected void nextView(object sender , GridViewPageEventArgs fer)
        {
            this.tabelPendaftar.PageIndex = fer.NewPageIndex;
            this.tabelPendaftar.DataBind();
        }

    }
}