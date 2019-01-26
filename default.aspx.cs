using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

            UserDatabase userDatabase = new UserDatabase();
            int id = userDatabase.isUserValid(usernameTxt.Text, passwordTxt.Text);
            if (id > 0) {
                msg.Text = "login sucessfull";
                UserModel userModel = userDatabase.getUser(id);
                
                Session["username"] = userModel.Name;
                Session["user_id"] = userModel.Id;

                if (userModel.Role == 2)
                {
                    Response.Redirect("/Pages/Client/Dashboard.aspx");
                }
                else if (userModel.Role == 1) {
                    Response.Redirect("/Pages/Admin/Dashboard.aspx");
                }

                
            }

        }
    }
}