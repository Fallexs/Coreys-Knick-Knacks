using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions {
    [Serializable]
    public class ProductDoesNotExistException : Exception {
        public ProductDoesNotExistException() : base("Cannot remove product, invalid product entered!") { }
        public ProductDoesNotExistException(string message) : base(message) { }
        public ProductDoesNotExistException(string message, Exception inner) : base(message, inner) { }
    }
}
