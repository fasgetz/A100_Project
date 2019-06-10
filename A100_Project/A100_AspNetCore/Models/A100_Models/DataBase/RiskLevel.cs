using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class RiskLevel
    {
        public RiskLevel()
        {
            Vik = new HashSet<Vik>();
        }

        public int RiskLevelId { get; set; }
        public string RiscLevelName { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
