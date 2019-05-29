namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ReportControlProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(50)]
        public string ElementValue { get; set; }

        [StringLength(80)]
        public string ControlProgramName { get; set; }

        [StringLength(250)]
        public string ControlProgramDescrption { get; set; }
    }
}
