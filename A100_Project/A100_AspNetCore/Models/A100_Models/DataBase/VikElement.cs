using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class VikElement
    {
        public VikElement()
        {
            Vik = new HashSet<Vik>();
        }

        public int StructuralMemberId { get; set; }
        public string StructuralMemberName { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
