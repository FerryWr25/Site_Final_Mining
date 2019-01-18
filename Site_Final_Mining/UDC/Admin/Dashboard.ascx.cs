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
            loadChartBeranda();
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
        private void loadChartBeranda()
        {
            int[,] data = new int[3, 24];
            // inisialisasi nilai awal
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    data[i, j] = 0;
                }
            }
            string[] sumbuX = { "'January'", "'Februari'", "'Maret'", "'April'", "'Mei'", "'Juni'", "'Juli'", "'Agustus'", "'September'", "'Oktober'", "'November'", "'Desember'" };
            // load javascript untuk grafik
            var MainJS = "<script src=\"chart/js/Chart.min.js\"></script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(),
                    MainJS, false);
            // load data untuk grafik
            var DataJS =
                 "<script>" +
        "let myChart = document.getElementById('myChart').getContext('2d');" +
            "Chart.defaults.global.defaultFontSize = 12;" +
            "let ChartPopulation = new Chart(myChart, {" +
            "type: 'line'," +
            "data:" +
            "{" +
            "labels: [" + string.Join(", " , sumbuX) + "]," +
                "datasets: [{" +
                "label: 'Document representation'," +
                   " data: [" +
                        "0,2,2,1,3,2,2,1,3,2,4,5" +
                    "]," +
                    "backgroundColor: [" +
                        "'rgba(51,51,255,0.5)'" +
                    "]," +
                    "borderWidth: 2," +
                    "borderColor: '#0033cc'," +
                    "hoverBorderWidth: 3," +
                    "hoverBorderColor: 'red'" +
                "}]" +
            "}," +
            "options:" +
            "{" +
            "title:" +
                "{" +
                "display: true," +
                    "text: 'Grafik Durasi Kejadian Pencarian'," +
                    "fontSize: 18" +
                "}," +
            "}" +
        "});" +
    "</script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(),
                    DataJS, false);
        }


    }
}