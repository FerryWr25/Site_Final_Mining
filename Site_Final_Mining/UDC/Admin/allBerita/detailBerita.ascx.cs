﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_Final_Mining.UDC.Admin.allBerita
{
    public partial class detailBerita : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void setPage(string id)
        {
            contentBerita.InnerHtml = Session["id"].ToString();
        }
        
    }
}