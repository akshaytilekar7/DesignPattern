using EF.Core.Data;
using EF.Data;
using System.Text;

namespace EF.RepoAndUOW
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public string Test(string s)
        {
            int[] arr = new int[] { 1, 5, 7 };
            StringBuilder newText = new StringBuilder(s);

            foreach (var item in arr)
            {
                if (item < arr.Length)
                {
                    // exist
                    newText.Append(" ");
                }
            }

            return newText.ToString();
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
            _addressRepository.Insert(address); // context save line is in REPO direct
            _customerRepository.Insert(customer); // context save is line in REPO direct
        }

        public void AddWithUow()
        {
            _unitOfWork.GetRepository<Address>().Insert(address);
            _unitOfWork.GetRepository<Customer>().Insert(customer);

            _unitOfWork.Save();  // context save manually here
        }
    }
}