using System.Collections.Generic;

namespace ASTI_DTO
{

    public class CheckListTile
    {
        public CheckListTile()
        {
            CheckListCriteriesTile = new HashSet<CheckListCriteriesTile>();
        }

        public byte CheckListTileID { get; set; }


        public string CheckListTileName { get; set; }

        public virtual ICollection<CheckListCriteriesTile> CheckListCriteriesTile { get; set; }
    }
}
