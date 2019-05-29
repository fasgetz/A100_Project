namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckListTile")]
    public partial class CheckListTile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckListTile()
        {
            CheckListCriteriesTile = new HashSet<CheckListCriteriesTile>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CheckListTileID { get; set; }

        [Required]
        [StringLength(60)]
        public string CheckListTileName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckListCriteriesTile> CheckListCriteriesTile { get; set; }
    }
}
