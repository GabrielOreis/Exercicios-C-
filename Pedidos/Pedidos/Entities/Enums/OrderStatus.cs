using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDINGPAYMENT =  0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
