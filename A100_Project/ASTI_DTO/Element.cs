namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Element
    {
        public Element()
        {
            SpecificationsElement = new HashSet<SpecificationsElement>();
        }

        public int ElementID { get; set; }

        public string ElementName { get; set; }

        public string Format { get; set; }

        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
    }
}
