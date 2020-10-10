using System;
using zFactoryPatternModified.Actions;

namespace zFactoryPatternModified.Factory
{
    [Serializable]
    public class ActionFactory : IActionFactory
    {

        private readonly IAddressAction _addressAction;
        private readonly ISalesAction _salesAction;
        private readonly IApplicationAction _applicationAction;
        private readonly IEmployeeAction _employeeAction;


        public IAddressAction AddressAction
        {
            get
            {
                if (_addressAction == null)
                    return new AddressAction(this);
                return _addressAction;
            }
        }

        public ISalesAction SalesAction
        {
            get
            {
                if (_salesAction == null)
                    return new SalesAction(this);
                return _salesAction;
            }
        }
        public IApplicationAction ApplicationAction
        {
            get
            {
                if (_applicationAction == null)
                    return new ApplicationAction(this);
                return _applicationAction;
            }
        }
        public IEmployeeAction EmployeeAction
        {
            get
            {
                if (_employeeAction == null)
                    return new EmployeeAction(this);
                return _employeeAction;
            }
        }
    }
}
