using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class PhotoType
    {
        public PhotoType()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        public byte PhotoTypeId { get; set; }
        public string PhotoTypeName { get; set; }

        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
