using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ContainerManagementSystem
{
    public class UserDatabase
    {

        DatabseConnections databseConnections;
        SqlCommand cmd;

        public UserDatabase() {
            databseConnections = new DatabseConnections();
            cmd = new SqlCommand();
            cmd.Connection = databseConnections.cnn;
        }

        public Boolean saveUser(UserModel user) {

            cmd.CommandText = "storeUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@address", user.Address);
            cmd.Parameters.AddWithValue("@contact_number", user.Contact);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            if (cmd.ExecuteNonQuery() > 0) {

                return true;
            }

            return false;
        }

        public DataTable getUsers() {

            cmd.Parameters.Clear();
            cmd.CommandText = "selectAllUsers";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable countries = new DataTable();
            dataAdapter.Fill(countries);

            return countries;
        }

        public int isUserValid(String username, String password) {

            int id = 0;
            cmd.CommandText = "isUserValid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            id = (int)cmd.ExecuteScalar();
            
            return id;

        }

        public UserModel getUser(int id) {

            UserModel userModel = new UserModel();
            cmd.Parameters.Clear();
            cmd.CommandText = "selectSingleUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable user = new DataTable();
            dataAdapter.Fill(user);
            userModel.Id = int.Parse(user.Rows[0][0].ToString());
            userModel.Name = (user.Rows[0][1].ToString());
            userModel.Email = (user.Rows[0][2].ToString());
            userModel.Address = (user.Rows[0][3].ToString());
            userModel.Contact = (user.Rows[0][4].ToString());
            userModel.Username = (user.Rows[0][5].ToString());
            userModel.Role = int.Parse(user.Rows[0][7].ToString());

            return userModel;
        }

    }
}