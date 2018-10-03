using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining.UDC.Login
{
    public partial class Login : System.Web.UI.UserControl
    {
        private connectionClass con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Masuk_Click(object sender, EventArgs e)
        {
            this.getDataUser(this.email.Value, this.password.Value);
        }
        private void getDataUser(string email, string password)
        {
            Site_Please_Login_ parrent = (Site_Please_Login_)this.Page;

            this.con = new connectionClass();
            string query = "SELECT * FROM public.user " +
                "WHERE email = '" + email + "' " +
                "AND password = '" + password + "';";
            DataTable result = this.con.getResult(query);
            if (result.Rows.Count == 0)
            {
                parrent.LoadAlert("warning", "Email / Password Yang Anda Masukkan Salah");
            }
            else
            {
                if (result.Rows[0]["level"].ToString().Equals("1"))
                {
                    Session.Remove("Member");
                    Session["Admin"] = "online";
                    Response.Redirect("Welcome[Here_AdminPanel].aspx");
                }
                else
                {
                    Session.Remove("Admin");
                    Session["Member"] = "online";
                    Response.Redirect("Welcome[Here_MemberPanel].aspx");
                }
            }
        }
    }
}