using CKK.DB.UOW;
using CKK.Logic;
using CKK.Logic.Models;
using System;
using System.Windows.Forms;

namespace Login_Page {
    public partial class LoginPage : Form {
        public LoginPage() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            DatabaseConnectionFactory connectionFactory = new DatabaseConnectionFactory();
            HomePage homePage = new HomePage(connectionFactory);
            homePage.Show(owner: this);
            this.Hide();
        }
    }
}
