using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContainerManagementSystem.Pages.Admin
{
    public partial class Country : System.Web.UI.Page
    {

        int id;

        private CountryDatabase countryDatabase;

        public Country() {
            countryDatabase = new CountryDatabase();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ContinentDatabase continentDatabase = new ContinentDatabase();
            ContinentList.DataSource = continentDatabase.getAllContinent();
            ContinentList.DataTextField = "title";
            ContinentList.DataValueField = "id";
            ContinentList.DataBind();
            loadTable();

            if (Request.QueryString["id"] != null)
            {

                id = int.Parse(Request.QueryString["id"]);
                AddCountry.Text = "Update Country";
                CountryDatabase countryDatbase = new CountryDatabase();
                CountryModel countryModel = countryDatbase.getCountry(id);
                ContinentList.Items.FindByValue(countryModel.ContinentId.ToString());
                //countryTxtbox.Text = countryModel.Name;
            }
        }

        protected void AddCountry_Click(object sender, EventArgs e)
        {
             
            CountryModel country = new CountryModel();
            country.Name = countryTxtbox.Text;
            country.ContinentId = int.Parse(ContinentList.Text);
           
            if (AddCountry.Text.Equals("Add Country"))
            {
                if (countryDatabase.saveCountry(country))
                {
                    information.Text = "Sucessfully Added";
                    loadTable();
                }
                else
                {
                    information.Text = "Sorry Not Added";
                }
            }
            else {
                country.Id = id;
                if (IsPostBack) {
                    country.Name = countryTxtbox.Text;
                    country.ContinentId = int.Parse(ContinentList.Text);
                    if (countryDatabase.updateCountry(country))
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

            rptTable.DataSource = countryDatabase.getAllCountry();
            rptTable.DataBind();
        }

        protected void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}