using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Class;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.UDC.Global.Filter_Dokumen
{
    public partial class Tribunnews : System.Web.UI.UserControl
    {
        private SetLog set;
        string email;
        string queryTest;
        TALA tala = new TALA();
        public bool status_search = false;
        DataTable sessionDoc, konten;
        DataRow[] hasilDoc, doc_Semua;
        string[] result_sumbuXX;
        VectorSpaceModel vsm = new VectorSpaceModel();
        TimeCount tm = new TimeCount();

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            //tabelBerita.DataSource = displayJson();
            //tabelBerita.DataBind();
            queryTest = Session["query"].ToString();
            string[] dataGrafik = Session["dataGrafik"] as string[];
            string[] data_drop = Session["filterDate"] as string[];
            string status_filter = Session["status_filter"].ToString();
            email = Session["Admin"].ToString();
            if (queryTest.Equals(""))
            {
                showAll_Data_First();
                setButton_Header(3);
            }
            else if (!queryTest.Equals(""))
            {
                status_search = true;
                judul.Attributes["class"] = "col-md-3";
                if (this.status_search == true)
                {
                    Drop_Date.DataSource = Session["filterDate"];
                    Drop_Date.DataBind();
                    string[] id = Session["idDoc"] as string[];

                    if (id != null && dataGrafik != null)
                    {
                        setTable(id);
                        setDropDown_Tanggal(data_drop);
                        setGrafik(dataGrafik);
                        setButton_Header(1);
                        grafik.Visible = true;
                        loadChartSearch(Session["dataGrafik"] as string[]);
                        DataTable datafilter = Session["filterDokumen"] as DataTable;
                        if (datafilter != null)
                        {
                            settable_Filter(datafilter);
                        }
                        else
                        {
                            setTable(id);
                        }
                    }
                }
            }
        }
        public void setButton_Header(int status)
        {
            if (status == 1)//setelah pencarian
            {
                penjelasan.Text = "Dokumen Hasil Pencarian '" + string.Join(" ", Session["query"] as string[]).ToString() + "'";
                judul.Attributes["class"] = "col-md-5";
                groupFilter_date.Attributes["class"] = "col-md-4";
                cari_Lagi.Attributes["class"] = "col-md-3";
                groupFilter_date.Visible = true;
                cari_Lagi.Visible = true;
                groupBtn_showAll.Visible = false;
                query_search.Visible = false;

            }
            else if (status == 2)//setelah filter klik
            {
                penjelasan.Text = "Hasil Dokumen Filter Dokumen tanggal " + Drop_Date.SelectedItem.Value;
                judul.Attributes["class"] = "col-md-3";
                groupBtn_showAll.Attributes["class"] = "col-md-3";
                cari_Lagi.Attributes["class"] = "col-md-2";
                groupFilter_date.Attributes["class"] = "col-md-4";
                groupFilter_date.Visible = true;
                cari_Lagi.Visible = true;
                groupBtn_showAll.Visible = true;
                query_search.Visible = false;

            }
            else //sebelum pencarian
            {
                penjelasan.Text = "Semua Dokumen Berita";
                judul.Attributes["class"] = "col-md-8";
                groupFilter_date.Visible = false;
                cari_Lagi.Visible = false;
                groupBtn_showAll.Visible = false;
                query_search.Visible = true;
                query_search.Attributes["class"] = "col-md-4";
            }
        }

        public void showAll_Data_First()
        {
            string search = "site_name = 'Tribunnews.com' ";
            doc_Semua = displayJson().Select(search);
            Session["showAll_doc"] = doc_Semua.CopyToDataTable() as DataTable;
            konten = Session["showAll_doc"] as DataTable;
            tabelBerita.DataSource = Session["showAll_doc"] as DataTable;
            tabelBerita.DataBind();
            groupBtn_showAll.Visible = false;
            groupFilter_date.Visible = false;
            grafik.Visible = false;
            judul.Attributes["class"] = "col-md-8";
        }

        protected void nextView(object sender, GridViewPageEventArgs fer)
        {

            DataTable data = Session["filterDokumen"] as DataTable;
            sessionDoc = Session["showAll_doc"] as DataTable;
            if (Session["status_filter"].ToString().Equals(""))
            {
                tabelBerita.DataSource = sessionDoc;
                this.tabelBerita.PageIndex = fer.NewPageIndex;
            }
            else
            {
                setButton_Header(2);
                tabelBerita.DataSource = data;
                this.tabelBerita.PageIndex = fer.NewPageIndex;
            }
            tabelBerita.DataBind();
        }

        public DataTable displayJson()
        {
            StreamReader fer = new StreamReader(Server.MapPath("~/dokumenBerita/konten.json"));
            string json = fer.ReadToEnd();
            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }

        protected void pencarian_lain_click(object sender, EventArgs e)
        {
            tabelBerita.PageIndex = 0;
            Session["query"] = "";
            showAll_Data_First();
            setButton_Header(3);
            Session.Remove("showAll_doc");
            Session.Remove("filterDate");
        }

        protected void show_all_klik(object sender, EventArgs e)
        {
            Session["status_filter"] = "";
            Session["filterDokumen"] = null;
            tabelBerita.PageIndex = 0;
            string[] id = Session["idDoc"] as string[];
            setTable(id);
            query.Text = "";
            grafik.Visible = true;
        }
        protected void filterByTime_klik(object sender, EventArgs e)
        {
            tabelBerita.DataSource = null;
            tabelBerita.PageIndex = 0;
            setButton_Header(2);
            Session["status_filter"] = "on";
            run_filterDate(Drop_Date.SelectedItem.Value);
            groupFilter_date.Visible = true;
            grafik.Visible = true;
            Array SessionGrrafik = Session["dataGrafik"] as Array;
            string[] hasilGrafik = SessionGrrafik.OfType<object>().Select(o => o.ToString()).ToArray();
            Session["dataGrafik"] = hasilGrafik;
            loadChartSearch(hasilGrafik);
        }
        private void run_filterDate(string date)
        {
            string search = "date like " + "'%" + date + "%'";
            DataTable sessionDoc = Session["showAll_doc"] as DataTable;
            DataRow[] fer = sessionDoc.Select(search);
            Session["filterDokumen"] = fer.CopyToDataTable() as DataTable;
            settable_Filter(Session["filterDokumen"] as DataTable);
        }

        public void settable_Filter(DataTable data)
        {
            tabelBerita.DataSource = null;
            tabelBerita.DataSource = data;
            tabelBerita.DataBind();
        }

        private void runSearch(string[] queryNya)
        {

            Session["showAll_doc"] = null;
            status_search = true;
            tabelBerita.DataSource = null;
            doc_Semua = null;
            vsm.run_onSumber(1, queryNya);
            string[] id = vsm.getDoc();
            Session["idDoc"] = id;
            if (vsm.getStatus_Search() == false)
            {
                tabelBerita.DataSource = null;
                tabelBerita.EmptyDataText = "Tidak ada berita yang mengandung kata pada setiap query pada situs Tribunnews.com";
                tabelBerita.DataBind();
                Session["idDoc"] = null;
                Session["dataGrafik"] = "";
                groupBtn_showAll.Visible = false;
                groupFilter_date.Visible = false;
                grafik.Visible = false;
                judul.Attributes["class"] = "col-md-8";
            }
            else
            {
                if (id.Length < 1)
                {
                    tabelBerita.DataSource = null;
                    tabelBerita.EmptyDataText = "Tidak Ditemukan Dokumen yang Mempunyai Kemiripan Cukup dengan Query pada situs Tribunnews.com";
                    tabelBerita.DataBind();
                    Session["idDoc"] = null;
                    Session["dataGrafik"] = "";
                    groupBtn_showAll.Visible = false;
                    groupFilter_date.Visible = false;
                    grafik.Visible = false;
                    judul.Attributes["class"] = "col-md-8";
                    setButton_Header(3);
                }
                else
                {
                    setTable(id);
                    Session["showAll_doc"] = konten as DataTable;
                    string[] hasilDate = vsm.getDatePure("Tribunnews.com");
                    Session["filterDate"] = hasilDate as string[];
                    if (Session["dataGrafik"].Equals(""))
                    {
                        Session["dataGrafik"] = tala.getFrekunsiKata_onArray(vsm.getdateDoc_akhir_Tribun()) as Array;
                        string[] dataGrafik = Session["dataGrafik"] as string[];
                        setGrafik(dataGrafik);
                    }
                    else
                    {
                        Session["dataGrafik"] = "";
                        Session["dataGrafik"] = tala.getFrekunsiKata_onArray(vsm.getdateDoc_akhir_Tribun()) as Array;
                        string[] dataGrafik = Session["dataGrafik"] as string[];
                        setGrafik(dataGrafik);
                    }
                    setDropDown_Tanggal(hasilDate);
                    setButton_Header(1);
                    grafik.Visible = true;
                    status_search = true;

                }
            }
        }
        public void setDropDown_Tanggal(string[] data)
        {
            data = Session["filterDate"] as string[];
            Drop_Date.DataSource = data;
            Drop_Date.DataBind();
            groupFilter_date.Visible = true;
        }
        private void setTable(string[] id)
        {
            string search = "id in (" + string.Join(", ", id) + ") and site_name = 'Tribunnews.com'";
            doc_Semua = displayJson().Select(search);
            konten = doc_Semua.CopyToDataTable() as DataTable;
            tabelBerita.DataSource = konten;
            tabelBerita.DataBind();
        }
        private void setGrafik(string[] data)
        {
            this.loadChartSearch(data);
        }

        protected void submitQuery_click(object sender, EventArgs e)
        {
            //proses untuk menjalankan TALA dulu, biar dikembalikan ke kata aslinya
            tabelBerita.PageIndex = 0;
            string[] data_query = tala.runStemming_Tala_on_Array(query.Text);
            Session["query"] = data_query as string[];
            runSearch(Session["query"] as string[]);
            status_search = true;
        }

        protected void readmore_click(object sender, EventArgs e)
        {
            LinkButton btn = ((LinkButton)sender);
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.readMoreTribun_Click(btn.CommandArgument);
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
            result_sumbuXX = new string[data.Length];
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
            string str1 = sumbuXX[0].Remove(sumbuXX[0].IndexOf("'"), 1);
            string end_str1 = str1.Remove(str1.LastIndexOf("'"), 1);
            string str2 = sumbuXX[sumbuXX.Length - 1].Remove(sumbuXX[sumbuXX.Length - 1].IndexOf("'"), 1);
            string end_str2 = str2.Remove(str2.LastIndexOf("'"), 1);
            string durasi = tm.runTime(end_str1, end_str2);
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
                "label: '" + durasi + "' ," +
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