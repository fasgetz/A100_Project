using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ControlMetod
    {
        public ControlMetod()
        {
            Control = new HashSet<Control>();
        }

        public int MetodId { get; set; }
        public string InspectionMetod { get; set; }

        public virtual ICollection<Control> Control { get; set; }
    }
}
