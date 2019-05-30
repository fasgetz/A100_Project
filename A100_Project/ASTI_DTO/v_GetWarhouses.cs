namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetWarhouses
    {
        public string WarhouseName { get; set; }

        public int? WKey { get; set; }

        public string UserKey { get; set; }

        public bool Enabled { get; set; }

        public string UserName { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
