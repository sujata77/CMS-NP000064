using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class BookingDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public BookingDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
            cmd.Connection = databseConnections.cnn;
        }

        public Boolean saveBooking(BookingModel booking) {
            cmd.Parameters.Clear();
            cmd.CommandText = "insertBooking";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@users_id", booking.UserId);            
            cmd.Parameters.AddWithValue("@schedule_id", booking.ScheduleID);            
            cmd.Parameters.AddWithValue("@weight", booking.Weight);            
            cmd.Parameters.AddWithValue("@quantity", booking.Quantity);            
            cmd.Parameters.AddWithValue("@status", booking.Status);
            cmd.Parameters.AddWithValue("@shipping", booking.Shipping_status);
            if (cmd.ExecuteNonQuery() > 0) {

                return true;
            }

            return false;
        }

        public DataTable getUsers() {

            cmd.Parameters.Clear();
            cmd.CommandText = "selectAllCountry";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable countries = new DataTable();
            dataAdapter.Fill(countries);

            return countries;
        }

        public DataTable getShippingStatus() {
            cmd.Parameters.Clear();
            cmd.CommandText = "selectShippingStatus";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable shippingStatus = new DataTable();
            dataAdapter.Fill(shippingStatus);
            return shippingStatus;
        }

        public Boolean bookContainer(int id) {

            cmd.Parameters.Clear();
            cmd.CommandText = "bookContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;

        }

        public Boolean releaseContainer(int id)
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "releaseContainer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;

        }

        public Boolean updateBookingStatus(int id,int status)
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "changeBookingStatus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return true;
            }

            return false;

        }

        public DataTable getBookedContainer(int userId) {

            cmd.Parameters.Clear();
            cmd.CommandText = "selectBookedContainerOfUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", userId);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable containers = new DataTable();
            dataAdapter.Fill(containers);

            return containers;
        }

        public DataTable getAllBooking()
        {

            cmd.Parameters.Clear();
            cmd.CommandText = "getAllBooking";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable booking = new DataTable();
            dataAdapter.Fill(booking);

            return booking;
        }

    }
}