using System;
using System.Collections.Generic;

namespace AssetManagerTest.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public int? AssetId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public Asset Asset { get; set; }
    }
}
