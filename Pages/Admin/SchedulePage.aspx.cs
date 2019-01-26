using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Admin
{
    public partial class SchedulePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CountryDatabase countryDatabase = new CountryDatabase();
            ContainerDatabase containerDatabase = new ContainerDatabase();
            Container.DataSource = containerDatabase.getAllContainer();
            Container.DataTextField = "container_number";
            Container.DataValueField = "id";
            Container.DataBind();

            DepartureCountry.DataSource = countryDatabase.getAllCountry();
            DepartureCountry.DataTextField = "country";
            DepartureCountry.DataValueField = "id";
            DepartureCountry.DataBind();


            
            ArrivalCountry.DataSource = countryDatabase.getAllCountry();
            ArrivalCountry.DataTextField = "country";
            ArrivalCountry.DataValueField = "id";
            ArrivalCountry.DataBind();

            loadTable();

            if (Request.QueryString["id"] != null) {

                ScheduleDatabase scheduleDatabase = new ScheduleDatabase();
                if (scheduleDatabase.updateShippingStatus(int.Parse(Request.QueryString["id"]), 2)){

                    if (scheduleDatabase.updateContainerStatus(int.Parse(Request.QueryString["container-id"]),0)) {
                        loadTable();
                    }

                }
            }
        }


        protected void DepartureCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loadTable()
        {

            ScheduleDatabase scheduleDatabase  = new ScheduleDatabase();
            rptTable.DataSource = scheduleDatabase.getAllSchedules();
            rptTable.DataBind();

        }

        protected void Book_Click(object sender, EventArgs e)
        {
            SchdeuleModel schdeuleModel = new SchdeuleModel();
            schdeuleModel.DepartureDate = departureDate.Text;
            schdeuleModel.DepartureCountryId = int.Parse(DepartureCountry.SelectedValue);
            schdeuleModel.ArrivalCountryID = int.Parse(ArrivalCountry.SelectedValue);
            schdeuleModel.Capacity = int.Parse(capacity.Text);
            schdeuleModel.ContainerId = int.Parse(Container.SelectedValue);
            schdeuleModel.ShippingStatus = 1;
            ScheduleDatabase scheduleDatabase = new ScheduleDatabase();
            if (scheduleDatabase.saveSchedule(schdeuleModel))
            {
                scheduleDatabase.updateContainerStatus(1,schdeuleModel.ContainerId);
                loadTable();
            }
            else {

            }
             
        }
    }
}