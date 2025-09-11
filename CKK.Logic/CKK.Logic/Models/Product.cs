using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models {
    [Serializable]
    public class Product : Entity {
        public decimal Price { get; set; }
    }
}
