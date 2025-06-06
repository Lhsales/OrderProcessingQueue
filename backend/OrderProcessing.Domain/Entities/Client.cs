namespace OrderProcessing.Domain.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
    }
}