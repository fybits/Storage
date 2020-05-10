namespace Storage {
    partial class MainForm {
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.sideBarPanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(201)))), ((int)(((byte)(239)))));
            this.sideBarPanel.Controls.Add(this.btnUsers);
            this.sideBarPanel.Controls.Add(this.btnAddProduct);
            this.sideBarPanel.Controls.Add(this.btnCatalog);
            this.sideBarPanel.Controls.Add(this.userInfoPanel);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(210, 525);
            this.sideBarPanel.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(170)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 146);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(210, 55);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnCatalog
            // 
            this.btnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.btnCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(170)))));
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCatalog.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.Location = new System.Drawing.Point(0, 91);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(210, 55);
            this.btnCatalog.TabIndex = 2;
            this.btnCatalog.Text = "Каталог";
            this.btnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.UseVisualStyleBackColor = false;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.White;
            this.userInfoPanel.Controls.Add(this.linkLabel1);
            this.userInfoPanel.Controls.Add(this.username);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Padding = new System.Windows.Forms.Padding(6);
            this.userInfoPanel.Size = new System.Drawing.Size(210, 91);
            this.userInfoPanel.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username.Location = new System.Drawing.Point(9, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(51, 20);
            this.username.TabIndex = 0;
            this.username.Text = "label1";
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(210, 0);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(734, 525);
            this.mainContentPanel.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(170)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 201);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 55);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(98, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Выйти из аккаунта";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 525);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.sideBarPanel);
            this.MinimumSize = new System.Drawing.Size(760, 500);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}