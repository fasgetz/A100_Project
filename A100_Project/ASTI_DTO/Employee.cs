namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public Employee()
        {
            Control = new HashSet<Control>();
            Support = new HashSet<Support>();
            ExpertCommission = new HashSet<ExpertCommission>();
        }

        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string UserKey { get; set; }

        public byte? PersonnelNumber { get; set; }

        public bool? isClient { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<Control> Control { get; set; }

        public virtual ICollection<Support> Support { get; set; }

        public virtual ICollection<ExpertCommission> ExpertCommission { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }
    }
}
