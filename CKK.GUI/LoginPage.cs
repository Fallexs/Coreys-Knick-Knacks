using System;
using System.Windows.Forms;
using CKK.Logic;
using CKK.Logic.Models;

namespace Login_Page {
    public partial class LoginPage : Form {
        public LoginPage() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
    }
}
