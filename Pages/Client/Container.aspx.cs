using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Client
{
    public partial class Container : System.Web.UI.Page
    {

        int containerid;
        int bookingid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null) {

                BookingDatabase bookingDatabase = new BookingDatabase();
                if (bookingDatabase.updateBookingStatus(int.Parse(Request.QueryString["id"]), 2)){

                    loadTable();
                }
            }
            loadTable();

        }

        private void loadTable()
        {

            BookingDatabase bookingDatabase = new BookingDatabase();
            rptTable.DataSource = bookingDatabase.getBookedContainer(int.Parse(Session["user_id"].ToString()));
            rptTable.DataBind();

        }
    }


}