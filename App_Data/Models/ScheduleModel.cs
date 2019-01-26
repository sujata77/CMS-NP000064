using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerManagementSystem
{
    public class SchdeuleModel
    {
        int id;
        int containerId;
        int departureCountryId;
        int arrivalCountryID;
        int capacity;
        string departureDate;
        int shippingStatus;

        public int Id { get => id; set => id = value; }
        public int ContainerId { get => containerId; set => containerId = value; }
        public int DepartureCountryId { get => departureCountryId; set => departureCountryId = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int ArrivalCountryID { get => arrivalCountryID; set => arrivalCountryID = value; }
        public int ShippingStatus { get => shippingStatus; set => shippingStatus = value; }
    }
}