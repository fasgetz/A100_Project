namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;


    public class ControlMetod
        public ControlMetod()
        {
            Control = new HashSet<Control>();
        }

        public int MetodID { get; set; }

        public string InspectionMetod { get; set; }

        public virtual ICollection<Control> Control { get; set; }
    }
}
