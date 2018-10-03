using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.UDC.Global;

namespace Site_Final_Mining
{
    public partial class Site_Please_Login_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["userControl"] = "~/UDC/Global/Login.ascx";
            this.loadControl(ViewState["userControl"].ToString(), false);
        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
            Control Dashboard = Page.LoadControl("~/UDC/Global/Login.ascx");
            Content_Login.Controls.Clear();
            Content_Login.Controls.Add(Dashboard);
        }
        public void LoadAlert(string jenis, string message)
        {
            this.loadControl(ViewState["userControl"].ToString(), true);
            Alert alrt = (Alert)Alert_Message.Controls[0];
            alrt.setAlert(jenis, message);
        }
    }
}