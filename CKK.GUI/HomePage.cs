using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CKK.Logic;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Models;

namespace Login_Page {
    public partial class HomePage : Form {
        private FileStore Store;

        public HomePage(FileStore store) {
            Store = store;
            InitializeComponent();
            greetMessage.Text = "Hello!";
        }
        private void logoutButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e) {
            Store.Load();
            RefreshInventory();
        }

        private void addProduct_Click(object sender, EventArgs e) {
            AddProduct newProduct = new AddProduct(Store);
            newProduct.ShowDialog(this);
            Store.Save();
            RefreshInventory();
        }

        public void RefreshInventory(List<StoreItem>? items = null) {
            inventoryList.Items.Clear();
            var list = items ?? Store.GetStoreItems();
            list.ForEach(item => inventoryList.Items.Add(item));
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            if (inventoryList.SelectedItem != null) {
                var selectedItem = inventoryList.SelectedItem as StoreItem;
                if (selectedItem != null) {
                    Store.DeleteStoreItem(selectedItem.Product.Id);
                    Store.Save();
                    RefreshInventory();
                }
            } else {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e) {
            Store.Save();
        }

        private void noneRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if (noneRadioBtn.Checked == true) {
                quantityRadioBtn.Checked = false;
                priceRadioBtn.Checked = false;
                RefreshInventory();
            }
        }

        private void quantityRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if (quantityRadioBtn.Checked == true) {
                noneRadioBtn.Checked = false;
                priceRadioBtn.Checked = false;
                var quantitySort = Store.GetProductsByQuantity();
                RefreshInventory(quantitySort);
            }
        }

        private void priceRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if (priceRadioBtn.Checked == true) {
                noneRadioBtn.Checked = false;
                quantityRadioBtn.Checked = false;
                var priceSort = Store.GetProductsByPrice();
                RefreshInventory(priceSort);
            }
        }

        private void productNameSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                var productSearch = Store.GetAllProductsByName(productNameSearch.Text);
                RefreshInventory(productSearch);
            }
        }
    }
}
