

namespace App.Domain.Core.Tickets.Entities
{
    public class Messege
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime Time { get; set; }
        public List<Attache> Attaches { get; set; }
        public Users.Entitis.User? ExpertUser { get; set; }
    }
}
