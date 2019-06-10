using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Warhouse
    {
        public Warhouse()
        {
            Control = new HashSet<Control>();
            JornalCategory = new HashSet<JornalCategory>();
            Journal = new HashSet<Journal>();
            Licenses = new HashSet<Licenses>();
            PartialTo = new HashSet<PartialTo>();
            Safety = new HashSet<Safety>();
            SafetyListCategory = new HashSet<SafetyListCategory>();
            Specifications = new HashSet<Specifications>();
            StockElements = new HashSet<StockElements>();
        }

        public int WarhouseId { get; set; }
        public int? CompanyId { get; set; }
        public string WarhouseName { get; set; }
        public int? CityId { get; set; }
        public int? Pallets { get; set; }
        public string WarhouseAddress { get; set; }

        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Control> Control { get; set; }
        public virtual ICollection<JornalCategory> JornalCategory { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
        public virtual ICollection<Licenses> Licenses { get; set; }
        public virtual ICollection<PartialTo> PartialTo { get; set; }
        public virtual ICollection<Safety> Safety { get; set; }
        public virtual ICollection<SafetyListCategory> SafetyListCategory { get; set; }
        public virtual ICollection<Specifications> Specifications { get; set; }
        public virtual ICollection<StockElements> StockElements { get; set; }
    }
}
