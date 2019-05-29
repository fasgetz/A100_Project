namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetSpecificationsElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        public decimal? eB { get; set; }

        public decimal? eL { get; set; }

        public decimal? erb { get; set; }

        public decimal? eA { get; set; }

        public decimal? eC { get; set; }

        public decimal? era { get; set; }

        public int? barType { get; set; }

        [StringLength(50)]
        public string barName { get; set; }

        public decimal? fE { get; set; }

        public decimal? fD { get; set; }

        public int? fLevelCount { get; set; }

        public int? fLevelDistanceMax { get; set; }

        public int? fНLevelLowerMax { get; set; }

        public int? fHLevelLowerMin { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
