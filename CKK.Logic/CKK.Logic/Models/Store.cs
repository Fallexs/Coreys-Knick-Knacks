using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;

namespace CKK.Logic.Models {
    public class Store : Entity, IStore {
        private List<StoreItem> Items { get; set; } = new();
        public List<StoreItem> GetStoreItems() => Items;

        private int _intIndex = 1;

        public List<StoreItem> GetAllProductsByName(string name) {
            Regex findFirstWord = new Regex("[a-zA-Z]+");
            var matches = new List<StoreItem>();
            foreach (var item in Items) {
                if (item.Product.Name.Contains(name) && findFirstWord.IsMatch(item.Product.Name)) {
                    matches.Add(item);
                }
            }
            return matches;
        }

        public static void Swap(StoreItem first, StoreItem second) {
            var temporary = first;
            first = second;
            second = temporary;
        }

        public List<StoreItem> GetProductsByQuantity() {
            return Items.OrderByDescending(item => item.Quantity).ToList();
        }

        public List<StoreItem> GetProductsByPrice() {
            return Items.OrderByDescending(item => item.Product.Price).ToList();
        }

        public StoreItem AddStoreItem(Product prod, int quantity) {
            if (quantity <= 0) {
                throw new InventoryItemStockTooLowException();
            }
            var existing = Items.FirstOrDefault(item => item.Product == prod);
            if (existing != null) {
                existing.Quantity += quantity;
                return existing;
            }
            var newItem = new StoreItem(prod, quantity);
            if (Items.Count == 0) {
                prod.Id = 1;
            } else {
                prod.Id = ++_intIndex;
            }
            Items.Add(newItem);
            return newItem;
        }


        public StoreItem RemoveStoreItem(int id, int quantity) {
            var existing = Items.FirstOrDefault(item => item.Product.Id == id);
            if (quantity < 0) {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Invalid quantity.");
            }
            if (existing == null) {
                throw new ProductDoesNotExistException();
            }
            if (existing.Quantity - quantity < 0) {
                existing.Quantity = 0;
                return existing;
            } else {
                existing.Quantity -= quantity;
                return existing;
            }
        }

        public StoreItem FindStoreItemById(int id) {
            if ( id < 0 ) {
                throw new InvalidIdException();
            }
            var existing = Items.SingleOrDefault(product => id == product.Product.Id);
            if (existing != null) {
                return existing;
            }
            return null;
        }

        public void DeleteStoreItem(int id) {
            Items.RemoveAll(item => item.Product.Id == id);
        }
    }
}
