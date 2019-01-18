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
using Site_Final_Mining.Class;

namespace Site_Final_Mining.UDC.Admin.allBerita
{
    public partial class allDokumen_Berita : System.Web.UI.UserControl
    {
        VectorSpaceModel vsm = new VectorSpaceModel();
        TALA tala = new TALA();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            //tabelBerita.DataSource = displayJson();
            //tabelBerita.DataBind();

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
        protected void readmore_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.readMore_Click(btn.CommandArgument);
        }
        protected void submitQuery_click(object sender, EventArgs e)
        {
            vsm.run(query.Text);
            string[] id = vsm.getDoc();
            string search = "id in (" + string.Join(", ", id) + ")";
            DataRow[] fer = displayJson().Select(search);
            tabelBerita.DataSource = fer.CopyToDataTable();
            tabelBerita.DataBind();
            this.loadChartSearch(tala.getFrekunsiKata_onArray(vsm.getdateDoc_akhir()));
        }
        private void loadChartSearch(string[] data)
        {
            int[] frekuensi = new int[data.Length];
            int i, j, ctr;
            List<string> sumbuX = new List<string>();
            List<int> sumbuY = new List<int>();
            string[] sumbuXX = new string[data.Length];
            int[] sumbuYY = new int[sumbuXX.Length];
            //inisialisasi awal chart
            for (int fer = 0; fer < data.Length; fer++)
            {
                sumbuXX[fer] = "";
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
            // inisialisasi nilai awal

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
            "labels: [" + string.Join(", ", sumbuXX) + "]," +
                "datasets: [{" +
                "label: 'Durasi Kejadian " + sumbuXX.Length + " hari' ," +
                   " data: [" +
                        "" + string.Join(", ", sumbuYY) + "" +
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