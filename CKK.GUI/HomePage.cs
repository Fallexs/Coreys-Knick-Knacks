using CKK.DB.Interfaces;
using CKK.DB.UOW;
using CKK.Logic;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Forms;


namespace Login_Page {
    public partial class HomePage : Form {
        protected readonly UnitOfWork unitOfWork;
        protected readonly IProductRepository products;

        public HomePage(IConnectionFactory connectionFactory) {
            unitOfWork = new UnitOfWork(connectionFactory);
            products = unitOfWork.Products;
            InitializeComponent();
            inventoryList.DataSource = products.GetAll();
            greetMessage.Text = "Hello!";
        }
        private void logoutButton_Click(object sender, EventArgs e) {
            this.Owner.Dispose();
        }

        private void UpdateInventory() {
            inventoryList.DataSource = products.GetAll();
        }

        private void HomePage_Load(object sender, EventArgs e) {
            //Store.Load();
            UpdateInventory();
        }

        private void addProduct_Click(object sender, EventArgs e) {
            AddProduct newProduct = new AddProduct(products);
            newProduct.ShowDialog(this);
            UpdateInventory();
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            if( inventoryList.SelectedItem != null ) {
                var selectedItem = inventoryList.SelectedItem as Product;
                products.Delete(selectedItem);
                UpdateInventory();
            } else {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //        private void HomePage_FormClosing(object sender, FormClosingEventArgs e) {
        //          Store.Save();
        //    }

        private void noneRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if( noneRadioBtn.Checked == true ) {
                quantityRadioBtn.Checked = false;
                priceRadioBtn.Checked = false;
                UpdateInventory();
            }
        }

        private void quantityRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if( quantityRadioBtn.Checked == true ) {
                noneRadioBtn.Checked = false;
                priceRadioBtn.Checked = false;
                var quantitySort = products.GetAll().OrderBy(x => x.Quantity).ToList();
                inventoryList.DataSource = quantitySort;
                UpdateInventory();
            }
        }

        private void priceRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if( priceRadioBtn.Checked == true ) {
                noneRadioBtn.Checked = false;
                quantityRadioBtn.Checked = false;
                var priceSort = products.GetAll().OrderBy(x => x.Price).ToList();
                inventoryList.DataSource = priceSort;
            }
        }

        private void productNameSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if( e.KeyChar == ( char ) Keys.Enter ) {
                if( productNameSearch.Text.Trim() == "" ) {
                    inventoryList.DataSource = products.GetAll().ToList();
                } else {
                    var productSearch = products.GetAll().Where(x => x.Name.ToLower() == productNameSearch.Text.ToLower()).ToList();
                    inventoryList.DataSource = productSearch;
                }
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e) {
            this.Owner.Dispose();
        }
    }
}
