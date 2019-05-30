namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class SafetyList
    {
        public int SafetyListID { get; set; }

        public int SafetyID { get; set; }

        public int SafetyListCriteriaID { get; set; }

        public byte? Status { get; set; }

        public string Comment { get; set; }

        public virtual SafetyListCriteria SafetyListCriteria { get; set; }
    }
}
