using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Connection
    {
        public int ConnetionKey { get; set; }
        public int? Wkey { get; set; }
        public string UserKey { get; set; }
        public bool? Enabled { get; set; }
        public DateTime? ExperyDate { get; set; }
    }
}
