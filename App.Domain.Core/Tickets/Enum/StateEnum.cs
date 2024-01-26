using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Enum
{
    public enum StateEnum
    {
        ExpertWaiting,
        ExpertPending,
        CustomerWaiting,
        CustomerPending,
        ClosedByCustomer,
        ClosedByExport

    }
}
