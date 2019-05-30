namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class SafetyListCategory
    {
        public SafetyListCategory()
        {
            SafetyListCriteria = new HashSet<SafetyListCriteria>();
        }

        public int SafetyListCategoryID { get; set; }

        public string CategoryName { get; set; }

        public int WarhouseID { get; set; }

        public int? CategoryOrder { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        public virtual ICollection<SafetyListCriteria> SafetyListCriteria { get; set; }
    }
}
