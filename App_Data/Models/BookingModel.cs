using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerManagementSystem
{
    public class BookingModel
    {
        int id;
        int scheduleID;
        int userId;
        int status;
        int weight;
        int quantity;
        int shipping_status;

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Status { get => status; set => status = value; }
        public int ScheduleID { get => scheduleID; set => scheduleID = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Shipping_status { get => shipping_status; set => shipping_status = value; }
    }
}