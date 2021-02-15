namespace ClassLibrary
{
    //order class and properties
    public class clsOrder
    {
        public string OrderId { get; set; }
        public string ShippingMethod { get; set; }
        public System.DateTime DateOrdered { get; set; }
        public Boolean Dispatched {get; set; }
    }
}