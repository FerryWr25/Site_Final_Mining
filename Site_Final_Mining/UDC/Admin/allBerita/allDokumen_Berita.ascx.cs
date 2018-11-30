using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining.UDC.Admin.allBerita
{
    public partial class allDokumen_Berita : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            tabelBerita.DataSource = displayJson();
            tabelBerita.DataBind();
        }
        public DataTable displayJson()
        {
            StreamReader fer = new StreamReader(Server.MapPath("~/dokumenBerita/konten.json"));
            string json = fer.ReadToEnd();
            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }
        protected void nextView(object sender, GridViewPageEventArgs fer)
        {
            this.tabelBerita.PageIndex = fer.NewPageIndex;
            this.tabelBerita.DataBind();
        }
        protected void News_Grid_Command(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.loadDetailAnggota(btn.CommandArgument);
        }
    }
}