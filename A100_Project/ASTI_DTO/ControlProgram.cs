namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class ControlProgram
    {
        public int ControlProgramID { get; set; }

        public int ControlProgramElementID { get; set; }

        public string ElementValue { get; set; }

        public int ControlID { get; set; }

        public virtual Control Control { get; set; }

        public virtual ControlProgramElement ControlProgramElement { get; set; }
    }
}
