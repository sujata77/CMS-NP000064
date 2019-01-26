using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Client
{
    public partial class BookingPage1 : System.Web.UI.Page
    {
        string departure_country_id;
        string conatiner_id;
        string arrival_country_id;
        int scheduleId;
        int bookingid;
        protected void Page_Load(object sender, EventArgs e)
        {
           scheduleId = int.Parse(Request.QueryString["schedule_id"]);
            loadTable();
        }

        protected void Book_Click(object sender, EventArgs e)
        {
            BookingModel bookingModel = new BookingModel();
            BookingDatabase bookingDatabase = new BookingDatabase();

            bookingModel.ScheduleID = scheduleId;
            bookingModel.Weight = int.Parse(weight.Text);
            bookingModel.Quantity = 5;
            bookingModel.UserId = int.Parse(Session["user_id"].ToString());
            bookingModel.Status = 0;
            bookingModel.Shipping_status = 1;

            if (bookingDatabase.saveBooking(bookingModel)) {

                if (bookingDatabase.bookContainer(bookingModel.Id)) {
                    loadTable();
                }

            }

        }

        private void loadTable() {

            BookingDatabase bookingDatabase = new BookingDatabase();
            rptTable.DataSource = bookingDatabase.getBookedContainer(int.Parse(Session["user_id"].ToString()));
            rptTable.DataBind();

        }

        protected void ReleaseContainer_Click(object sender, EventArgs e)
        {

        }
    }
}