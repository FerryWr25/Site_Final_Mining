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
using Site_Final_Mining.Class;

namespace Site_Final_Mining.UDC.Member.Filter_dokumen
{

    public partial class AllBerita : System.Web.UI.UserControl
    {
        private SetLog set;
        string email;
        VectorSpaceModel vsm = new VectorSpaceModel();
        TALA tala = new TALA();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.set = new SetLog();
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            //tabelBerita.DataSource = displayJson();
            //tabelBerita.DataBind();
            if (query.Text.Equals(""))
            {
                DataRow[] fer = displayJson().Select();
                tabelBerita.DataSource = fer.CopyToDataTable();
                tabelBerita.DataBind();
            }
            else
            {
                submitQuery_click(sender, e);
            }
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
            submitQuery_click(sender, fer);
            this.tabelBerita.PageIndex = fer.NewPageIndex;
            this.tabelBerita.DataBind();
        }

        protected void submitQuery_click(object sender, EventArgs e)
        {
            vsm.run(query.Text);
            string[] id = vsm.getDoc();
            if (vsm.getStatus_Search() == false)
            {
                tabelBerita.DataSource = null;
                tabelBerita.DataBind();
            }
            else
            {
                string search = "id in (" + string.Join(", ", id) + ")";
                DataRow[] fer = displayJson().Select(search);
                tabelBerita.DataSource = fer.CopyToDataTable();
                tabelBerita.DataBind();
                this.loadChartSearch(tala.getFrekunsiKata_onArray(vsm.getdateDoc_akhir()));
            }
        }

        protected void readmore_click(object sender, EventArgs e)
        {
            submitQuery_click(sender, e);
            LinkButton btn = (LinkButton)sender;
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.readMore_Click(btn.CommandArgument);

        }
        private string[] getLabel_SumbuX(string[] data)
        {
            string[] result;
            string bulan;
            List<string> ListResult = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                bulan = data[i].Substring(3, 4);
                if (bulan.Equals("/01/"))
                {
                    bulan = "Jan";
                }
                else if (bulan.Equals("/02/"))
                {
                    bulan = "Feb";
                }
                else if (bulan.Equals("/03/"))
                {
                    bulan = "Mar";
                }
                else if (bulan.Equals("/04/"))
                {
                    bulan = "Apr";
                }
                else if (bulan.Equals("/05/"))
                {
                    bulan = "Mei";
                }
                else if (bulan.Equals("/06/"))
                {
                    bulan = "Jun";
                }
                else if (bulan.Equals("/07/"))
                {
                    bulan = "Jul";
                }
                else if (bulan.Equals("/08/"))
                {
                    bulan = "Agst";
                }
                else if (bulan.Equals("/09/"))
                {
                    bulan = "Sep";
                }
                else if (bulan.Equals("/10/"))
                {
                    bulan = "Okt";
                }
                else if (bulan.Equals("/11/"))
                {
                    bulan = "Nov";
                }
                else
                {
                    bulan = "Des";
                }
                ListResult.Add(data[i].Replace(data[i].Substring(3, 4), bulan));
            }
            result = ListResult.ToArray();
            return result;
        }
        private void loadChartSearch(string[] data)
        {
            int[] frekuensi = new int[data.Length];
            int i, j, ctr;
            List<string> sumbuX = new List<string>();
            List<int> sumbuY = new List<int>();
            string[] sumbuXX = new string[data.Length];
            string[] result_sumbuXX = new string[data.Length];
            int[] sumbuYY = new int[data.Length];
            //inisialisasi awal chart
            for (int fer = 0; fer < result_sumbuXX.Length; fer++)
            {
                result_sumbuXX[fer] = "";
                sumbuYY[fer] = 0;
            }
            //baca data dan tampilkan ke chart
            for (i = 0; i < data.Length; i++)
            {
                frekuensi[i] = -1;
            }
            for (i = 0; i < data.Length; i++)
            {
                ctr = 1;
                for (j = i + 1; j < data.Length; j++)
                {
                    if (data[i].Equals(data[j]))
                    {
                        ctr++;
                        frekuensi[j] = 0;
                    }
                }
                if (frekuensi[i] != 0)
                {
                    frekuensi[i] = ctr;
                }
            }
            for (i = 0; i < data.Length; i++)

            {
                if (frekuensi[i] != 0)

                {
                    sumbuX.Add(data[i]);
                    sumbuY.Add(frekuensi[i] % 49);
                }

            }
            sumbuXX = sumbuX.ToArray();
            sumbuYY = sumbuY.ToArray();
            result_sumbuXX = getLabel_SumbuX(sumbuXX);
            // load javascript untuk grafik
            var MainJS = "<script src=\"chart/js/Chart.min.js\"></script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(),
                    MainJS, false);

            // load data untuk grafik
            var DataJS =
                 "<script>" +
        "let myChart = document.getElementById('barChart').getContext('2d');" +
            "Chart.defaults.global.defaultFontSize = 12;" +
            "let ChartPopulation = new Chart(myChart, {" +
            "type: 'line'," +
            "data:" +
            "{" +
            "labels: [" + string.Join(", ", result_sumbuXX) + "]," +
                "datasets: [{" +
                "label: 'Durasi Kejadian " + sumbuXX.Length + " hari' ," +
                   " data: [" +
                        "" + string.Join(", ", sumbuYY) + "" +
                    "]," +
                    "backgroundColor: [" +
                        "'rgba(51,51,255,0.6)'" +
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