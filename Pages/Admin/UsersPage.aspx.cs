using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Admin
{
    public partial class UsersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDatabase userDatabase = new UserDatabase();
            rptTable.DataSource = userDatabase.getUsers();
            rptTable.DataBind();
        }
    }
}