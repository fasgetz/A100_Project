namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StillageTest")]
    public partial class StillageTest
    {
        public int StillageTestID { get; set; }

        public int ResoultID { get; set; }

        public int SpecificationsID { get; set; }

        public int MapID { get; set; }

        public int StoikaElementID { get; set; }

        public int LoadElementID { get; set; }

        public int FrameElementID { get; set; }

        [StringLength(20)]
        public string Row { get; set; }

        [StringLength(12)]
        public string Frame { get; set; }

        public byte? levelCount { get; set; }

        public DateTime? StillageTestDate { get; set; }

        public byte ProtokolNumber { get; set; }

        public bool isLoaded { get; set; }

        public int? MaxPassportLoad { get; set; }

        public int? UsualLoad { get; set; }

        public int? TestLoad { get; set; }

        public double? FuprFact { get; set; }

        public double? FostFast { get; set; }

        public double? DevLoadFact { get; set; }

        public double? F1fact { get; set; }

        public double? FkFact { get; set; }

        public int EmployeeID { get; set; }

        public int? TransformRow { get; set; }

        public DateTime? UpdateTime { get; set; }

        public virtual Map Map { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }

        public virtual SpecificationsElement SpecificationsElement { get; set; }

        public virtual SpecificationsElement SpecificationsElement1 { get; set; }

        public virtual SpecificationsElement SpecificationsElement2 { get; set; }
    }
}
