namespace CrossCuttingLayer
{
    public class OrderMessage
    {
        public int? Id { get; set; }

        public double? Cost { get; set; }

        public string Username { get; set; }

        public int? ProductId { get; set; }

        public CrossFunction? Function { get; set; }
    }
}
