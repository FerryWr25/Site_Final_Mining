using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.UDC.Global
{
    public partial class header_admin : System.Web.UI.UserControl
    {
        private connectionClass con;
        protected void Page_Load(object sender, EventArgs e)
        {
            profileImage_dropdown.Attributes["src"] = getPathIMage();
            profileSideBar.Attributes["src"] = getPathIMage();
            labelNama2.Text = getName();
            labelNama3.Text = getName();

            this.con = new connectionClass();
            this.con.openConnection();
            DataTable pengguna = this.con.getResult("SELECT count(*) as get FROM public.\"userFix\" where level='2';");

            this.con = new connectionClass();
            DataTable MemberBaru = this.con.getResult("SELECT * FROM public.user_register order by \"tanggalDaftar\" desc limit 3;");

            profileImage1.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[0]["pathPhoto"].ToString();
            profileImage2.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[1]["pathPhoto"].ToString();
            profileImage3.Attributes["src"] = "admin-lte/img/" + MemberBaru.Rows[2]["pathPhoto"].ToString();
            if (MemberBaru.Rows[0]["nama"].ToString().Length > 15)
            {
                Nama1.Text = MemberBaru.Rows[0]["nama"].ToString().Remove(15);
            }
            else
            {
                Nama1.Text = MemberBaru.Rows[0]["nama"].ToString();
            }
            if (MemberBaru.Rows[1]["nama"].ToString().Length > 15)
            {
                Nama2.Text = MemberBaru.Rows[1]["nama"].ToString().Remove(15);
            }
            else
            {
                Nama2.Text = MemberBaru.Rows[1]["nama"].ToString();
            }
            if (MemberBaru.Rows[2]["nama"].ToString().Length > 15)
            {
                Nama3.Text = MemberBaru.Rows[2]["nama"].ToString().Remove(15);
            }
            else
            {
                Nama3.Text = MemberBaru.Rows[2]["nama"].ToString();
            }

            pekerjaan1.Text = MemberBaru.Rows[0]["pekerjaan"].ToString();
            pekerjaan2.Text = MemberBaru.Rows[1]["pekerjaan"].ToString();
            pekerjaan3.Text = MemberBaru.Rows[2]["pekerjaan"].ToString();

            tanggalDaftar1.Text = getTimeAgo(MemberBaru.Rows[0]["tanggalDaftar"].ToString());
            tanggalDaftar2.Text = getTimeAgo(MemberBaru.Rows[1]["tanggalDaftar"].ToString());
            tanggalDaftar3.Text = getTimeAgo(MemberBaru.Rows[2]["tanggalDaftar"].ToString());

        }
        public static string getTimeAgo(string strDate)
        {
            string strTime = string.Empty;
            if (IsDate(Convert.ToString(strDate)))
            {
                TimeSpan t = DateTime.Now - Convert.ToDateTime(strDate);
                double deltaSeconds = t.TotalSeconds;

                double deltaMinutes = deltaSeconds / 60.0f;
                int minutes;

                if (deltaSeconds < 5)
                {
                    return "Just now";
                }
                else if (deltaSeconds < 60)
                {
                    return Math.Floor(deltaSeconds) + " seconds ago";
                }
                else if (deltaSeconds < 120)
                {
                    return "A minute ago";
                }
                else if (deltaMinutes < 60)
                {
                    return Math.Floor(deltaMinutes) + " minutes ago";
                }
                else if (deltaMinutes < 120)
                {
                    return "An hour ago";
                }
                else if (deltaMinutes < (24 * 60))
                {
                    minutes = (int)Math.Floor(deltaMinutes / 60);
                    return minutes + " hours ago";
                }
                else if (deltaMinutes < (24 * 60 * 2))
                {
                    return "Yesterday";
                }
                else if (deltaMinutes < (24 * 60 * 7))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24));
                    return minutes + " days ago";
                }
                else if (deltaMinutes < (24 * 60 * 14))
                {
                    return "Last week";
                }
                else if (deltaMinutes < (24 * 60 * 31))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 7));
                    return minutes + " weeks ago";
                }
                else if (deltaMinutes < (24 * 60 * 61))
                {
                    return "Last month";
                }
                else if (deltaMinutes < (24 * 60 * 365.25))
                {
                    minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 30));
                    return minutes + " months ago";
                }
                else if (deltaMinutes < (24 * 60 * 731))
                {
                    return "Last year";
                }

                minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 365));
                return minutes + " years ago";
            }
            else
            {
                return "";
            }
        }
        public static bool IsDate(string o)
        {
            DateTime tmp;
            return DateTime.TryParse(o, out tmp);
        }
        public string getName()
        {
            string name = null;
            this.con = new connectionClass();
            string query = "select \"namaPengguna\" from public.\"user\" where email='" + Session["Admin"] + "'";
            DataTable data = this.con.getResult(query);
            name = data.Rows[0]["namaPengguna"].ToString();
            return name;
        }
        public string getPathIMage()
        {
            string path = null;
            this.con = new connectionClass();
            string query = "select path_photo from public.\"user\" where email='" + Session["Admin"] + "'";
            DataTable data = this.con.getResult(query);
            path = "admin-lte/img/" + data.Rows[0]["path_photo"].ToString();
            return path;
        }
        protected void keluar_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
         
        }
        protected void profile_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
           
        }
        public void manageUser_Click(object sender, EventArgs e)
        {
            Welcome_Here_AdminPanel_ parent = (Welcome_Here_AdminPanel_)this.Page;
           
        }
    }
}