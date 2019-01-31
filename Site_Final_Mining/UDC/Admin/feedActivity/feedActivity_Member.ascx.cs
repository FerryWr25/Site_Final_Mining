using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining.UDC.Admin.feedActivity
{
    public partial class feedActivity_Member : System.Web.UI.UserControl
    {
        private connectionClass con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable activity = this.con.getResult("SELECT log.email, uf.path_photo, uf.\"namaPengguna\", ur.pekerjaan, ur.\"tanggalDaftar\", id_berita, \"timeAccess\", judul  FROM public.\"logActivity_Member\" log join public.\"userFix\" uf" +
            "on(log.email = uf.email) join user_register ur on(uf.email = ur.email) order by \"timeAccess\" desc limit 30; ");
            for (int i = 0; i < activity.Rows.Count; i++)
            {
                activity.Rows[i]["path_photo"] = "~/admin-lte/img/" + activity.Rows[i]["path_photo"].ToString();
                this.tabelActivity.DataSource = activity;
                this.tabelActivity.DataBind();
            }
        }
    }
}