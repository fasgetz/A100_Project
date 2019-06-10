using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Page
    {
        public byte PageId { get; set; }
        public string PageAddress { get; set; }
        public string PageName { get; set; }
        public byte? ObjectType { get; set; }
    }
}
