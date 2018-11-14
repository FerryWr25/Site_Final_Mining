using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining
{
    public partial class Welcome_to_Site_Mining_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["userControl"] = "~/UDC/Guest/homeGuest.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
            Content_Guest.Controls.Clear();
            Content_Guest.Controls.Add(ctrl);
        }
        private void changeActiveMenu(string menu)
        {
            switch (menu)
            {
                case "home":
                    menuKlasifikasi.Attributes["class"] = "";
                    menuHome.Attributes["class"] = "active";
                    menuIR.Attributes["class"] = "";
                    menuVSM.Attributes["class"] = "";
                    menuLogin.Attributes["class"] = "";
                    break;
                case "klasifikasi":
                    menuKlasifikasi.Attributes["class"] = "active";
                    menuHome.Attributes["class"] = "";
                    menuIR.Attributes["class"] = "";
                    menuVSM.Attributes["class"] = "";
                    menuLogin.Attributes["class"] = "";
                    break;
                case "IR":
                    menuIR.Attributes["class"] = "active";
                    menuKlasifikasi.Attributes["class"] = "";
                    menuHome.Attributes["class"] = "";
                    menuVSM.Attributes["class"] = "";
                    menuLogin.Attributes["class"] = "";
                    break;
                case "VSM":
                    menuVSM.Attributes["class"] = "active";
                    menuIR.Attributes["class"] = "";
                    menuKlasifikasi.Attributes["class"] = "";
                    menuHome.Attributes["class"] = "";
                    menuLogin.Attributes["class"] = "";
                    break;
                case "Register":
                    menuVSM.Attributes["class"] = "";
                    menuIR.Attributes["class"] = "";
                    menuKlasifikasi.Attributes["class"] = "";
                    menuHome.Attributes["class"] = "";
                    menuLogin.Attributes["class"] = "";
                    break;
            }
        }

        protected void loginClick(object sender, EventArgs e)
        {
            Response.Redirect("Site[Please_Login].aspx");
        }
        protected void klasifikasi_Click(object sender, EventArgs e)
        {
            changeActiveMenu("klasifikasi");
            Control klasifikasi = Page.LoadControl("~/UDC/Guest/Klasifikasi_Page.ascx");
            Content_Guest.Controls.Clear();
            Content_Guest.Controls.Add(klasifikasi);
            ViewState["userControl"] = "~/UDC/Guest/Klasifikasi_Page.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void IR_Click(object sender, EventArgs e)
        {
            changeActiveMenu("IR");
            Control IR = Page.LoadControl("~/UDC/Guest/InformationRetrieval_page.ascx");
            Content_Guest.Controls.Clear();
            Content_Guest.Controls.Add(IR);
            ViewState["userControl"] = "~/UDC/Guest/InformationRetrieval_page.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void VSM_Click(object sender, EventArgs e)
        {
            changeActiveMenu("VSM");
            Control VSM = Page.LoadControl("~/UDC/Guest/vectorSpaceModel_Page.ascx");
            Content_Guest.Controls.Clear();
            Content_Guest.Controls.Add(VSM);
            ViewState["userControl"] = "~/UDC/Guest/vectorSpaceModel_Page.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void home_Click(object sender, EventArgs e)
        {
            changeActiveMenu("home");
            ViewState["userControl"] = "~/UDC/Guest/homeGuest.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pendaftaran[Welcome_Here].aspx");
        }
    }
}