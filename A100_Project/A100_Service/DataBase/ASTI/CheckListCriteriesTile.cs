namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckListCriteriesTile")]
    public partial class CheckListCriteriesTile
    {
        public int CheckListCriteriesTileID { get; set; }

        public byte CheckListTileID { get; set; }

        public byte CheckListCriteriaID { get; set; }

        public virtual CheckListTile CheckListTile { get; set; }
    }
}
