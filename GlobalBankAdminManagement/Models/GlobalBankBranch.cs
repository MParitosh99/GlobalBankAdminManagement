using System;
using System.Collections.Generic;

namespace GlobalBankAdminManagement.Models
{
    public partial class GlobalBankBranch
    {
        public string BranchId { get; set; } = null!;
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
    }
}
