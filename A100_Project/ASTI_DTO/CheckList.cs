namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public partial class CheckList
    {
        public int CheckListID { get; set; }

        public int ResoultID { get; set; }

        public byte CheckListCriteriaID { get; set; }

        public byte? TransformRow { get; set; }

        public string SelectedTilesIDs { get; set; }

        public string CriteriaComment { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public virtual CheckListCriteria CheckListCriteria { get; set; }
    }
}
