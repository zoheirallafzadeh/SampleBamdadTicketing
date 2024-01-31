using App.Domain.Core.Users.Entitis;

namespace App.Domain.Core.Tickets.Entities
{
    public class Messege
    {
        public required int Id { get; set; }
        public required string Text { get; set; }
        public required Ticket Ticket { get; set; }
        public required DateTime Time { get; set; }
        public List<Attache>? Attaches { get; set; }
        public User? ExpertUser { get; set; }
    }
}
