namespace kazadaev
{
    partial class director
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            bt_min = new Button();
            Categories = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            Customers = new Button();
            OrderDetails = new Button();
            Orders = new Button();
            Product = new Button();
            Role = new Button();
            Status = new Button();
            Users = new Button();
            bt_delete = new Button();
            bt_edit = new Button();
            bt_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 346);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(bt_min);
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(bt_max);
            panel1.Controls.Add(bt_exit);
            panel1.Controls.Add(Customers);
            panel1.Controls.Add(OrderDetails);
            panel1.Controls.Add(Orders);
            panel1.Controls.Add(Product);
            panel1.Controls.Add(Role);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(Users);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 59);
            panel1.TabIndex = 1;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.Navy;
            bt_min.Location = new Point(714, 3);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(24, 23);
            bt_min.TabIndex = 10;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // Categories
            // 
            Categories.BackColor = Color.FromArgb(192, 192, 255);
            Categories.Location = new Point(266, 32);
            Categories.Name = "Categories";
            Categories.Size = new Size(75, 23);
            Categories.TabIndex = 7;
            Categories.Text = "Categories";
            Categories.UseVisualStyleBackColor = false;
            Categories.Click += Categories_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Green;
            bt_max.Location = new Point(744, 3);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(22, 23);
            bt_max.TabIndex = 9;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.Red;
            bt_exit.Location = new Point(772, 3);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(23, 23);
            bt_exit.TabIndex = 8;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Customers
            // 
            Customers.BackColor = Color.FromArgb(192, 192, 255);
            Customers.Location = new Point(252, 3);
            Customers.Name = "Customers";
            Customers.Size = new Size(75, 23);
            Customers.TabIndex = 6;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // OrderDetails
            // 
            OrderDetails.BackColor = Color.FromArgb(192, 192, 255);
            OrderDetails.Location = new Point(171, 32);
            OrderDetails.Name = "OrderDetails";
            OrderDetails.Size = new Size(89, 23);
            OrderDetails.TabIndex = 5;
            OrderDetails.Text = "OrderDetails";
            OrderDetails.UseVisualStyleBackColor = false;
            OrderDetails.Click += OrderDetails_Click;
            // 
            // Orders
            // 
            Orders.BackColor = Color.FromArgb(192, 192, 255);
            Orders.Location = new Point(171, 3);
            Orders.Name = "Orders";
            Orders.Size = new Size(75, 23);
            Orders.TabIndex = 4;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = false;
            Orders.Click += Orders_Click;
            // 
            // Product
            // 
            Product.BackColor = Color.FromArgb(192, 192, 255);
            Product.Location = new Point(90, 32);
            Product.Name = "Product";
            Product.Size = new Size(75, 23);
            Product.TabIndex = 3;
            Product.Text = "Product";
            Product.UseVisualStyleBackColor = false;
            Product.Click += Product_Click;
            // 
            // Role
            // 
            Role.BackColor = Color.FromArgb(192, 192, 255);
            Role.Location = new Point(90, 3);
            Role.Name = "Role";
            Role.Size = new Size(75, 23);
            Role.TabIndex = 2;
            Role.Text = "Role";
            Role.UseVisualStyleBackColor = false;
            Role.Click += Role_Click;
            // 
            // Status
            // 
            Status.BackColor = Color.FromArgb(192, 192, 255);
            Status.Location = new Point(9, 32);
            Status.Name = "Status";
            Status.Size = new Size(75, 23);
            Status.TabIndex = 1;
            Status.Text = "Status";
            Status.UseVisualStyleBackColor = false;
            Status.Click += Status_Click;
            // 
            // Users
            // 
            Users.BackColor = Color.FromArgb(192, 192, 255);
            Users.Location = new Point(9, 3);
            Users.Name = "Users";
            Users.Size = new Size(75, 23);
            Users.TabIndex = 0;
            Users.Text = "Users";
            Users.UseVisualStyleBackColor = false;
            Users.Click += Users_Click;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.FromArgb(128, 128, 255);
            bt_delete.Location = new Point(194, 66);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(85, 33);
            bt_delete.TabIndex = 7;
            bt_delete.Text = "Удалить";
            bt_delete.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = Color.FromArgb(128, 128, 255);
            bt_edit.Location = new Point(103, 66);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(85, 33);
            bt_edit.TabIndex = 6;
            bt_edit.Text = "Изменить";
            bt_edit.UseVisualStyleBackColor = false;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.FromArgb(128, 128, 255);
            bt_add.Location = new Point(12, 66);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(85, 33);
            bt_add.TabIndex = 5;
            bt_add.Text = "Добавить";
            bt_add.UseVisualStyleBackColor = false;
            // 
            // director
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(bt_delete);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "director";
            Text = "director";
            Load += director_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button Categories;
        private Button Customers;
        private Button OrderDetails;
        private Button Orders;
        private Button Product;
        private Button Role;
        private Button Status;
        private Button Users;
        private Button bt_delete;
        private Button bt_edit;
        private Button bt_add;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}