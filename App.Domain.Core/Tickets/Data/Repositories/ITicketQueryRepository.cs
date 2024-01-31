using App.Domain.Core.Tickets.DTOs;
using App.Domain.Core.Tickets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Data.Repositories
{
    public interface ITicketQueryRepository
    {
        public Task<List<TicketDto>> GetTickets(int id,CancellationToken cancellationToken);
        public Task<List<TicketDto>> GetTickets(int id, List<StateEnum> states, CancellationToken cancellationToken);
        public Task<List<TicketDto>> GetTickets(StateEnum state, CancellationToken cancellationToken);
    }
}
