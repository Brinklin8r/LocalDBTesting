﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DataManipulation {
    public class DBMaint {

        private readonly SqlConnection _con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SampleDatabase.mdf;Integrated Security = True;");
        private SqlCommand _cmd;
        private SqlDataAdapter _adapt;

        // Create
        public void InsertIntoDB(string Name, string State) {
            string _command = "insert into tbl_Record(Name,State) values(@name,@state)";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();
            _cmd.Parameters.AddWithValue("@name", Name);
            _cmd.Parameters.AddWithValue("@state", State);
            _cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Read
        public DataTable ReadFromDB() {
            DataTable dt = new DataTable();
            string _command = "select * from tbl_Record";

            _con.Open();
            _adapt = new SqlDataAdapter(_command, _con);
            _adapt.Fill(dt);
            _con.Close();

            return dt;
        }

        // Update
        public void UpdateDB(int ID, string Name, string State) {
            string _command = "update tbl_Record set Name=@name,State=@state where ID=@id";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();
            _cmd.Parameters.AddWithValue("@id", ID);
            _cmd.Parameters.AddWithValue("@name", Name);
            _cmd.Parameters.AddWithValue("@state", State);
            _cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Delete
        public void DeleteFromDB(int ID) {
            string _command = "delete tbl_Record where ID=@id";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();
            _cmd.Parameters.AddWithValue("@id", ID);
            _cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}
