using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class SafetyListCriteria
    {
        public SafetyListCriteria()
        {
            SafetyList = new HashSet<SafetyList>();
        }

        public int SafetyListCriteriaId { get; set; }
        public int SafetyListCategoryId { get; set; }
        public string CriteriaName { get; set; }
        public byte? IsCriteria { get; set; }
        public byte? CriteriaOrder { get; set; }

        public virtual SafetyListCategory SafetyListCategory { get; set; }
        public virtual ICollection<SafetyList> SafetyList { get; set; }
    }
}
