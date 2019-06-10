using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Safety
    {
        public int SafetyId { get; set; }
        public DateTime Date { get; set; }
        public int WarhouseId { get; set; }
        public string InspectedBy { get; set; }
        public string ResponsiblePerson { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
