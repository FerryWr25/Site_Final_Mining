using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;
using System.Data;

namespace Site_Final_Mining
{

    public partial class register : System.Web.UI.Page
    {
        private connectionClass con;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Clik(object sender, EventArgs e)
        {

            if (!email.Value.Equals(""))
            {
                if (!cekEmail_db(email.Value) == true)
                {
                    if (!pass.Value.Equals(""))
                    {
                        if (pass.Value.Equals(pass2.Value))
                        {
                            string fixPas = pass.Value;
                            this.con = new connectionClass();
                            string query = "INSERT INTO public.pendaftar (email, password, jenkel, agama,\"statusDaftar\")" +
                                " VALUES ('"+email.Value+"', '"+pass.Value+"', '"+ this.jenkel.Items + "', '"+ agama.Items+"','1');";
                            this.con.excequteQuery(query);
                            message_success.Attributes["class"] = "";
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }


        private Boolean cekEmail_db(string email)
        {
            this.con = new connectionClass();
            DataTable result = this.con.getResult("SELECT * FROM main.user WHERE email = '" + email + "';");
            if (result.Rows.Count > 0)
                return true;
            else
                return false;
        }
        protected void dissmissMessage_click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}