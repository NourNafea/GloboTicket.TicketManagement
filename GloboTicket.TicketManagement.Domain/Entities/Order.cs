namespace GloboTicket.TicketManagement.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int OrderTotoal { get; set; }
    public DateTime OrderPlaced { get; set; }
    public bool Orderpaid { get; set; }
    
}