namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_SpecificationsElementSize
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        public int? WarhouseID { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        [StringLength(100)]
        public string ElementName { get; set; }
    }
}
