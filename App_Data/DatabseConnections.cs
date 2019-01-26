using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ContainerManagementSystem
{
    public class DatabseConnections
    {
        public SqlConnection cnn;

        public DatabseConnections() {

            cnn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
            cnn.Open();
        }

    }
}