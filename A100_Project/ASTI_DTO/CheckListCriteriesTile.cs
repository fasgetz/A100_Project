namespace ASTI_DTO
{

    public class CheckListCriteriesTile
    {
        public int CheckListCriteriesTileID { get; set; }

        public byte CheckListTileID { get; set; }

        public byte CheckListCriteriaID { get; set; }

        public virtual CheckListTile CheckListTile { get; set; }
    }
}
