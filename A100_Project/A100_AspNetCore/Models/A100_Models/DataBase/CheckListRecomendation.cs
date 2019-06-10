using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class CheckListRecomendation
    {
        public int CheckListRecomendationId { get; set; }
        public byte RecomendationId { get; set; }
        public int ResoultId { get; set; }
        public byte? TransformRow { get; set; }

        public virtual Recomendation Recomendation { get; set; }
    }
}
