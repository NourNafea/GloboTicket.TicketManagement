using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities;

public class Order : AuditableEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int OrderTotoal { get; set; }
    public DateTime OrderPlaced { get; set; }
    public bool Orderpaid { get; set; }
    
}