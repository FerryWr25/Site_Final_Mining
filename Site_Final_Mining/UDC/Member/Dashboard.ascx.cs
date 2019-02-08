using Newtonsoft.Json;
using Site_Final_Mining.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Class;

namespace Site_Final_Mining.UDC.Member
{
    public partial class Dashboard : System.Web.UI.UserControl
    {
        private connectionClass con;
        int countDetik = 0, countLiputan6 = 0, countTribun = 0;
        string get_nTribun, get_nDetik, get_nLiputan6, get_nUser;
        Grafik_Board grafik = new Grafik_Board();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count(*) as get FROM public.\"userFix\" where level='2';");
            jml_userActive.Text = pengguna.Rows[0]["get"].ToString();
            get_nUser = pengguna.Rows[0]["get"].ToString();
            totalTribun.Text = getcountTribun().ToString();
            get_nTribun = getcountTribun().ToString();
            get_nDetik = getcounDetik().ToString();
            get_nLiputan6 = getcountLiputan6().ToString();
            TotalDetik.Text = getcounDetik().ToString();
            TotalLiputan6.Text = getcountLiputan6().ToString();
            loadChartBeranda();
            setBoardButton();
            setBar_dashBoard();
        }
        public int getcountAll()
        {
            DataRow[] fer = displayJson().Select();
            countTribun = fer.Count();
            return countTribun;
        }
        public void setBar_dashBoard()
        {
            double n_Doc = Convert.ToDouble(getcountAll());
            double nTribun = Convert.ToDouble(get_nTribun);
            double nDetik = Convert.ToDouble(get_nDetik);
            double nLiputan6 = Convert.ToDouble(get_nLiputan6);
            double resultBAR_tribun, resultBAR_Detik, resultBAR_Lipuatan6, result_User;
            resultBAR_tribun = Math.Round(((nTribun / n_Doc) * 100), 2);
            resultBAR_Detik = Math.Round(((nDetik / n_Doc) * 100), 2);
            resultBAR_Lipuatan6 = Math.Round(((nLiputan6 / n_Doc) * 100), 2);
            result_User = Math.Round(((Convert.ToDouble(get_nUser) / 50) * 100), 2);
            labelTibunnews1.Text = nTribun.ToString();
            labelTibunnews2.Text = n_Doc.ToString();
            labelDetik1.Text = nDetik.ToString();
            labelDetik2.Text = n_Doc.ToString();
            labeliputan1.Text = nLiputan6.ToString();
            labeliputan2.Text = n_Doc.ToString();
            labelUser1.Text = get_nUser.ToString();
            labelUser2.Text = "50";
            labelPersenTribun.Text = resultBAR_tribun.ToString();
            labelPersenDetik.Text = resultBAR_Detik.ToString();
            labelPersenLiputan6.Text = resultBAR_Lipuatan6.ToString();
            labelPersenUser.Text = result_User.ToString();
            bar_Tribun.Attributes["style"] = "width: " + resultBAR_tribun.ToString().Replace(",", ".") + "%";
            bar_Detik.Attributes["style"] = "width: " + resultBAR_Detik.ToString().Replace(",", ".") + "%";
            bar_Lipuan6.Attributes["style"] = "width: " + resultBAR_Lipuatan6.ToString().Replace(",", ".") + "%";
            bar_User.Attributes["style"] = "width: " + result_User.ToString().Replace(",", ".") + "%";
        }
        public void get_nDoc()
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count (*) as get  FROM public.\"Dokumen\";");
            totalDoc.Text = pengguna.Rows[0]["get"].ToString();
        }
        public void get_n_DimensiDoc()
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count(*) as dimensi FROM public.\"bobotTerm\";");
            total_nDoc.Text = pengguna.Rows[0]["dimensi"].ToString();
        }
        public void get_n_DimensiTerm()
        {
            this.con = new connectionClass();
            DataTable pengguna = this.con.getResult("SELECT count(*) as dimensiTerm  FROM public.\"Term\";");
            total_nTerm.Text = pengguna.Rows[0]["dimensiTerm"].ToString();
        }

        public void setBoardButton()
        {
            get_nDoc();
            get_n_DimensiDoc();
            get_n_DimensiTerm();
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
            countDetik = fer.Count();
            return countDetik;
        }
        public int getcountLiputan6()
        {
            string search = "site_name = 'Liputan6.com' ";
            DataRow[] fer = displayJson().Select(search);
            countLiputan6 = fer.Count();
            return countLiputan6;
        }
        protected void btn_MoreinfoTribun(object sender, EventArgs e)
        {
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }
        protected void tribunnews_Click(object sender, EventArgs e)
        {
            Welcome_Here_Member_ parent = (Welcome_Here_Member_)this.Page;
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
            List<int> fre_Detik = new List<int>();
            List<int> fre_Tribun = new List<int>();
            List<int> fre_Liputan6 = new List<int>();
            int[,] data = new int[3, 24];
            int[] dataDetik = new int[12];
            int[] dataTribun = new int[12];
            int[] dataLiputan = new int[12];
            // inisialisasi nilai awal
            for (int i = 0; i < dataDetik.Length; i++)
            {
                dataDetik[i] = 0;
            }
            for (int i = 0; i < dataTribun.Length; i++)
            {
                dataTribun[i] = 0;
            }
            for (int i = 0; i < dataLiputan.Length; i++)
            {
                dataLiputan[i] = 0;
            }
            grafik.readJson_getDateDETIK();
            grafik.readJson_getDateLIPUTAN();
            grafik.readJson_getDateTRIBUN();
            dataDetik = grafik.getData_Detik();
            dataTribun = grafik.getData_Tribun();
            dataLiputan = grafik.getData_Liputan();
            string[] sumbuX = { "\"January\"", "\"Februari\"", "\"Maret\"", "\"April\"", "\"Mei\"", "\"Juni\"", "\"Juli\"", "\"Agustus\"", "\"September\"",
                "\"Oktober\"", "\"November\"", "\"Desember\"" };
            // load javascript untuk grafik
            var MainJS = "<script src=\"chart/js/Chart.min.js\"></script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(),
                    MainJS, false);
            // load data untuk grafik
            var DataJS =
                  "<script> " +
                 "new Chart(document.getElementById(\"myChart\"), {" +
                 "type: 'bar'," +
                 "data: {" +
                 "labels: [" + string.Join(", ", sumbuX) + "]," +
                 "datasets: [" +
                 "{" +
                 "label: \"Tribunnews.com\"," +
                 "backgroundColor: \"rgba(0,192,239,1.0)\"," +
                 "data: [" + dataTribun[0] + ", " + dataTribun[1] + ", " + dataTribun[2] + ", " + dataTribun[3] + ", " + dataTribun[4] + ", " + dataTribun[5] +
                ", " + dataTribun[6] + ", " + dataTribun[7] + ", " + dataTribun[8] + ", " + dataTribun[9] + ", " + dataTribun[10] + ", " + dataTribun[11] + "]" +
                 "}, {" +
                 "label:\"Detik.com\"," +
                 "backgroundColor: \"rgba(0,166,90,1.0)\"," +
                 "data: [" + dataDetik[0] + ", " + dataDetik[1] + ", " + dataDetik[2] + ", " + dataDetik[3] + ", " + dataDetik[4] + ", " + dataDetik[5] +
                ", " + dataDetik[6] + ", " + dataDetik[7] + ", " + dataDetik[8] + ", " + dataDetik[9] + ", " + dataDetik[10] + ", " + dataDetik[11] + "]" +
                 "} ,{ " +
                  "label:\"Liputan6.com\"," +
                 "backgroundColor: \"rgba(243,156,18,1.0)\"," +
                 "data: [" + dataLiputan[0] + ", " + dataLiputan[1] + ", " + dataLiputan[2] + ", " + dataLiputan[3] + ", " + dataLiputan[4] + ", " + dataLiputan[5] +
                ", " + dataLiputan[6] + ", " + dataLiputan[7] + ", " + dataLiputan[8] + ", " + dataLiputan[9] + ", " + dataLiputan[10] + ", " + dataLiputan[11] + "]" +
                 "}" +
                 "]" +
                 "}," +
                 "options: {" +
                 "title: {" +
                 "display: true," +
                 "text: 'Grafik Representasi Dokumen Berita'" +
                 "}" +
                 "}" +
                 "});" +
                 "</script>";


            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(),
                    DataJS, false);
        }
    }
}