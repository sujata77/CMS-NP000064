using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class CountryDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public CountryDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
            cmd.Connection = databseConnections.cnn;
        }

        public Boolean saveCountry(CountryModel country) {

            cmd.Parameters.Clear();
            cmd.CommandText = "storeCountry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", country.Name);
            cmd.Parameters.AddWithValue("@continent_id", country.ContinentId);
            if (cmd.ExecuteNonQuery() > 0) {

                return true;
            }

            return false;
        }

        public DataTable getAllCountry() {

            cmd.Parameters.Clear();
            cmd.CommandText = "selectAllCountry";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable countries = new DataTable();
            dataAdapter.Fill(countries);

            return countries;
        }

        public CountryModel getCountry(int id) {
            cmd.Parameters.Clear();
            cmd.CommandText = "selectSingleCountry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            CountryModel countryModel = new CountryModel();
            DataTable country = new DataTable();
            adapter.Fill(country);
            countryModel.Name = (string) country.Rows[0][1];
            countryModel.ContinentId = (int) country.Rows[0][2];

            return countryModel;
        }

        public Boolean updateCountry(CountryModel country)
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "updateCountry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", country.Id);
            cmd.Parameters.AddWithValue("@name", country.Name);
            cmd.Parameters.AddWithValue("@continent_id", country.ContinentId);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;
        }

    }
}