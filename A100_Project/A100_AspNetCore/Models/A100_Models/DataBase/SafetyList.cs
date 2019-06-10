using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class SafetyList
    {
        public int SafetyListId { get; set; }
        public int SafetyId { get; set; }
        public int SafetyListCriteriaId { get; set; }
        public byte? Status { get; set; }
        public string Comment { get; set; }

        public virtual SafetyListCriteria SafetyListCriteria { get; set; }
    }
}
