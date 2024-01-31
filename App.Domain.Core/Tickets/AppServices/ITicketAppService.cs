using App.Domain.Core.Tickets.DTOs;
using App.Domain.Core.Tickets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.AppServices
{
    public interface ITicketAppService
    {
        public Task Add(MessegeDto Unit, CancellationToken cancellationToken);
        public Task Delete(int MessegeId, CancellationToken cancellationToken);
        public Task Update(MessegeDto Unit, CancellationToken cancellationToken);

        public Task<List<TicketDto>?> GetTickets(int id, CancellationToken cancellationToken);
        public Task<List<TicketDto>?> GetTickets(int id, List<StateEnum> states, CancellationToken cancellationToken);
        public Task<List<TicketDto>?> GetTickets(StateEnum state, CancellationToken cancellationToken);
    }
}
