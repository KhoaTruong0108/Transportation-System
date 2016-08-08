using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon.Transport.Order;
using Staff.Business;

namespace Staff.View
{
    public class CreateOrderViewClient : CreateOrderView
    {
        public CreateOrderViewClient()
        {
            _irregularBusiness = new IrregularOrderBusinessClient();
            _regularBusiness = new RegularOrderBusinessClient();
        }
    }
}
