namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class ControlProgramElement
    {
        public ControlProgramElement()
        {
            ControlProgram = new HashSet<ControlProgram>();
        }

        public int ControlProgramElementID { get; set; }

        public string ControlProgramName { get; set; }

        public string ControlProgramDescrption { get; set; }

        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
    }
}
