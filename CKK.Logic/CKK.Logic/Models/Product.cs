using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models {
    [Serializable]
    public class Product : Entity {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString() {
            return string.Format(
            "{0,-20} {1,0:C} {2,20}",
            "Item: " + Name,
            Price,
            "Amount: " + Quantity
            );
        }
    }
}
