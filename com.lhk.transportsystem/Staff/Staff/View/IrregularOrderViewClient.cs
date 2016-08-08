using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCommon.Transport.TransportOrder;
using Staff.Business;
using AppCommon.Transport.Order;

namespace Staff.View
{
    public class IrregularOrderViewClient : IrregularOrderView
    {
        public IrregularOrderViewClient()
        {
            _business = new IrregularOrderBusinessClient();
        }

        protected override CreateOrderView InitCreateOrderView()
        {
            return new CreateOrderViewClient();
        }
    }
}
