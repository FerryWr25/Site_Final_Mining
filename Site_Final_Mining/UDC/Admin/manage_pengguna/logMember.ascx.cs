using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.UDC.Admin.manage_pengguna
{
    public partial class logMember : System.Web.UI.UserControl
    {
        private connectionClass con;
        string email;
        public void Page_Load(object sender, EventArgs e, string email)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            this.email = email;
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT ur.\"pathPhoto\", lg.judul, ur.nama, lg.email , lg.id_berita, lg.\"timeAccess\" " +
                "FROM public.\"logActivity_Member\" lg join user_register ur on(lg.email=ur.email) where lg.email='" + this.email + "'" +
                " order by \"timeAccess\" desc limit 10");
            for (int i = 0; i < pengguna.Rows.Count; i++)
            {
                pengguna.Rows[i]["pathPhoto"] = "~/admin-lte/img/" + pengguna.Rows[i]["pathPhoto"].ToString();
            }
            this.tabelLog.DataSource = pengguna;
            this.tabelLog.DataBind();
            memberLog_Name.Text = this.email;
        }
        
        protected void nextView(object sender, GridViewPageEventArgs fer)
        {
            this.tabelLog.PageIndex = fer.NewPageIndex;
            this.tabelLog.DataBind();
        }
    }
}