using App.Domain.Core.Tickets.DTOs;
using App.Domain.Core.Units.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Data.Repositories
{
    public interface ITicketCommandRepository
    {
        public Task Add(MessegeDto Unit, CancellationToken cancellationToken);
        public Task Delete(int MessegeId, CancellationToken cancellationToken);
        public Task Update(MessegeDto Unit, CancellationToken cancellationToken);
    }
}
