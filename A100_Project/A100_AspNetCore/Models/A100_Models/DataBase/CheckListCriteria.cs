using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class CheckListCriteria
    {
        public CheckListCriteria()
        {
            CheckList = new HashSet<CheckList>();
        }

        public byte CheckListCriteriaId { get; set; }
        public string CriteriaName { get; set; }
        public bool IsActual { get; set; }
        public bool IsTilesMultiSelect { get; set; }
        public byte? CriteriaOrder { get; set; }

        public virtual ICollection<CheckList> CheckList { get; set; }
    }
}
