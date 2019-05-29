namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportCheckList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(90)]
        public string CriteriaName { get; set; }

        [StringLength(20)]
        public string SelectedTilesIDs { get; set; }

        public string CriteriaComment { get; set; }
    }
}
