using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Admin
{
    public partial class Container : System.Web.UI.Page
    {
        ContainerDatabase containerDatabase;
        int id;
        public Container() {

            containerDatabase = new ContainerDatabase();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            CountryDatabase countryDatabase = new CountryDatabase();
            Country.DataSource = countryDatabase.getAllCountry();
            Country.DataTextField = "country";
            Country.DataValueField = "id";
            Country.DataBind();
            loadTable();

            if (Request.QueryString["id"] != null)
            {

                id = int.Parse(Request.QueryString["id"]);
                submit.Text = "Update Container";
                CountryDatabase countryDatbase = new CountryDatabase();
                CountryModel countryModel = countryDatbase.getCountry(id);
                Country.Items.FindByValue(countryModel.ContinentId.ToString());
                //countryTxtbox.Text = countryModel.Name;
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ContainerModel containerModel = new ContainerModel();
            containerModel.ContainerNumber = containerNumberTxt.Text;
            containerModel.CountryId = int.Parse(Country.Text);
            if (submit.Text.Equals("Add Container"))
            {
                if (containerDatabase.saveContainer(containerModel))
                {
                    information.Text = "Container Added";
                }
                else
                {
                    information.Text = "Container not Added";
                }
            }
            else
            {
                containerModel.Id = id;
                if (IsPostBack)
                {
                    containerModel.ContainerNumber = containerNumberTxt.Text;
                    containerModel.CountryId = int.Parse(Country.Text);
                    if (containerDatabase.updateContainer(containerModel))
                    {
                        //information.Text = country.Name;
                        loadTable();
                    }
                    else
                    {
                        information.Text = "Sorry Not Added";
                    }
                }

            }
        }

        private void loadTable() {
            rptTable.DataSource = containerDatabase.getAllContainer();
            rptTable.DataBind();
        }

    }
}