using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Control
    {
        public Control()
        {
            ControlEmployees = new HashSet<ControlEmployees>();
            ControlProgram = new HashSet<ControlProgram>();
            Resoult = new HashSet<Resoult>();
        }

        public int ControlId { get; set; }
        public int? WarhouseId { get; set; }
        public int? MetodId { get; set; }
        public DateTime? ControlData { get; set; }
        public int? EmployeeId { get; set; }
        public int? SecondEmployee { get; set; }
        public string ProjectNumber { get; set; }
        public string EmployeesList { get; set; }
        public string Foundation { get; set; }
        public string ContactPersonData { get; set; }
        public string ClientDocuments { get; set; }
        public DateTime? ControlEndData { get; set; }
        public string DirectiveNumber { get; set; }
        public string ControlName { get; set; }
        public string ProjectComment { get; set; }
        public string ParentProjectNumber { get; set; }
        public int? ParentRid { get; set; }
        public int? ReportDirector { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ControlMetod Metod { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        public virtual ICollection<ControlEmployees> ControlEmployees { get; set; }
        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
        public virtual ICollection<Resoult> Resoult { get; set; }
    }
}
