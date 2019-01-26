using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerManagementSystem
{
    public class CountryModel
    {
        int id;
        int continentId;
        string name;

        public int Id { get => id; set => id = value; }
        public int ContinentId { get => continentId; set => continentId = value; }
        public string Name { get => name; set => name = value; }
    }
}