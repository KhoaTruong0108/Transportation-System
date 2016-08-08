using AppCommon.CommonBusiness;
using DBManagement;

namespace AppCommon.Business
{
    public class CustomerBusiness : GenericBusiness<Customer>
    {
        public CustomerBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }
    }
}
