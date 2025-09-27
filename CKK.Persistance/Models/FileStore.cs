/*using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CKK.Persistance.Models {
    public class FileStore : ISavable, ILoadable, IStore {
        public readonly string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            Path.DirectorySeparatorChar + "Persistance" + Path.DirectorySeparatorChar + "StoreItems.dat";
        public FileStore() {
            CreatePath();
        }

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

        public void CreatePath() {
            var persistancePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                Path.DirectorySeparatorChar + "Persistance";
            if (!Directory.Exists(persistancePath)) {
                Directory.CreateDirectory(persistancePath);
            }
            return;
        }

        private List<StoreItem> Items { get; set; } = new();
        public List<StoreItem> GetStoreItems() => Items;

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
                prod.Id = Items.Count + 1;
            }
            Items.Add(newItem);
            return newItem;
        }

        public List<StoreItem> GetProductsByQuantity() {
            return Items.OrderByDescending(item => item.Quantity).ToList();
        }

        public List<StoreItem> GetProductsByPrice() {
            return Items.OrderByDescending(item => item.Product.Price).ToList();
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
            if (id < 0) {
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
#pragma warning disable SYSLIB0011
        public void Save() {
            BinaryFormatter binaryFormatter = new();
            FileStream output;

            using (output = new FileStream(FilePath, FileMode.Create, FileAccess.Write)) {
                binaryFormatter.Serialize(output, Items);
            }
        }

        public void Load() {
            if (!File.Exists(FilePath)) {
                Items = new List<StoreItem>();
                return;
            }

            BinaryFormatter binaryFormatter = new();
            FileStream input;

            using (input = new FileStream(FilePath, FileMode.Open, FileAccess.Read)) {
                Items = (List<StoreItem>)binaryFormatter.Deserialize(input);
            }
        }

    }
}
*/