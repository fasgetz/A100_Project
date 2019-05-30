namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Log
    {
        public int LogID { get; set; }

        public byte PageID { get; set; }

        public string QueryString { get; set; }

        public short ShortUserID { get; set; }

        public string UserIPaddress { get; set; }

        public DateTime EventDateTime { get; set; }

        public string EventInfo { get; set; }

        public int? ResoultID { get; set; }
    }
}
