using System;
using System.Collections.Generic;

namespace AssetManagerTest.Models
{
    public partial class Asset
    {
        public Asset()
        {
            Customer = new HashSet<Customer>();
        }

        public int AssetId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
