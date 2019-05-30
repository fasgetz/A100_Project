namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class RiskLevel
    {
        public RiskLevel()
        {
            Vik = new HashSet<Vik>();
        }

        public int RiskLevelID { get; set; }

        public string RiscLevelName { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
