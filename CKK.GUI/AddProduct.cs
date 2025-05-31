using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Models;
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
        FileStore store;

        public AddProduct(FileStore store) {
            this.store = store;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            store.AddStoreItem(new Product { Name = productNameBox.Text, Price = Convert.ToDecimal(productPriceBox.Text) }, Convert.ToInt32(productQuantityBox.Text));
            this.Close();
        }
    }
}
