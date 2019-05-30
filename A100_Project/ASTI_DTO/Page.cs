namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Page
    {
        public byte PageID { get; set; }

        public string PageAddress { get; set; }

        public string PageName { get; set; }

        public byte? ObjectType { get; set; }
    }
}
