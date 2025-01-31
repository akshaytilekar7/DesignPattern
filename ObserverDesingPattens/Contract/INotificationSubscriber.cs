using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesingPattens.Contract;

public interface INotificationSubscriber
{
    void Update(string message);
}
