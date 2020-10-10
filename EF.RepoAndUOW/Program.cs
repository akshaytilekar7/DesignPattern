using EF.Core.Data;
using EF.Data;

namespace EF.RepoAndUOW
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Test();

            // TRY ONE BY ONE

            #region  NOTransactionRepo
            t.AddRepo();
            // Address table with values        1 LA 123
            // Customer will be empty
            #endregion

            #region  TransactionHandleUOW
            t.AddWithUow();
            // Address table will be empty
            // Customer table will be empty
            #endregion

            //SELECT* FROM Address
            //SELECT* FROM Customer

            //DELETE FROM Address
            //DELETE FROM Customer
        }
    }

    class Test
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly Repository<Customer> _customerRepository = new Repository<Customer>(new EfDbContext());
        private readonly Repository<Address> _addressRepository = new Repository<Address>(new EfDbContext());
        readonly Address address = new Address() { City = "LA", Pincode = 123 };
        readonly Customer customer = new Customer() { Name = "David", AddressId = 500 };

        public void AddRepo()
        {
            _addressRepository.Insert(address); // context save is in REPO direct
            _customerRepository.Insert(customer); // context save is in REPO direct
        }

        public void AddWithUow()
        {
            _unitOfWork.Repository<Address>().Insert(address);
            _unitOfWork.Repository<Customer>().Insert(customer);

            _unitOfWork.Save();  // manually save
        }
    }
}