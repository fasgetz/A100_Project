namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetSpecificationsElement_old
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentNumberElement { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }
    }
}
