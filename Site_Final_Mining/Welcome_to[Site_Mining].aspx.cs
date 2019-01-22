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
            
        }
        private void loadControl(string UCD, bool alert)
        {
            Control ctrl = Page.LoadControl(UCD);
            ctrl.ID = "UserControl";
        }
        

        protected void loginClick(object sender, EventArgs e)
        {
            Response.Redirect("Site[Please_Login].aspx");
        }
        
        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pendaftaran[Welcome_Here].aspx");
        }
    }
}