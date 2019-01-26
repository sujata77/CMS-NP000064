using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class ScheduleDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public ScheduleDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
            cmd.Connection = databseConnections.cnn;
        }

        public Boolean saveSchedule(SchdeuleModel schdeule) {

            cmd.CommandText = "insertSchedule";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@departure_date",schdeule.DepartureDate);
            cmd.Parameters.AddWithValue("@departure_port",schdeule.DepartureCountryId);
            cmd.Parameters.AddWithValue("@arrival_port",schdeule.ArrivalCountryID);
            cmd.Parameters.AddWithValue("@container",schdeule.ContainerId);
            cmd.Parameters.AddWithValue("@capacity",schdeule.Capacity);
            cmd.Parameters.AddWithValue("@shipping_status_id", schdeule.ShippingStatus);

            if (cmd.ExecuteNonQuery() > 0) {

                return true;
            }

            return false;
        }

        public DataTable getAllSchedules() {

            cmd.Parameters.Clear();
            cmd.CommandText = "getAllSchedule";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable countries = new DataTable();
            dataAdapter.Fill(countries);

            return countries;
        }

        public DataTable searchSchedule(string date,int departure_port) {
            cmd.Parameters.Clear();
            cmd.CommandText = "searchSchedule";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@departure_port", departure_port);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable schedule = new DataTable();
            dataAdapter.Fill(schedule);

            return schedule;
        }

        public Boolean updateContainerStatus(int status,int containerId) {

            cmd.Parameters.Clear();
            cmd.CommandText = "updateContainerStatus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", containerId);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;
        }

        public Boolean updateShippingStatus(int status, int schdeduleId)
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "updateScheduleShippingStatus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", schdeduleId);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;
        }
    }
}