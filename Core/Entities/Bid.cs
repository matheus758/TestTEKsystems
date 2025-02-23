namespace Core.Entities
{
    public class Bid
    {
        public int Id { get; set; }

        public Decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

    }
}
