namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class SafetyListCriteria
    {
        public SafetyListCriteria()
        {
            SafetyList = new HashSet<SafetyList>();
        }

        public int SafetyListCriteriaID { get; set; }

        public int SafetyListCategoryID { get; set; }

        public string CriteriaName { get; set; }

        public byte? IsCriteria { get; set; }

        public byte? CriteriaOrder { get; set; }

        public virtual ICollection<SafetyList> SafetyList { get; set; }

        public virtual SafetyListCategory SafetyListCategory { get; set; }
    }
}
