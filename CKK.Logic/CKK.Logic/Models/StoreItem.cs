using CKK.Logic.Interfaces;

namespace CKK.Logic.Models {
    [Serializable]
    public class StoreItem : InventoryItem {
        public StoreItem(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
        }

        public StoreItem() { }

        public override string ToString() {
            return $"ID: {Product.Id}   Name: {Product.Name}    Price: {Product.Price:C}    Quantity:{Quantity}";
        }
    }
}
