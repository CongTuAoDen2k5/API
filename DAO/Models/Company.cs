using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Company
    {
        public Company()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string Village { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAuthorizedCompany { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
