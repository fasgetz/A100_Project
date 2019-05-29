namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Warehouses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }
    }
}
