namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportPhotomaterial
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string PhotoTypeName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotomaterialID { get; set; }

        [StringLength(260)]
        public string FinalCaption { get; set; }

        public int? BasicCheckListID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte PhotoTypeID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte[] Photo { get; set; }
    }
}
