namespace ASTI_DTO
{
    using System;

    public class v_LogEvents
    {

        public int LogID { get; set; }

        public string Expr1 { get; set; }

        public string UserIPaddress { get; set; }

        public DateTime EventDateTime { get; set; }

        public string EventInfo { get; set; }

        public string QueryString { get; set; }

        public string PageName { get; set; }

        public int? ResoultID { get; set; }

        public string CompanyName { get; set; }

        public string WarhouseName { get; set; }

        public int? WarhouseID { get; set; }
    }
}
