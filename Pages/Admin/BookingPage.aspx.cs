using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Admin
{
    public partial class BookingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
                if (Request.QueryString["id"] != null)
                {

                    BookingDatabase bookingDatabase = new BookingDatabase();
                    if (bookingDatabase.updateBookingStatus(int.Parse(Request.QueryString["id"].ToString()), 1))
                    {
                        loadTable();
                    }
                }
            


            loadTable();
        }

        private void loadTable()
        {

            BookingDatabase bookingDatabase = new BookingDatabase();
            rptTable.DataSource = bookingDatabase.getAllBooking();
            rptTable.DataBind();

        }
    }
}