namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class CheckListCriteria
    {
        public CheckListCriteria()
        {
            CheckList = new HashSet<CheckList>();
        }

        public byte CheckListCriteriaID { get; set; }

        public string CriteriaName { get; set; }

        public bool IsActual { get; set; }

        public bool IsTilesMultiSelect { get; set; }

        public byte? CriteriaOrder { get; set; }

        public virtual ICollection<CheckList> CheckList { get; set; }
    }
}
