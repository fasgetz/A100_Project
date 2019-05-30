namespace ASTI_DTO
{
    using System;

    public partial class Connection
    {
        public int ConnetionKey { get; set; }

        public int? WKey { get; set; }

        public string UserKey { get; set; }

        public bool Enabled { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
