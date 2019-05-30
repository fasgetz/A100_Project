namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;
    public class PhotoType
    {
        public PhotoType()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        public byte PhotoTypeID { get; set; }

        public string PhotoTypeName { get; set; }

        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
