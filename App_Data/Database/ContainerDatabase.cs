using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class ContainerDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public ContainerDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
            cmd.Connection = databseConnections.cnn;
        }

        public Boolean saveContainer(ContainerModel container) {

            cmd.CommandText = "storeContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@container_number", container.ContainerNumber);
            cmd.Parameters.AddWithValue("@country_id", container.CountryId);
            if (cmd.ExecuteNonQuery() > 0) {

                return true;
            }

            return false;
        }

        public DataTable getAllContainer() {

            cmd.Parameters.Clear();
            cmd.CommandText = "selectAllContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable container = new DataTable();
            dataAdapter.Fill(container);

            return container;
        }

        public DataTable getSelectedContainer(int country) {

            cmd.Parameters.Clear();
            cmd.CommandText = "searchContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@country", country);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable container = new DataTable();
            dataAdapter.Fill(container);

            return container;
        }

        public Boolean updateContainer(ContainerModel container)
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "updateContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", container.Id);
            cmd.Parameters.AddWithValue("@container_number", container.ContainerNumber);
            cmd.Parameters.AddWithValue("@country_id", container.CountryId);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;
        }

    }
}