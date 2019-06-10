using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class CheckListCriteriesTile
    {
        public int CheckListCriteriesTileId { get; set; }
        public byte CheckListTileId { get; set; }
        public byte CheckListCriteriaId { get; set; }

        public virtual CheckListTile CheckListTile { get; set; }
    }
}
