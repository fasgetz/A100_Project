using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Element
    {
        public Element()
        {
            SpecificationsElement = new HashSet<SpecificationsElement>();
        }

        public int ElementId { get; set; }
        public string ElementName { get; set; }
        public string Format { get; set; }

        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
    }
}
