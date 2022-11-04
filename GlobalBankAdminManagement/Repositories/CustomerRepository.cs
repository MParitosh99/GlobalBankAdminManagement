using GlobalBankAdminManagement.Models;

namespace GlobalBankAdminManagement.Repositories
{
    public class CustomerRepository
    {
        private readonly GlobalBankingAdminContext _context;
        public CustomerRepository()
        {
            _context = new GlobalBankingAdminContext();
        }
        public void OpenCustomerAccount( Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CloseCustomerAccount(string accountNo)
        {
            try
            {
                var customer=_context.Customers.Single(c => c.AccountNo == accountNo);  
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Customer> GetAllCustomers()
        {
            try
            {
                return _context.Customers.ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }       




    }
}
