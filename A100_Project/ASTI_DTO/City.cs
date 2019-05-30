using System;
using System.Collections.Generic;
using System.Text;

namespace ASTI_DTO
{

    [Serializable]
    public class City
    {

        public City()
        {

        }

        public int CityID { get; set; }

        public string CityName { get; set; }
    }
}
