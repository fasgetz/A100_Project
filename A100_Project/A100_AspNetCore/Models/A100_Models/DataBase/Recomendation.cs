using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Recomendation
    {
        public Recomendation()
        {
            CheckListRecomendation = new HashSet<CheckListRecomendation>();
        }

        public byte RecomendationId { get; set; }
        public string RecomendationName { get; set; }
        public bool IsActual { get; set; }
        public bool? IsGost { get; set; }
        public byte? RecomendationOrder { get; set; }

        public virtual ICollection<CheckListRecomendation> CheckListRecomendation { get; set; }
    }
}
