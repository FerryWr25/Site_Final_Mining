using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining
{
    public partial class Dashboard_Site_Member_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Member"] == null)
            {
                Response.Redirect("Site[Please_Login].aspx");
            }
            else
            {
                ViewState["userControl"] = "~/UDC/Member/Dashboard.ascx";
                this.loadControl(ViewState["userControl"].ToString(), false);
            }

        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
            Control Dashboard = Page.LoadControl("~/UDC/Member/Dashboard.ascx");
            Dasboard_Member.Controls.Clear();
            Dasboard_Member.Controls.Add(Dashboard);
        }
        protected void keluarClick(object sender, EventArgs e)
        {
            Session.Remove("Member");
            Response.Redirect("Welcome_to[Site_Mining].aspx");
        }
    }
}