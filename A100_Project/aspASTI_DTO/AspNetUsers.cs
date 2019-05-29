using System;
using System.Collections.Generic;
using System.Text;

namespace aspASTI_DTO
{
    public class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetRoles = new HashSet<AspNetRoles>();
        }

        public string Id { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public short ShortUserID { get; set; }

        public int? LicenseID { get; set; }

        public string RealUserName { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }

        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }

        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
    }
}
