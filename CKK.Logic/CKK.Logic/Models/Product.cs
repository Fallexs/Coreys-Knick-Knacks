using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models {
    [Serializable]
    public class Product : Entity {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal price;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString() {
            return $"Product: {Name, -10} ID: {Id, -10} ${Price,-10} Amount:{Quantity,-10}";
        }
    }
}
