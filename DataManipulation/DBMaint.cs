using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataManipulation {
    public class DBMaint {
        SqlConnection _con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SampleDatabase.mdf;Integrated Security = True;");

        SqlCommand _cmd;
        SqlDataAdapter _adapt;


        // Create

        // Read
        public DataTable ReadFromDB() {
            DataTable dt = new DataTable();
            _con.Open();
            _adapt = new SqlDataAdapter("select * from tbl_Record", _con);
            _adapt.Fill(dt);
            _con.Close();

            return dt;
        }

        // Update
        // Delete


    }
}
