using CKK.DB.Interfaces;
using CKK.DB.UOW;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page {
    public partial class AddProduct : Form {
        //public AddProduct(FileStore store) {
        //this.store = store;
        //  InitializeComponent();
        //}
        private readonly IProductRepository products;
        public AddProduct(IProductRepository products) {
            this.products = products;
            InitializeComponent();
        }
        private void submitButton_Click(object sender, EventArgs e) {
            var newProduct = new Product();
            newProduct.Name = productNameBox.Text;
            newProduct.Price = Convert.ToDecimal(productPriceBox.Text);
            newProduct.Quantity = Convert.ToInt32(productQuantityBox.Text);
            products.Add(newProduct);
            this.Close();
        }
    }
}
