namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Control
    {
        public Control()
        {
            Resoult = new HashSet<Resoult>();
            ControlEmployees = new HashSet<ControlEmployees>();
            ControlProgram = new HashSet<ControlProgram>();
        }

        public int ControlID { get; set; }

        public int? WarhouseID { get; set; }

        public int? MetodID { get; set; }

        public DateTime? ControlData { get; set; }

        public int? EmployeeID { get; set; }

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

        public int? ParentRID { get; set; }

        public int? ReportDirector { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ControlMetod ControlMetod { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        public virtual ICollection<Resoult> Resoult { get; set; }

        public virtual ICollection<ControlEmployees> ControlEmployees { get; set; }

        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
    }
}
