using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining.UDC.Global
{
    public partial class Alert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void setAlert(string alert, string message)
        {
            alert_class.Attributes["class"] = "alert alert-" + alert + " alert-dismissible";
        }
    }
}