using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ContainerManagementSystem.Pages.Client
{
    public partial class BookingPage : System.Web.UI.Page
    {
        int countryId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                countryId = int.Parse(Country.SelectedValue);
            }            
            
            CountryDatabase countryDatabase = new CountryDatabase();
            Country.DataSource = countryDatabase.getAllCountry();
            Country.DataTextField = "country";
            Country.DataValueField = "id";
            Country.DataBind();
            Country.SelectedValue = countryId.ToString();
        }

        protected void SearchContainer_Click(object sender, EventArgs e)
        {
            
           
            ScheduleDatabase scheduleDatabase = new ScheduleDatabase();
            System.Console.Write(Country.SelectedValue);
            rptTable.DataSource = scheduleDatabase.searchSchedule(departureDate.Text,countryId);
            rptTable.DataBind();           
            
        }
    }
}