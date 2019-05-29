namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recomendation")]
    public partial class Recomendation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recomendation()
        {
            CheckListRecomendation = new HashSet<CheckListRecomendation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RecomendationID { get; set; }

        [Required]
        [StringLength(300)]
        public string RecomendationName { get; set; }

        public bool IsActual { get; set; }

        public bool? IsGOST { get; set; }

        public byte? RecomendationOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckListRecomendation> CheckListRecomendation { get; set; }
    }
}
