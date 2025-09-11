using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using System.Reflection.Metadata.Ecma335;


namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
    }
}