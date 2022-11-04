using System;
using System.Collections.Generic;

namespace GlobalBankAdminManagement.Models
{
    public partial class Customer
    {
        public string AccountNo { get; set; } = null!;
        public int CustomerNo { get; set; }
        public string BranchId { get; set; } = null!;
        public double? Balance { get; set; }
        public DateTime? OpeningDate { get; set; }
    }
}
