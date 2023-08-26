using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftQRDataAccess.Identity
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Deleted { get; set; }
        public int Gender { get; set; }
        public int CountryID { get; set; }
        public int ClientID { get; set; }
    }

    public class Role : IdentityRole<int> { }
}
