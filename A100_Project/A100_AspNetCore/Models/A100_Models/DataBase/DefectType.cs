using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class DefectType
    {
        public DefectType()
        {
            Vik = new HashSet<Vik>();
        }

        public int DefectId { get; set; }
        public string DefectName { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
