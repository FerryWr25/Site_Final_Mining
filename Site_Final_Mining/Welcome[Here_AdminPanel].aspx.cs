using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining
{
    public partial class Welcome_Here_AdminPanel_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["userControl"] = "~/UDC/Admin/Dashboard.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(ctrl);
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
                    kategori_berita_olahraga.Attributes["class"] = "";
                    kategori_berita_pemerintahan.Attributes["class"] = "";
                    kategori_berita_bencana_alam.Attributes["class"] = "";
                    kategori_berita_kecelakaan.Attributes["class"] = "";
                    kategori_berita_kejahatan.Attributes["class"] = "";
                    kategori_berita_lain_lainnya.Attributes["class"] = "";
                    break;
                case "allBerita":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "active";
                    menu_kategori_berita.Attributes["class"] = "treeview";
                    kategori_berita_olahraga.Attributes["class"] = "";
                    kategori_berita_pemerintahan.Attributes["class"] = "";
                    kategori_berita_bencana_alam.Attributes["class"] = "";
                    kategori_berita_kecelakaan.Attributes["class"] = "";
                    kategori_berita_kejahatan.Attributes["class"] = "";
                    kategori_berita_lain_lainnya.Attributes["class"] = "";
                    break;
                case "kategoriOlahraga":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview active";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
                case "kategoriBencanaAlam":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview active";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
                case "kategoriKejahatan":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview active";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
                case "kategoriPemerintahan":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview active";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
                case "kategoriKecelakaan":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview active";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
                case "kategoriLainnya":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview active";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview active";
                    break;
                case "profile":
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_dashboard.Attributes["class"] = "";
                    menu_all_konten_berita.Attributes["class"] = "";
                    menu_kategori_berita.Attributes["class"] = "treeview menu";
                    kategori_berita_olahraga.Attributes["class"] = "threeview";
                    kategori_berita_pemerintahan.Attributes["class"] = "threeview";
                    kategori_berita_bencana_alam.Attributes["class"] = "threeview";
                    kategori_berita_kecelakaan.Attributes["class"] = "threeview";
                    kategori_berita_kejahatan.Attributes["class"] = "threeview";
                    kategori_berita_lain_lainnya.Attributes["class"] = "threeview";
                    break;
            }
        }
        protected void olahraga_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriOlahraga");
            Control olahraga = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriOlahraga.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(olahraga);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriOlahraga.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void allBerita_Click(object sender, EventArgs e)
        {
            changeActiveMenu("allBerita");
            Control allberita = Page.LoadControl("~/UDC/Global/allSitus_Berita.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(allberita);
            ViewState["userControl"] = "~/UDC/Global/allSitus_Berita.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void dashBoard_click(object sender, EventArgs e)
        {
            changeActiveMenu("dashBoard");
        }
        protected void bencana_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriBencanaAlam");
            Control bencana = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriBencana.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(bencana);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriBencana.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void kejahatan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriKejahatan");
            Control kejahatan = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriKejahatan.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(kejahatan);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriKejahatan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void pemerintahan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriPemerintahan");
            Control pemerintahan = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriPemerintahan.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(pemerintahan);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriPemerintahan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void kecelakaan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriKecelakaan");
            Control kecelakaan = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriKecelakaan.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(kecelakaan);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriKecelakaan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void lainnya_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriLainnya");
            Control lainnya = Page.LoadControl("~/UDC/Admin/kategoriBerita/kategoriLain.ascx");
            Content_Admin.Controls.Clear();
            Content_Admin.Controls.Add(lainnya);
            ViewState["userControl"] = "~/UDC/Admin/kategoriBerita/kategoriLain.ascx";
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
    }
}