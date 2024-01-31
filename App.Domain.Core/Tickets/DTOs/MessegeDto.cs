namespace App.Domain.Core.Tickets.DTOs
{
    public class MessegeDto
    {
        public required int Id { get; set; }
        public required string Text { get; set; }
        public required int TicketId { get; set; }
        public required DateTime Time { get; set; }
        public List<int>? AttachesId { get; set; }
        public int? ExpertUserId { get; set; }
    }
}
