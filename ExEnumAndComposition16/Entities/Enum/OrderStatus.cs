using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumAndComposition16.Entities.Enum
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shpped = 2,
        Delivered = 3,
    }
}
