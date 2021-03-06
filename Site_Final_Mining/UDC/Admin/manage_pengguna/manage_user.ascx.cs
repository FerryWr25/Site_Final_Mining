﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining.UDC.Admin.manage_pengguna
{
    public partial class manage_user : System.Web.UI.UserControl
    {
        private connectionClass con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Content/MyStyleGrid.css") + "\" />"));
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/admin-lte/css/adminLTE.min.css") + "\" />"));
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT uf.\"namaPengguna\", uf.email, ur.pekerjaan, uf.path_photo,  " +
                "ur.jenis_kelamin, ur.alamat, ur.\"tanggalDaftar\", ur.\"alasanBergabung\" FROM public.\"userFix\" uf join public.\"user_register\" ur on (uf.email=ur.email);");
            for (int i = 0; i < pengguna.Rows.Count; i++)
            {
                pengguna.Rows[i]["path_photo"] = "~/admin-lte/img/" + pengguna.Rows[i]["path_photo"].ToString();
                this.tabelPendaftar.DataSource = pengguna;
                this.tabelPendaftar.DataBind();
            }
            
        }
        protected void nextView(object sender , GridViewPageEventArgs fer)
        {
            this.tabelPendaftar.PageIndex = fer.NewPageIndex;
            this.tabelPendaftar.DataBind();
        }
        
        protected void a_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
            parent.logActivityDetail_Member(sender,e,btn.CommandArgument);
        }

    }
}