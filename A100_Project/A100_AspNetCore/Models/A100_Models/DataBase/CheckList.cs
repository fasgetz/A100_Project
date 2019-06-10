using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class CheckList
    {
        public int CheckListId { get; set; }
        public int ResoultId { get; set; }
        public byte CheckListCriteriaId { get; set; }
        public byte? TransformRow { get; set; }
        public string SelectedTilesIds { get; set; }
        public string CriteriaComment { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual CheckListCriteria CheckListCriteria { get; set; }
    }
}
