using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class SafetyListCategory
    {
        public SafetyListCategory()
        {
            SafetyListCriteria = new HashSet<SafetyListCriteria>();
        }

        public int SafetyListCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int WarhouseId { get; set; }
        public int? CategoryOrder { get; set; }

        public virtual Warhouse Warhouse { get; set; }
        public virtual ICollection<SafetyListCriteria> SafetyListCriteria { get; set; }
    }
}
