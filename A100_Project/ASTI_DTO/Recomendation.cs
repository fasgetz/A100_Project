namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Recomendation
    {
        public Recomendation()
        {
            CheckListRecomendation = new HashSet<CheckListRecomendation>();
        }

        public byte RecomendationID { get; set; }

        public string RecomendationName { get; set; }

        public bool IsActual { get; set; }

        public bool? IsGOST { get; set; }

        public byte? RecomendationOrder { get; set; }

        public virtual ICollection<CheckListRecomendation> CheckListRecomendation { get; set; }
    }
}
