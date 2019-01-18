using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.UDC.Member.Filter_dokumen
{

    public partial class AllBerita : System.Web.UI.UserControl
    {
        private SetLog set;
        string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.set = new SetLog();
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            //tabelBerita.DataSource = displayJson();
            //tabelBerita.DataBind();
            tabelBerita.DataSource = displayJson();
            tabelBerita.DataBind();
            email = Session["Member"].ToString();
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
            Welcome_Here_Member_ parent = (Welcome_Here_Member_)this.Page;
            parent.readMore_Click(btn.CommandArgument);
            set.InsertLog(email, btn.CommandArgument,btn.CommandName);
        }
    }
}