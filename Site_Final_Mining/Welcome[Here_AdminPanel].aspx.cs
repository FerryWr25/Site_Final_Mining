using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using Site_Final_Mining.UDC;
using System.Data;
using Site_Final_Mining.UDC.Admin.allBerita;
using Newtonsoft.Json;
using System.IO;
using Site_Final_Mining.UDC.Global.Filter_Dokumen;
using Site_Final_Mining.UDC.Admin.manage_pengguna;

namespace Site_Final_Mining
{
    public partial class Welcome_Here_AdminPanel_ : System.Web.UI.Page
    {
        private connectionClass con;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin"] != null)
            {
                if (ViewState["userControl"] == null)
                {
                    ViewState["userControl"] = "~/UDC/Admin/Dashboard.ascx";
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

                this.con = new connectionClass();
                this.con.openConnection();
                DataTable pengguna = this.con.getResult("SELECT count(*) as get FROM public.\"userFix\" where level='2';");

                this.con = new connectionClass();
                DataTable MemberBaru = this.con.getResult("SELECT * FROM public.user_register order by \"tanggalDaftar\" desc limit 3;");

                profileImage1.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[0]["pathPhoto"].ToString();
                profileImage2.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[1]["pathPhoto"].ToString();
                profileImage3.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[2]["pathPhoto"].ToString();
                if (MemberBaru.Rows[0]["nama"].ToString().Length > 15)
                {
                    Nama1.Text = MemberBaru.Rows[0]["nama"].ToString().Remove(15);
                }
                else
                {
                    Nama1.Text = MemberBaru.Rows[0]["nama"].ToString();
                }
                if (MemberBaru.Rows[1]["nama"].ToString().Length > 15)
                {
                    Nama2.Text = MemberBaru.Rows[1]["nama"].ToString().Remove(15);
                }
                else
                {
                    Nama2.Text = MemberBaru.Rows[1]["nama"].ToString();
                }
                if (MemberBaru.Rows[2]["nama"].ToString().Length > 15)
                {
                    Nama3.Text = MemberBaru.Rows[2]["nama"].ToString().Remove(15);
                }
                else
                {
                    Nama3.Text = MemberBaru.Rows[2]["nama"].ToString();
                }

                pekerjaan1.Text = MemberBaru.Rows[0]["pekerjaan"].ToString();
                pekerjaan2.Text = MemberBaru.Rows[1]["pekerjaan"].ToString();
                pekerjaan3.Text = MemberBaru.Rows[2]["pekerjaan"].ToString();

                tanggalDaftar1.Text = getTimeAgo(MemberBaru.Rows[0]["tanggalDaftar"].ToString());
                tanggalDaftar2.Text = getTimeAgo(MemberBaru.Rows[1]["tanggalDaftar"].ToString());
                tanggalDaftar3.Text = getTimeAgo(MemberBaru.Rows[2]["tanggalDaftar"].ToString());

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
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(ctrl);
        }
        public static string getTimeAgo(string strDate)
        {
            string strTime = string.Empty;
            if (IsDate(Convert.ToString(strDate)))
            {
                TimeSpan t = DateTime.Now - Convert.ToDateTime(strDate);
                double deltaSeconds = t.TotalSeconds;

                double deltaMinutes = deltaSeconds / 60.0f;
                int minutes;

                if (deltaSeconds < 5)
                {
                    return "Just now";
                }
                else if (deltaSeconds < 60)
                {
                    return Math.Floor(deltaSeconds) + " seconds ago";
                }
                else if (deltaSeconds < 120)
                {
                    return "A minute ago";
                }
                else if (deltaMinutes < 60)
                {
                    return Math.Floor(deltaMinutes) + " minutes ago";
                }
                else if (deltaMinutes < 120)
                {
                    return "An hour ago";
                }
                else if (deltaMinutes < (24 * 60))
                {
                    minutes = (int)Math.Floor(deltaMinutes / 60);
                    return minutes + " hours ago";
                }
                else if (deltaMinutes < (24 * 60 * 2))
                {
                    return "Yesterday";
                }
                else if (deltaMinutes < (24 * 60 * 7))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24));
                    return minutes + " days ago";
                }
                else if (deltaMinutes < (24 * 60 * 14))
                {
                    return "Last week";
                }
                else if (deltaMinutes < (24 * 60 * 31))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 7));
                    return minutes + " weeks ago";
                }
                else if (deltaMinutes < (24 * 60 * 61))
                {
                    return "Last month";
                }
                else if (deltaMinutes < (24 * 60 * 365.25))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 30));
                    return minutes + " months ago";
                }
                else if (deltaMinutes < (24 * 60 * 731))
                {
                    return "Last year";
                }

                minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 365));
                return minutes + " years ago";
            }
            else
            {
                return "";
            }
        }
        public static bool IsDate(string o)
        {
            DateTime tmp;
            return DateTime.TryParse(o, out tmp);
        }
        public string getName()
        {
            string name = null;
            this.con = new connectionClass();
            string query = "select \"namaPengguna\" from public.\"user\" where email='" + Session["Admin"] + "'";
            DataTable data = this.con.getResult(query);
            name = data.Rows[0]["namaPengguna"].ToString();
            return name;
        }
        public string getPathIMage()
        {
            string path = null;
            this.con = new connectionClass();
            string query = "select path_photo from public.\"user\" where email='" + Session["Admin"] + "'";
            DataTable data = this.con.getResult(query);
            path = "admin-lte/img/" + data.Rows[0]["path_photo"].ToString();
            return path;
        }

        protected void keluar_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin");
            Response.Redirect("Welcome_to[Site_Mining].aspx");
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
                case "pengguna":
                    pengguna.Attributes["class"] = "active";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview";
                    btn_tribunnews.Attributes["class"] = "";
                    btn_detik.Attributes["class"] = "";
                    btn_liputan6.Attributes["class"] = "";
                    break;
            }
        }

        public void loadDetailAnggota(string member_id)
        {
            changeActiveMenu("allBerita");
            Control manageeUser = Page.LoadControl("~/UDC/Admin/manage_pengguna/manage_user.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(manageeUser);
            ViewState["userControl"] = "~/UDC/Admin/manage_pengguna/manage_user.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
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
            Control tribunnews = Page.LoadControl("~/UDC/Global/Filter_Dokumen/Tribunnews.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(tribunnews);
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/Tribunnews.ascx";
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
            Session["status_filter"] = "";
            Control allberita = Page.LoadControl("~/UDC/Admin/allBerita/allDokumen_Berita.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(allberita);
            ViewState["userControl"] = "~/UDC/Admin/allBerita/allDokumen_Berita.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void dashBoard_click(object sender, EventArgs e)
        {
            changeActiveMenu("dashBoard");
            Control dashboard = Page.LoadControl("~/UDC/Admin/Dashboard.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(dashboard);
            ViewState["userControl"] = "~/UDC/Admin/Dashboard.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void liputan6_Click(object sender, EventArgs e)
        {
            changeActiveMenu("liputan6");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["dataGrafik"] = "";
            Session["filterDate"] = "";
            Session["filterDokumen"] = "";
            Session["status_filter"] = "";
            Control liputan6 = Page.LoadControl("~/UDC/Global/Filter_Dokumen/Liputan6.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(liputan6);
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/Liputan6.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void detik_Click(object sender, EventArgs e)
        {
            changeActiveMenu("detik");
            Session["query"] = "";
            Session["idDoc"] = "";
            Session["dataGrafik"] = "";
            Session["filterDate"] = "";
            Session["filterDokumen"] = "";
            Session["status_filter"] = "";
            Control detik = Page.LoadControl("~/UDC/Global/Filter_Dokumen/Detik.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(detik);
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/Detik.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        
        protected void profile_Click(object sender, EventArgs e)
        {
            changeActiveMenu("profile");
            Control profile = Page.LoadControl("~/UDC/Admin/profile/adminProfile.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(profile);
            ViewState["userControl"] = "~/UDC/Admin/profile/adminProfile.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void manageUser_Click(object sender, EventArgs e)
        {
            changeActiveMenu("pengguna");
            Control manageeUser = Page.LoadControl("~/UDC/Admin/manage_pengguna/manage_user.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(manageeUser);
            ViewState["userControl"] = "~/UDC/Admin/manage_pengguna/manage_user.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void feedActivity_Click(object sender, EventArgs e)
        {
            changeActiveMenu("pengguna");
            Control feed = Page.LoadControl("~/UDC/Admin/feedActivity/feedActivity_Member.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(feed);
            ViewState["userControl"] = "~/UDC/Admin/feedActivity/feedActivity_Member.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void manageKonten_Click(object sender, EventArgs e)
        {
            Control manageKonten = Page.LoadControl("~/UDC/Admin/Refresh_IR/refreshIR.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(manageKonten);
            ViewState["userControl"] = "~/UDC/Admin/Refresh_IR/refreshIR.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        public void readMore_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Admin/allBerita/detailBerita.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            detailBerita dtl = (detailBerita)Content_Admin.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreDetik_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/readMore_detik.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            readMore_detik dtl = (readMore_detik)Content_Admin.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreLiputan6_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/readMore_Liputan6.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            readMore_Liputan6 dtl = (readMore_Liputan6)Content_Admin.Controls[0];
            dtl.setPage(id);
        }
        public void readMoreTribun_Click(string id)
        {
            ViewState["userControl"] = "~/UDC/Global/Filter_Dokumen/readMore_Tribun.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            readMore_Tribun dtl = (readMore_Tribun)Content_Admin.Controls[0];
            dtl.setPage(id);
        }
        public void logActivityDetail_Member(object sender, EventArgs e, string email)
        {
            ViewState["userControl"] = "~/UDC/Admin/manage_pengguna/logMember.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
            logMember dtl = (logMember)Content_Admin.Controls[0];
            dtl.Page_Load(sender, e, email);
        }
    }
}

