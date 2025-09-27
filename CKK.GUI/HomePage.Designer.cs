namespace Login_Page {
    partial class HomePage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            logoutButton = new System.Windows.Forms.Button();
            topPanel = new System.Windows.Forms.Panel();
            label44 = new System.Windows.Forms.Label();
            greetMessage = new System.Windows.Forms.Label();
            settingButton = new System.Windows.Forms.Button();
            productLabel = new System.Windows.Forms.Label();
            addProduct = new System.Windows.Forms.Button();
            productNameSearch = new System.Windows.Forms.TextBox();
            productNameSearchLabel = new System.Windows.Forms.Label();
            searchPanel = new System.Windows.Forms.Panel();
            priceRadioBtn = new System.Windows.Forms.RadioButton();
            quantityRadioBtn = new System.Windows.Forms.RadioButton();
            noneRadioBtn = new System.Windows.Forms.RadioButton();
            deleteBtn = new System.Windows.Forms.Button();
            sortLabel = new System.Windows.Forms.Label();
            inventoryList = new System.Windows.Forms.ListBox();
            topPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            logoutButton.BackColor = System.Drawing.Color.FromArgb(      255,       134,       157);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.Font = new System.Drawing.Font("Helvetica", 12F);
            logoutButton.ForeColor = System.Drawing.Color.White;
            logoutButton.Location = new System.Drawing.Point(1092, 36);
            logoutButton.MaximumSize = new System.Drawing.Size(140, 48);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new System.Drawing.Size(140, 48);
            logoutButton.TabIndex = 11;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // topPanel
            // 
            topPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            topPanel.Controls.Add(label44);
            topPanel.Controls.Add(greetMessage);
            topPanel.Controls.Add(settingButton);
            topPanel.Controls.Add(logoutButton);
            topPanel.Location = new System.Drawing.Point(1, 1);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1264, 111);
            topPanel.TabIndex = 12;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new System.Drawing.Font("Helvetica", 30F);
            label44.ForeColor = System.Drawing.Color.White;
            label44.Location = new System.Drawing.Point(36, 36);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(603, 47);
            label44.TabIndex = 20;
            label44.Text = "Corey's Knick Knacks - Inventory";
            // 
            // greetMessage
            // 
            greetMessage.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            greetMessage.Font = new System.Drawing.Font("Helvetica", 12F);
            greetMessage.ForeColor = System.Drawing.Color.White;
            greetMessage.Location = new System.Drawing.Point(660, 36);
            greetMessage.Name = "greetMessage";
            greetMessage.Size = new System.Drawing.Size(332, 48);
            greetMessage.TabIndex = 14;
            greetMessage.Text = "Placeholder";
            greetMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingButton
            // 
            settingButton.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            settingButton.BackColor = System.Drawing.Color.Transparent;
            settingButton.BackgroundImage = ( System.Drawing.Image ) resources.GetObject("settingButton.BackgroundImage");
            settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            settingButton.FlatAppearance.BorderSize = 0;
            settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingButton.Location = new System.Drawing.Point(1012, 36);
            settingButton.Name = "settingButton";
            settingButton.Size = new System.Drawing.Size(48, 48);
            settingButton.TabIndex = 13;
            settingButton.UseVisualStyleBackColor = false;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,    0);
            productLabel.ForeColor = System.Drawing.Color.White;
            productLabel.Location = new System.Drawing.Point(40, 24);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(188, 37);
            productLabel.TabIndex = 13;
            productLabel.Text = "All Products";
            // 
            // addProduct
            // 
            addProduct.BackColor = System.Drawing.Color.FromArgb(      48,       147,       69);
            addProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            addProduct.Font = new System.Drawing.Font("Helvetica", 10F);
            addProduct.ForeColor = System.Drawing.Color.White;
            addProduct.Location = new System.Drawing.Point(260, 24);
            addProduct.Name = "addProduct";
            addProduct.Size = new System.Drawing.Size(136, 34);
            addProduct.TabIndex = 14;
            addProduct.Text = "Add Product";
            addProduct.UseVisualStyleBackColor = false;
            addProduct.Click += addProduct_Click;
            // 
            // productNameSearch
            // 
            productNameSearch.AcceptsReturn = true;
            productNameSearch.AcceptsTab = true;
            productNameSearch.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            productNameSearch.BackColor = System.Drawing.Color.FromArgb(      23,       24,       25);
            productNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            productNameSearch.Font = new System.Drawing.Font("Helvetica", 20F);
            productNameSearch.ForeColor = System.Drawing.SystemColors.Window;
            productNameSearch.Location = new System.Drawing.Point(954, 35);
            productNameSearch.Name = "productNameSearch";
            productNameSearch.Size = new System.Drawing.Size(232, 39);
            productNameSearch.TabIndex = 15;
            productNameSearch.KeyPress += productNameSearch_KeyPress;
            // 
            // productNameSearchLabel
            // 
            productNameSearchLabel.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            productNameSearchLabel.AutoSize = true;
            productNameSearchLabel.Font = new System.Drawing.Font("Helvetica", 12F);
            productNameSearchLabel.ForeColor = System.Drawing.Color.White;
            productNameSearchLabel.Location = new System.Drawing.Point(1004, 13);
            productNameSearchLabel.Name = "productNameSearchLabel";
            productNameSearchLabel.Size = new System.Drawing.Size(132, 19);
            productNameSearchLabel.TabIndex = 17;
            productNameSearchLabel.Text = "Product by Name";
            // 
            // searchPanel
            // 
            searchPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            searchPanel.Controls.Add(priceRadioBtn);
            searchPanel.Controls.Add(quantityRadioBtn);
            searchPanel.Controls.Add(noneRadioBtn);
            searchPanel.Controls.Add(productLabel);
            searchPanel.Controls.Add(deleteBtn);
            searchPanel.Controls.Add(addProduct);
            searchPanel.Controls.Add(sortLabel);
            searchPanel.Controls.Add(productNameSearchLabel);
            searchPanel.Controls.Add(productNameSearch);
            searchPanel.Location = new System.Drawing.Point(0, 112);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new System.Drawing.Size(1264, 88);
            searchPanel.TabIndex = 21;
            // 
            // priceRadioBtn
            // 
            priceRadioBtn.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            priceRadioBtn.AutoSize = true;
            priceRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            priceRadioBtn.ForeColor = System.Drawing.Color.Plum;
            priceRadioBtn.Location = new System.Drawing.Point(852, 49);
            priceRadioBtn.Name = "priceRadioBtn";
            priceRadioBtn.Size = new System.Drawing.Size(62, 25);
            priceRadioBtn.TabIndex = 18;
            priceRadioBtn.Text = "Price";
            priceRadioBtn.UseVisualStyleBackColor = true;
            priceRadioBtn.CheckedChanged += priceRadioBtn_CheckedChanged;
            // 
            // quantityRadioBtn
            // 
            quantityRadioBtn.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            quantityRadioBtn.AutoSize = true;
            quantityRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            quantityRadioBtn.ForeColor = System.Drawing.Color.Plum;
            quantityRadioBtn.Location = new System.Drawing.Point(758, 49);
            quantityRadioBtn.Name = "quantityRadioBtn";
            quantityRadioBtn.Size = new System.Drawing.Size(88, 25);
            quantityRadioBtn.TabIndex = 18;
            quantityRadioBtn.Text = "Quantity";
            quantityRadioBtn.UseVisualStyleBackColor = true;
            quantityRadioBtn.CheckedChanged += quantityRadioBtn_CheckedChanged;
            // 
            // noneRadioBtn
            // 
            noneRadioBtn.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            noneRadioBtn.AutoSize = true;
            noneRadioBtn.Checked = true;
            noneRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            noneRadioBtn.ForeColor = System.Drawing.Color.Plum;
            noneRadioBtn.Location = new System.Drawing.Point(686, 49);
            noneRadioBtn.Name = "noneRadioBtn";
            noneRadioBtn.Size = new System.Drawing.Size(66, 25);
            noneRadioBtn.TabIndex = 18;
            noneRadioBtn.TabStop = true;
            noneRadioBtn.Text = "None";
            noneRadioBtn.UseVisualStyleBackColor = true;
            noneRadioBtn.CheckedChanged += noneRadioBtn_CheckedChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = System.Drawing.Color.FromArgb(      255,       134,       157);
            deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            deleteBtn.Font = new System.Drawing.Font("Helvetica", 10F);
            deleteBtn.ForeColor = System.Drawing.Color.White;
            deleteBtn.Location = new System.Drawing.Point(434, 24);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(136, 34);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete Product";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // sortLabel
            // 
            sortLabel.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            sortLabel.AutoSize = true;
            sortLabel.Font = new System.Drawing.Font("Helvetica", 12F);
            sortLabel.ForeColor = System.Drawing.Color.White;
            sortLabel.Location = new System.Drawing.Point(782, 24);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new System.Drawing.Size(38, 19);
            sortLabel.TabIndex = 17;
            sortLabel.Text = "Sort";
            // 
            // inventoryList
            // 
            inventoryList.Anchor =    System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inventoryList.BackColor = System.Drawing.Color.FromArgb(      23,       24,       25);
            inventoryList.Font = new System.Drawing.Font("Helvetica", 30F);
            inventoryList.ForeColor = System.Drawing.Color.White;
            inventoryList.FormattingEnabled = true;
            inventoryList.ItemHeight = 47;
            inventoryList.Location = new System.Drawing.Point(12, 206);
            inventoryList.Name = "inventoryList";
            inventoryList.Size = new System.Drawing.Size(1240, 474);
            inventoryList.TabIndex = 25;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(      18,       18,       18);
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(inventoryList);
            Controls.Add(searchPanel);
            Controls.Add(topPanel);
            Font = new System.Drawing.Font("Helvetica", 8.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MinimumSize = new System.Drawing.Size(1280, 720);
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Corey's Knick Knacks - Staff Panel";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += HomePage_FormClosing;
            Load += HomePage_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Label greetMessage;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox productNameSearch;
        private System.Windows.Forms.Label productNameSearchLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.RadioButton noneRadioBtn;
        private System.Windows.Forms.RadioButton priceRadioBtn;
        private System.Windows.Forms.RadioButton quantityRadioBtn;
        private System.Windows.Forms.ListBox inventoryList;
    }
}