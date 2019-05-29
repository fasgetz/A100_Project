namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckListRecomendation")]
    public partial class CheckListRecomendation
    {
        public int CheckListRecomendationID { get; set; }

        public byte RecomendationID { get; set; }

        public int ResoultID { get; set; }

        public byte? TransformRow { get; set; }

        public virtual Recomendation Recomendation { get; set; }
    }
}
