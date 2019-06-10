using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class PartialTo
    {
        public PartialTo()
        {
            Vik = new HashSet<Vik>();
        }

        public int PartialToid { get; set; }
        public DateTime PartialTodate { get; set; }
        public int WarhouseId { get; set; }
        public string EmployeeName { get; set; }
        public bool? TransformRow { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int ResoultId { get; set; }

        public virtual Resoult Resoult { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
