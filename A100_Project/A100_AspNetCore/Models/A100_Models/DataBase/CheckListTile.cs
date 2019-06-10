using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class CheckListTile
    {
        public CheckListTile()
        {
            CheckListCriteriesTile = new HashSet<CheckListCriteriesTile>();
        }

        public byte CheckListTileId { get; set; }
        public string CheckListTileName { get; set; }

        public virtual ICollection<CheckListCriteriesTile> CheckListCriteriesTile { get; set; }
    }
}
