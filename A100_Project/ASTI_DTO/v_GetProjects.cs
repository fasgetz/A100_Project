namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetProjects
    {
        public int? WarhouseID { get; set; }

        public DateTime? ControlData { get; set; }

        public string UserKey { get; set; }

        public string WarhouseName { get; set; }

        public DateTime? ExperyDate { get; set; }

        public bool Enabled { get; set; }

        public string ProjectNumber { get; set; }

        public int? MetodID { get; set; }

        public string UserName { get; set; }

        public string ControlName { get; set; }

        public string ProjectComment { get; set; }
    }
}
