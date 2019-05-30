namespace ASTI_DTO
{

    public class CheckListRecomendation
    {
        public int CheckListRecomendationID { get; set; }

        public byte RecomendationID { get; set; }

        public int ResoultID { get; set; }

        public byte? TransformRow { get; set; }

        public virtual Recomendation Recomendation { get; set; }
    }
}
