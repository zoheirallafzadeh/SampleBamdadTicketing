namespace App.Domain.Core.Tickets.DTOs
{
    public class MessegeDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int TicketId { get; set; }
        public DateTime Time { get; set; }
        public List<int> AttachesId { get; set; }
        public int ExpertUserId { get; set; }
    }
}
