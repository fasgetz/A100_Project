using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ControlProgram
    {
        public int ControlProgramId { get; set; }
        public int ControlProgramElementId { get; set; }
        public string ElementValue { get; set; }
        public int ControlId { get; set; }

        public virtual Control Control { get; set; }
        public virtual ControlProgramElement ControlProgramElement { get; set; }
    }
}
