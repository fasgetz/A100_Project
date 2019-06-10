using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Log
    {
        public int LogId { get; set; }
        public byte PageId { get; set; }
        public string QueryString { get; set; }
        public short ShortUserId { get; set; }
        public string UserIpaddress { get; set; }
        public DateTime EventDateTime { get; set; }
        public string EventInfo { get; set; }
        public int? ResoultId { get; set; }
    }
}
