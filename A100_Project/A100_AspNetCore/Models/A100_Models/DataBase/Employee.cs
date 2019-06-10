using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Employee
    {
        public Employee()
        {
            Control = new HashSet<Control>();
            ExpertCommission = new HashSet<ExpertCommission>();
            Support = new HashSet<Support>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public byte? PersonnelNumber { get; set; }
        public bool? IsClient { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Control> Control { get; set; }
        public virtual ICollection<ExpertCommission> ExpertCommission { get; set; }
        public virtual ICollection<Support> Support { get; set; }
    }
}
