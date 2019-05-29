namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlProgram")]
    public partial class ControlProgram
    {
        public int ControlProgramID { get; set; }

        public int ControlProgramElementID { get; set; }

        [StringLength(50)]
        public string ElementValue { get; set; }

        public int ControlID { get; set; }

        public virtual Control Control { get; set; }

        public virtual ControlProgramElement ControlProgramElement { get; set; }
    }
}
