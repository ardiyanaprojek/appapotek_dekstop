using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace apotek_Ardiyana
{
    class db
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username=root; password=; database=dbapotek");

        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string sql)
        {
            Console.WriteLine(sql);
            ds.Tables.Clear();
            perintah = new MySqlCommand(sql, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}
