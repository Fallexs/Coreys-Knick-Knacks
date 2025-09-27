using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces {
    public interface IShoppingCartRepository {
        ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int Quantity);
        int ClearCart(int ShoppingCartId);
        decimal GetTotal(int ShoppingCartId);
        List<ShoppingCartItem> GetProducts(int ShoppingCartId);
        void Ordered(int ShoppingCartId);
        int Update(ShoppingCartItem entity);
        int Add(ShoppingCartItem entity);
    }
}
