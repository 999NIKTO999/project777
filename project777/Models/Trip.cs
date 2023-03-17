using System;
using System.Collections.Generic;
using System.Text;

namespace project777.Models
{
    public class Trip
    {

        public int Id { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CityId { get; set; }

    }
}
