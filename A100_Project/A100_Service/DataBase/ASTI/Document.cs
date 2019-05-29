namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        public int DocumentID { get; set; }

        [Required]
        [StringLength(128)]
        public string DocumentName { get; set; }

        [Required]
        [StringLength(256)]
        public string DocumentPath { get; set; }

        public int ResoultID { get; set; }
    }
}
