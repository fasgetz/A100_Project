namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;
    public partial class PartialTO
    {
        public PartialTO()
        {
            Vik = new HashSet<Vik>();
        }

        public int PartialTOID { get; set; }

        public DateTime PartialTODate { get; set; }

        public int WarhouseID { get; set; }

        public string EmployeeName { get; set; }

        public bool? TransformRow { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int ResoultID { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
