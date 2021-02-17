namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
    }
}