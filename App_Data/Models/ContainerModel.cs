using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerManagementSystem
{
    public class ContainerModel
    {
        int id;
        string containerNumber;
        int countryId;

        public int Id { get => id; set => id = value; }
        public string ContainerNumber { get => containerNumber; set => containerNumber = value; }
        public int CountryId { get => countryId; set => countryId = value; }
    }
}