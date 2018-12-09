using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site_Final_Mining.Model;

namespace Site_Final_Mining.Model
{

    public class SetLog
    {
        connectionClass con = new connectionClass();
        public void InsertLog(string email, string id_berita, string judul)
        {
            this.con = new connectionClass();
            string query = "INSERT INTO public.\"logActivity_Member\"(email, id_berita, judul) VALUES ('" + email + "', '" + id_berita + "','" + judul + "');";
            con.excequteQuery(query);
        }
    }


}
