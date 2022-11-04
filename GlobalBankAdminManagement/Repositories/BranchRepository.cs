using GlobalBankAdminManagement.Models;

namespace GlobalBankAdminManagement.Repositories
{
    public class BranchRepository
    {
        private readonly GlobalBankingAdminContext _context;
        public BranchRepository()
        {
            _context = new GlobalBankingAdminContext();
        }
        public void RegisterBranch(GlobalBankBranch branch)
        {
            try
            {
                _context.GlobalBankBranches.Add(branch);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteBranch(string branchId)
        {
            try
            {
                var branch = _context.GlobalBankBranches.Single(c => c.BranchId == branchId);
                _context.GlobalBankBranches.Remove(branch);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
