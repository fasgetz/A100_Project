namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class DefectType
    {
        public DefectType()
        {
            Vik = new HashSet<Vik>();
        }

        public int DefectID { get; set; }

        public string DefectName { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
