namespace Login_Page {
    partial class AddProduct {
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
            productNameBox = new System.Windows.Forms.TextBox();
            productQuantityBox = new System.Windows.Forms.TextBox();
            productPriceBox = new System.Windows.Forms.TextBox();
            submitButton = new System.Windows.Forms.Button();
            addNameLabel = new System.Windows.Forms.Label();
            addQuantityLabel = new System.Windows.Forms.Label();
            addPriceLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // productNameBox
            // 
            productNameBox.Location = new System.Drawing.Point(169, 43);
            productNameBox.Name = "productNameBox";
            productNameBox.Size = new System.Drawing.Size(156, 23);
            productNameBox.TabIndex = 0;
            // 
            // productQuantityBox
            // 
            productQuantityBox.Location = new System.Drawing.Point(169, 116);
            productQuantityBox.Name = "productQuantityBox";
            productQuantityBox.Size = new System.Drawing.Size(156, 23);
            productQuantityBox.TabIndex = 0;
            // 
            // productPriceBox
            // 
            productPriceBox.Location = new System.Drawing.Point(169, 188);
            productPriceBox.Name = "productPriceBox";
            productPriceBox.Size = new System.Drawing.Size(156, 23);
            productPriceBox.TabIndex = 0;
            // 
            // submitButton
            // 
            submitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            submitButton.Location = new System.Drawing.Point(109, 246);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(125, 28);
            submitButton.TabIndex = 1;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // addNameLabel
            // 
            addNameLabel.AutoSize = true;
            addNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            addNameLabel.Location = new System.Drawing.Point(11, 36);
            addNameLabel.Name = "addNameLabel";
            addNameLabel.Size = new System.Drawing.Size(152, 30);
            addNameLabel.TabIndex = 2;
            addNameLabel.Text = "Product Name";
            // 
            // addQuantityLabel
            // 
            addQuantityLabel.AutoSize = true;
            addQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            addQuantityLabel.Location = new System.Drawing.Point(30, 109);
            addQuantityLabel.Name = "addQuantityLabel";
            addQuantityLabel.Size = new System.Drawing.Size(100, 30);
            addQuantityLabel.TabIndex = 2;
            addQuantityLabel.Text = "Quantity:";
            // 
            // addPriceLabel
            // 
            addPriceLabel.AutoSize = true;
            addPriceLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            addPriceLabel.Location = new System.Drawing.Point(44, 181);
            addPriceLabel.Name = "addPriceLabel";
            addPriceLabel.Size = new System.Drawing.Size(65, 30);
            addPriceLabel.TabIndex = 2;
            addPriceLabel.Text = "Price:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(337, 301);
            Controls.Add(addPriceLabel);
            Controls.Add(addQuantityLabel);
            Controls.Add(addNameLabel);
            Controls.Add(submitButton);
            Controls.Add(productPriceBox);
            Controls.Add(productQuantityBox);
            Controls.Add(productNameBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "AddProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.TextBox productQuantityBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addQuantityLabel;
        private System.Windows.Forms.Label addPriceLabel;
    }
}