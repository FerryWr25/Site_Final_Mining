using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining
{
    public partial class verifikasiKode : System.Web.UI.Page
    {
        private connectionClass con;
        string kodeVerifikasi, password, level, pathPhoto, nama;
        protected void Page_Load(object sender, EventArgs e)
        {
            labelEmail.Text = Session["EmailPendaftar"].ToString();
            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT *  FROM public.user_register where email='" + Session["EmailPendaftar"] + "';");
            kodeVerifikasi = pengguna.Rows[0]["kodeReg"].ToString();
            password = pengguna.Rows[0]["password"].ToString();
            pathPhoto = pengguna.Rows[0]["pathPhoto"].ToString();
            nama = pengguna.Rows[0]["nama"].ToString();
        }
        protected void verifikasi_click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(kode.Value) == Convert.ToInt32(kodeVerifikasi))
            {
                this.con = new connectionClass();
                string queryInsert = "INSERT INTO public.\"userFix\"(email, password, level, path_photo, \"namaPengguna\")" +
                    " VALUES ('" + Session["EmailPendaftar"] + "', '" + password + "', '2', '" + pathPhoto + "', '" + nama + "');";
                this.con.excequteQuery(queryInsert);

                Response.Redirect("Welcome[Here_MemberPanel].aspx");
            }
            else
            {
                labelNotifikasi.Attributes["CssClas"] = "";
                labelNotifikasi.Text = "Kode Yang anda Masukkan Salah";
            }
        }

    }
}