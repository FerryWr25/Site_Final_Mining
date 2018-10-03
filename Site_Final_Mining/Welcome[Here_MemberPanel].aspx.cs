using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining
{
    public partial class Welcome_Here_Member_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Member"] != null)
            {
                ViewState["userControl"] = "~/UDC/Member/Dashboard.ascx";
                this.loadControl(ViewState["userControl"].ToString(), false);
            } else
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
        protected void keluar_Click(object sender, EventArgs e)
        {
            Session.Remove("Member");
            Session.Abandon();
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }
        protected void olahraga_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriOlahraga");
            Control olahraga = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriOlahraga.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(olahraga);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriOlahraga.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void allBerita_Click(object sender, EventArgs e)
        {
            changeActiveMenu("allBerita");
            Control allberita = Page.LoadControl("~/UDC/Global/allSitus_Berita.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(allberita);
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
            Control bencana = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriBencana.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(bencana);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriBencana.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void kejahatan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriKejahatan");
            Control kejahatan = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriKejahatan.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(kejahatan);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriKejahatan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void pemerintahan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriPemerintahan");
            Control pemerintahan = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriPemerintahan.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(pemerintahan);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriPemerintahan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void kecelakaan_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriKecelakaan");
            Control kecelakaan = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriKecelakaan.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(kecelakaan);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriKecelakaan.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void lainnya_Click(object sender, EventArgs e)
        {
            changeActiveMenu("kategoriLainnya");
            Control lainnya = Page.LoadControl("~/UDC/Member/kategoriBerita/kategoriLain.ascx");
            Content_Member.Controls.Clear();
            Content_Member.Controls.Add(lainnya);
            ViewState["userControl"] = "~/UDC/Member/kategoriBerita/kategoriLain.ascx";
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
            }
        }

    }
}