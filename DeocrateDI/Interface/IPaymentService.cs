using Microsoft.Extensions.Logging;

namespace DeocrateDI.Interface;

public interface IPaymentService
{
    int GetById(int id);
}
