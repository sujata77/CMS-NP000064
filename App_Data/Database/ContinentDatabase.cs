using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class ContinentDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public ContinentDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
        }

        public DataTable getAllContinent() {

            cmd.Connection = databseConnections.cnn;
            cmd.CommandText = "selectContinent";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

    }
}