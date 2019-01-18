using Npgsql;
using System.Data;

namespace Site_Final_Mining.Model
{
    public class connectionClass
    {
        NpgsqlConnection con;
        NpgsqlCommand command;

        public connectionClass()
        {
            this.openConnection();
        }

        public void openConnection()
        {
            if (this.con == null)
            {
                // buat koneksi baru
                string connectionString = "Server=127.0.0.1;Port=5432;Database=skripsi_news; User Id=postgres; Password = 'admin' ;Pooling=False;";
                this.con = new NpgsqlConnection(connectionString);
            }

            // buka koneksi
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        private void closeConnection()
        {
            if (this.con.State == ConnectionState.Open)
            {
                // tutup koneksi
                this.con.Close();
            }
        }

        public void excequteQuery(string query)
        {
            // buat command baru
            this.command = new NpgsqlCommand(query, this.con);
            this.command.CommandType = CommandType.Text;

            // eksekusi query
            this.command.ExecuteNonQuery();
            this.closeConnection();
        }

        public DataTable getResult(string query)
        {
            // buat command baru
            this.command = new NpgsqlCommand(query, this.con);
            this.command.CommandType = CommandType.Text;

            // baca data
            NpgsqlDataReader reader;
            reader = this.command.ExecuteReader();

            // menampung hasil query    
            DataTable result = new DataTable();
            result.Load(reader);
            this.closeConnection();
            // mengembalikan data table berisi hasil query
            return result;
        }
    }
}