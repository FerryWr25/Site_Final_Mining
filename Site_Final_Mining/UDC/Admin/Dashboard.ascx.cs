using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace Site_Final_Mining.UDC.Admin
{
    public partial class Dashboard : System.Web.UI.UserControl
    {
        private connectionClass con;
        int countDetik = 0, countLiputan6 = 0, countTribun = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count(*) as get FROM public.\"userFix\" where level='2';");
            jml_userActive.Text = pengguna.Rows[0]["get"].ToString();
            totalTribun.Text = getcountTribun().ToString();
            TotalDetik.Text = getcounDetik().ToString();
            TotalLiputan6.Text = getcountLiputan6().ToString();
        }
        public DataTable displayJson()
        {
            StreamReader fer = new StreamReader(Server.MapPath("~/dokumenBerita/konten.json"));
            string json = fer.ReadToEnd();
            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }
        public int getcountTribun()
        {
            string search = "site_name = 'Tribunnews.com' ";
            DataRow[] fer = displayJson().Select(search);
            countTribun = fer.Count();
            return countTribun;
        }
        public int getcounDetik()
        {
            string search = "site_name = 'Detik.com' ";
            DataRow[] fer = displayJson().Select(search);
            countTribun = fer.Count();
            return countTribun;
        }
        public int getcountLiputan6()
        {
            string search = "site_name = 'Liputan6.com' ";
            DataRow[] fer = displayJson().Select(search);
            countTribun = fer.Count();
            return countTribun;
        }
        protected void btn_MoreinfoTribun(object sender, EventArgs e)
        {
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }
        protected void tribunnews_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.tribunnews_Click(sender, e);
        }
        protected void detik_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.detik_Click(sender, e);
        }
        protected void liputan6_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.liputan6_Click(sender, e);
        }
        protected void anggotaActive_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.manageUser_Click(sender, e);
        }

    }
}