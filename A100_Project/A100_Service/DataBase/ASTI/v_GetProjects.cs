namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class v_GetProjects
    {
        [DataMember]
        public int? WarhouseID { get; set; }

        [DataMember]
        public DateTime? ControlData { get; set; }

        [DataMember]
        [StringLength(250)]
        public string UserKey { get; set; }

        [DataMember]
        [StringLength(150)]
        public string WarhouseName { get; set; }

        [DataMember]
        public DateTime? ExperyDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        [StringLength(100)]
        public string ProjectNumber { get; set; }

        [DataMember]
        public int? MetodID { get; set; }

        [DataMember]
        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string UserName { get; set; }

        [DataMember]
        [StringLength(300)]
        public string ControlName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string ProjectComment { get; set; }
    }
}
