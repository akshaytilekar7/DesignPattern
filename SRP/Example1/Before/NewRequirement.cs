using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example1.Before;

public class OrderProcessor2
{
    public void ProcessOrder2(Order order)
    {
        // Validate order
        if (order.IsValid)
        {
            SaveOrder(order);
            SendEmailWithNewTemplate(order); // <-- New method added
        }
    }

    private void SaveOrder(Order order) { /* Database logic */ }
    private void SendEmail(Order order) { /* Old email logic */ }
    private void SendEmailWithNewTemplate(Order order) { /* New email logic */ } // <-- Added new method
}