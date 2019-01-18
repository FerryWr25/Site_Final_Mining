using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining.UDC.Global.Filter_Dokumen
{
    public partial class Detik : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            //tabelBerita.DataSource = displayJson();
            //tabelBerita.DataBind();
            //string[] idSearch = { "'ae0c4315-2bb9-4603-8fd6-566674e9fccc'", "'68d357dc-fd60-4277-9286-d89ed7b3c7de'" };
            //string search = "id in (" + string.Join(", ", idSearch) + ")";
            string search = "site_name = 'Detik.com' ";
            DataRow[] fer = displayJson().Select(search);
            tabelBerita.DataSource = fer.CopyToDataTable();
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
        protected void readmore_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.readMoreDetik_Click(btn.CommandArgument);
        }
    }
}