using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ControlProgramElement
    {
        public ControlProgramElement()
        {
            ControlProgram = new HashSet<ControlProgram>();
        }

        public int ControlProgramElementId { get; set; }
        public string ControlProgramName { get; set; }
        public string ControlProgramDescrption { get; set; }

        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
    }
}
