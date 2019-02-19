using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;
using Site_Final_Mining.UDC.Admin.allBerita;
using Site_Final_Mining.UDC.Member.Filter_dokumen;

namespace Site_Final_Mining
{
    public partial class Welcome_Here_Member_ : System.Web.UI.Page
    {
        private connectionClass con;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Member"] != null)
            {
                if (ViewState["userControl"] == null)
                {
                    ViewState["userControl"] = "~/UDC/Member/Dashboard.ascx";
                    this.loadControl(ViewState["userControl"].ToString(), false);
                }
                else
                {
                    this.loadControl(ViewState["userControl"].ToString(), true);
                }
                sidebarProfile.Attributes["src"] = getPathIMage();
                profileImage_dropdown.Attributes["src"] = getPathIMage();
                profileSideBar.Attributes["src"] = getPathIMage();
                labelNama.Text = getName();
                labelNama2.Text = getName();
                labelNama3.Text = getName();

            }
            else
            {
                Response.Redirect("Site[Please_Login].aspx");
            }

        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(ctrl);
        }
        public string getName()
        {
            string name = null;
            this.con = new connectionClass();
            string query = "select \"namaPengguna\" from public.\"userFix\" where email='" + Session["Member"] + "'";
            DataTable data = this.con.getResult(query);
            name = data.Rows[0]["namaPengguna"].ToString();
            return name;
        }
        public string getPathIMage()
        {
            string path = null;
            this.con = new connectionClass();
            string query = "select path_photo from public.\"userFix\" where email='" + Session["Member"] + "'";
            DataTable data = this.con.getResult(query);
            path = "admin-lte/img/" + data.Rows[0]["path_photo"].ToString();
            return path;
        }

        protected void keluar_Click(object sender, EventArgs e)
        {
            Session.Remove("Member");
            Session.Abandon();
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }

        protected void dashBoard_click(object sender, EventArgs e)
        {
            changeActiveMenu("dashBoard");
            Control dashboard = Page.LoadControl("~/UDC/Member/Dashboard.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(dashboard);
            ViewState["userControl"] = "~/UDC/Member/Dashboard.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            changeActiveMenu("profile");
            Control profile = Page.LoadControl("~/UDC/Member/profile/memberProfile.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(profile);
            ViewState["userControl"] = "~/UDC/Member/profile/memberProfile.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        private void changeActiveMenu(string menu)
        {
            switch (menu)
            {
                case "dashBoard":
                    menu_dashboard.Attributes["class"] = "active";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview";
                    btn_tribunnews.Attributes["class"] = "";
                    btn_detik.Attributes["class"] = "";
                    btn_liputan6.Attributes["class"] = "";
                    break;
                case "allBerita":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "active";
                    menu_kategori_berita.Attributes["class"] = "treeview";
                    btn_tribunnews.Attributes["class"] = "";
                    btn_detik.Attributes["class"] = "";
                    btn_liputan6.Attributes["class"] = "";
                    break;
                case "tribunnews":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview active";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
                case "kategoriBencanaAlam":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
                case "liputan6":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview active";
                    break;
                case "detik":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview active";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
                case "kategoriKecelakaan":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
                case "kategoriLainnya":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
                case "profile":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview menu";
                    btn_tribunnews.Attributes["class"] = "threeview";
                    btn_detik.Attributes["class"] = "threeview";
                    btn_liputan6.Attributes["class"] = "threeview";
                    break;
            }
        }
        public void tribunnews_Click(object sender, EventArgs e)
        {
            changeActiveMenu("tribunnews");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["dataGrafik"] = "";
            Session["filterDate"] = "";
            Session["filterDokumen"] = "";
            Session["status_filter"] = "";
            Control tribunnews = Page.LoadControl("~/UDC/Member/Filter_dokumen/TribunNews.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(tribunnews);
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/TribunNews.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void allBerita_Click(object sender, EventArgs e)
        {
            changeActiveMenu("allBerita");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["dataTribun"] = "";
            Session["dataDetik"] = "";
            Session["dataLiputan6"] = "";
            Session["filterDate"] = "";
            Session["dataGrafik"] = "";
            Control allberita = Page.LoadControl("~/UDC/Member/Filter_dokumen/AllBerita.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(allberita);
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/AllBerita.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }

        public void liputan6_Click(object sender, EventArgs e)
        {
            changeActiveMenu("liputan6");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["filterDate"] = "";
            Session["dataGrafik"] = "";
            Control liputan6 = Page.LoadControl("~/UDC/Member/Filter_dokumen/Liputan6.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(liputan6);
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/Liputan6.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void detik_Click(object sender, EventArgs e)
        {
            changeActiveMenu("detik");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["filterDate"] = "";
            Session["dataGrafik"] = "";
            Control detik = Page.LoadControl("~/UDC/Member/Filter_dokumen/DetikNews.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(detik);
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/DetikNews.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }

        protected void feedActivity_Click(object sender, EventArgs e)
        {
            changeActiveMenu("pengguna");
            Control feed = Page.LoadControl("~/UDC/Admin/feedActivity/feedActivity_Member.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(feed);
            ViewState["userControl"] = "~/UDC/Admin/feedActivity/feedActivity_Member.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void readMore_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/ReadMore_allBerita.ascx";
            Session["urlPage"] = Request.UrlReferrer.ToString();
            this.loadControl(ViewState["userControl"].ToString(), false);
            ReadMore_allBerita dtl = (ReadMore_allBerita)Content_Member.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreDetik_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/ReadMore_detik.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            ReadMore_detik dtl = (ReadMore_detik)Content_Member.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreLiputan6_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/ReadMore_Liputan6.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            ReadMore_Liputan6 dtl = (ReadMore_Liputan6)Content_Member.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreTribun_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Member/Filter_dokumen/ReadMore_TribunNews.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            ReadMore_TribunNews dtl = (ReadMore_TribunNews)Content_Member.Controls[0];
            dtl.setPage(id);
        }

    }
}