using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            UserDatabase userDatabase = new UserDatabase();
            userModel.Name = nameTxt.Text;
            userModel.Address = addressTxt.Text;
            userModel.Contact = contactTxt.Text;
            userModel.Email = emailTxt.Text;
            userModel.Username = usernameTxt.Text;
            userModel.Password = passwordTxt.Text;
            userModel.Role = 2;
            if (userDatabase.saveUser(userModel))
            {
                ltrText.Text = "User Registered Successfully";
            }
            else {
                ltrText.Text = "Sorry Registration Failed";
            }
        }
    }
}