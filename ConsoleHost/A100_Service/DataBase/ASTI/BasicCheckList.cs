namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BasicCheckList")]
    public partial class BasicCheckList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasicCheckList()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        public int BasicCheckListID { get; set; }

        public int BasicDamageID { get; set; }

        public int SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public int? TransformRow { get; set; }

        public byte[] Photo { get; set; }

        public virtual BasicDamage BasicDamage { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
