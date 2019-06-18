using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.ASP_Identity
{
    public partial class RefreshTokens
    {
        public int TokenId { get; set; }
        public string TokenAcess { get; set; }
        public string TokenRefresh { get; set; }
        public string IdUser { get; set; }
        public DateTime DateLifeEnd { get; set; }
        public DateTime DateLifeStart { get; set; }
        public bool IsActive { get; set; }

    }
}
