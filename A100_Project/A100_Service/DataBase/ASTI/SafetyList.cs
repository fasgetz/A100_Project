namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SafetyList")]
    public partial class SafetyList
    {
        public int SafetyListID { get; set; }

        public int SafetyID { get; set; }

        public int SafetyListCriteriaID { get; set; }

        public byte? Status { get; set; }

        public string Comment { get; set; }

        public virtual SafetyListCriteria SafetyListCriteria { get; set; }
    }
}
