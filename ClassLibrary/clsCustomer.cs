using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}