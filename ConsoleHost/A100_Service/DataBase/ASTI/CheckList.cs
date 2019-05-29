namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckList")]
    public partial class CheckList
    {
        public int CheckListID { get; set; }

        public int ResoultID { get; set; }

        public byte CheckListCriteriaID { get; set; }

        public byte? TransformRow { get; set; }

        [StringLength(20)]
        public string SelectedTilesIDs { get; set; }

        public string CriteriaComment { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public virtual CheckListCriteria CheckListCriteria { get; set; }
    }
}
