namespace Login_Page {
    partial class LoginPage {
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.AcceptsReturn = true;
            this.usernameBox.AcceptsTab = true;
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Helvetica", 20F);
            this.usernameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameBox.Location = new System.Drawing.Point(392, 240);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(400, 39);
            this.usernameBox.TabIndex = 6;
            // 
            // helpLink
            // 
            this.helpLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpLink.AutoSize = true;
            this.helpLink.Font = new System.Drawing.Font("Helvetica", 8F);
            this.helpLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.helpLink.Location = new System.Drawing.Point(497, 545);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(192, 12);
            this.helpLink.TabIndex = 11;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "Having Trouble? Contact Management";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Helvetica", 15F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.usernameLabel.Location = new System.Drawing.Point(541, 203);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 24);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(147)))), ((int)(((byte)(69)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Font = new System.Drawing.Font("Helvetica", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(669, 431);
            this.loginButton.MaximumSize = new System.Drawing.Size(110, 40);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 40);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.AcceptsReturn = true;
            this.passwordBox.AcceptsTab = true;
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Helvetica", 20F);
            this.passwordBox.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordBox.Location = new System.Drawing.Point(392, 361);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(400, 39);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Helvetica", 15F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.passwordLabel.Location = new System.Drawing.Point(541, 324);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.helpLink);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corey\'s Knick Knacks - Staff Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel helpLink;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
    }
}

