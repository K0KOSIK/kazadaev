using kazadaev.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kazadaev
{
    public partial class editing : Form
    {
        public int IdCategories { get; set; }

        public string CategoriesName { get; set; } = null!;

        public string Descriptions { get; set; } = null!;

        public int IdCustomers { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int UsersIdUsers { get; set; }

        public int IdOrders { get; set; }

        public DateTime Orderdate { get; set; }

        public decimal TotalAmount { get; set; }

        public int StatusIdStatus { get; set; }

        public int CustomersIdCustomers { get; set; }

        public int IdOrderDetails { get; set; }

        public string Quantity { get; set; } = null!;

        public int Price { get; set; }

        public int ProductIdProduct { get; set; }

        public int OrdersIdOrders { get; set; }

        public int IdProduct { get; set; }

        public string Productname { get; set; } = null!;

        public int StockQuantity { get; set; }

        public int CategoriesIdCategories { get; set; }

        public int IdRole { get; set; }

        public string Role1 { get; set; } = null!;

        public int IdStatus { get; set; }

        public string Status1 { get; set; } = null!;

        public int IdUsers { get; set; }

        public string UsersName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Role { get; set; } = null!;

        public ActiveEntity x { get; set; }

        public IsEdit isEdit { get; set; }
        public IsError isError;

        public editing(ActiveEntity activeEntity, object entityData)
        {
            InitializeComponent();
            x = activeEntity;
            ConfigureForm(entityData);
            isError = IsError.N;
        }
        private void ConfigureForm(object entityData)
        {
            switch (x)
            {
                case ActiveEntity.Users:
                    BindUsers((User)entityData);
                    break;
                case ActiveEntity.Statuses:
                    BindStatuses((Models.Status)entityData);
                    break;
                case ActiveEntity.Products:
                    BindProducts((Product)entityData);
                    break;
                case ActiveEntity.Roles:
                    BindRoles((Role)entityData);
                    break;
                case ActiveEntity.Orders:
                    BindOrders((Order)entityData);
                    break;
                case ActiveEntity.OrderDetails:
                    BindOrderDetails((OrderDetail)entityData);
                    break;
                case ActiveEntity.Customers:
                    BindCustomers((Customer)entityData);
                    break;
                case ActiveEntity.Categories:
                    BindCategories((Category)entityData);
                    break;
            }
        }
        private void editing_Load(object sender, EventArgs e)
        {

        }

        private void BindUsers(User user)
        {
            input.DataBindings.Add("Text", user, nameof(user.IdUsers));
            input2.DataBindings.Add("Text", user, nameof(user.UsersName));
            input3.DataBindings.Add("Text", user, nameof(user.Password));
            input4.DataBindings.Add("Text", user, nameof(user.Role));
        }
        private void BindStatuses(Models.Status status)
        {
            input.DataBindings.Add("Text", status, nameof(status.IdStatus));
            input2.DataBindings.Add("Text", status, nameof(status.Status1));
        }
        private void BindProducts(Product product)
        {
            input.DataBindings.Add("Text", product, nameof(product.IdProduct));
            input2.DataBindings.Add("Text", product, nameof(product.Productname));
            input3.DataBindings.Add("Text", product, nameof(product.Price));
            input4.DataBindings.Add("Text", product, nameof(product.StockQuantity));
            input5.DataBindings.Add("Text", product, nameof(product.CategoriesIdCategories));
        }
        private void BindRoles(Role roles)
        {
            input.DataBindings.Add("Text", roles, nameof(roles.IdRole));
            input2.DataBindings.Add("Text", roles, nameof(roles.Role1));
            input3.DataBindings.Add("Text", roles, nameof(roles.UsersIdUsers));
        }
        private void BindOrders(Order order)
        {
            input.DataBindings.Add("Text", order, nameof(order.IdOrders));
            input2.DataBindings.Add("Text", order, nameof(order.Orderdate));
            input3.DataBindings.Add("Text", order, nameof(order.TotalAmount));
            input4.DataBindings.Add("Text", order, nameof(order.StatusIdStatus));
            input5.DataBindings.Add("Text", order, nameof(order.CustomersIdCustomers));
        }
        private void BindOrderDetails(OrderDetail orderdetail)
        {
            input.DataBindings.Add("Text", orderdetail, nameof(orderdetail.IdOrderDetails));
            input2.DataBindings.Add("Text", orderdetail, nameof(orderdetail.Quantity));
            input3.DataBindings.Add("Text", orderdetail, nameof(orderdetail.Price));
            input4.DataBindings.Add("Text", orderdetail, nameof(orderdetail.ProductIdProduct));
            input5.DataBindings.Add("Text", orderdetail, nameof(orderdetail.OrdersIdOrders));
        }
        private void BindCustomers(Customer customer)
        {
            input.DataBindings.Add("Text", customer, nameof(customer.IdCustomers));
            input2.DataBindings.Add("Text", customer, nameof(customer.Name));
            input3.DataBindings.Add("Text", customer, nameof(customer.Phone));
            input4.DataBindings.Add("Text", customer, nameof(customer.Email));
            input5.DataBindings.Add("Text", customer, nameof(customer.UsersIdUsers));
        }
        private void BindCategories(Category category)
        {
            input.DataBindings.Add("Text", category, nameof(category.IdCategories));
            input2.DataBindings.Add("Text", category, nameof(category.CategoriesName));
            input3.DataBindings.Add("Text", category, nameof(category.Descriptions));
        }

        private void save_click_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case ActiveEntity.Users:
                    User User = new();
                    User.IdUsers = Convert.ToInt32(input.Text);
                    User.UsersName = input2.Text;
                    User.Password = input3.Text;
                    User.Role = input4.Text;
                    Ispr2525KazadaevNvCursovoiContext context = new();
                    if (isEdit == IsEdit.Y)
                        context.Update(User);
                    if (isEdit == IsEdit.N)
                        context.Add(User);
                    context.SaveChanges();
                    break;
                case ActiveEntity.Statuses:
                    Status Status = new();
                    Status.IdStatus = Convert.ToInt32(input.Text);
                    Status.Status1 = input2.Text;
                    Ispr2525KazadaevNvCursovoiContext context2 = new();
                    if (isEdit == IsEdit.Y)
                    {
                        context2.Update(Status);
                    }
                    if (isEdit == IsEdit.N)
                    {
                        context2.Add(Status);
                    }
                    context2.SaveChanges();
                    break;
                case ActiveEntity.Products:
                    Product Product = new();
                    Product.IdProduct = Convert.ToInt32(input.Text);
                    Product.Productname = input2.Text;
                    Product.Price = Convert.ToInt32(input3.Text);
                    Product.StockQuantity = Convert.ToInt32(input4.Text);
                    Product.CategoriesIdCategories = Convert.ToInt32(input5.Text);
                    if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525KazadaevNvCursovoiContext context3 = new();
                    if (isEdit == IsEdit.Y)
                        context3.Update(Product);
                    if (isEdit == IsEdit.N)
                        context3.Add(Product);
                    context3.SaveChanges();
                    break;
                case ActiveEntity.Roles:
                    Role Role = new();
                    Role.IdRole = Convert.ToInt32(input.Text);
                    Role.Role1 = input2.Text;
                    Role.UsersIdUsers = Convert.ToInt32(input3.Text);
                    if (Convert.ToInt32(input3.Text) < 1 || Convert.ToInt32(input3.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525KazadaevNvCursovoiContext context4 = new();
                    if (isEdit == IsEdit.Y)
                        context4.Update(Role);
                    if (isEdit == IsEdit.N)
                        context4.Add(Role);
                    context4.SaveChanges();
                    break;
                case ActiveEntity.Orders:
                    Order Order = new();
                    Order.IdOrders = Convert.ToInt32(input.Text);
                    Order.Orderdate = input2.Text;
                    Order.TotalAmount = Convert.ToInt32(input3.Text);
                    Order.StatusIdStatus = Convert.ToInt32(input4.Text);
                    if (Convert.ToInt32(input4.Text) < 1 || Convert.ToInt32(input4.Text) > 2)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 2", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Order.CustomersIdCustomers = Convert.ToInt32(input5.Text);
                    if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525KazadaevNvCursovoiContext context5 = new();
                    if (isEdit == IsEdit.Y)
                        context5.Update(Order);
                    if (isEdit == IsEdit.N)
                        context5.Add(Order);
                    context5.SaveChanges();
                    break;
                case ActiveEntity.OrderDetails:
                    OrderDetail OrderDetail = new();
                    OrderDetail.IdOrderDetails = Convert.ToInt32(input.Text);
                    OrderDetail.Quantity = Convert.ToInt32 (input2.Text);
                    OrderDetail.Price = Convert.ToInt32(input3.Text);
                    OrderDetail.ProductIdProduct = Convert.ToInt32(input4.Text);
                    if (Convert.ToInt32(input4.Text) < 1 || Convert.ToInt32(input4.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    OrderDetail.OrdersIdOrders = Convert.ToInt32(input5.Text);
                    if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525KazadaevNvCursovoiContext context6 = new();
                    if (isEdit == IsEdit.Y)
                        context6.Update(OrderDetail);
                    if (isEdit == IsEdit.N)
                        context6.Add(OrderDetail);
                    context6.SaveChanges();
                    break;
                case ActiveEntity.Customers:
                    Customer Customer = new();
                    Customer.IdCustomers = Convert.ToInt32(input.Text);
                    Customer.Name = input2.Text;
                    Customer.Phone = input3.Text;
                    Customer.Email = input4.Text;
                    Customer.UsersIdUsers = Convert.ToInt32(input5.Text);
                    if (Convert.ToInt32(input5.Text) < 1 || Convert.ToInt32(input5.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525KazadaevNvCursovoiContext context7 = new();
                    if (isEdit == IsEdit.Y)
                        context7.Update(Customer);
                    if (isEdit == IsEdit.N)
                        context7.Add(Customer);
                    context7.SaveChanges();
                    break;
                case ActiveEntity.Categories:
                    Category Category = new();
                    Category.IdCategories = Convert.ToInt32(input.Text);
                    Category.CategoriesName = input2.Text;
                    Category.Descriptions = input3.Text;
                    Ispr2525KazadaevNvCursovoiContext context8 = new();
                    if (isEdit == IsEdit.Y)
                        context8.Update(Category);
                    if (isEdit == IsEdit.N)
                        context8.Add(Category);
                    context8.SaveChanges();
                    break;
                default:
                    break;
            }
            if (isError == IsError.N)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancellation_Click(object sender, EventArgs e)
        {
            if (isEdit == IsEdit.Y)
            {
                switch (x)
                {
                    case ActiveEntity.Users:
                        Ispr2525KazadaevNvCursovoiContext context = new();
                        context.SaveChanges();
                        break;
                    case ActiveEntity.Statuses:
                        Ispr2525KazadaevNvCursovoiContext context2 = new();
                        context2.SaveChanges();
                        break;
                    case ActiveEntity.Products:
                        Ispr2525KazadaevNvCursovoiContext context3 = new();
                        context3.SaveChanges();
                        break;
                    case ActiveEntity.Roles:
                        Ispr2525KazadaevNvCursovoiContext context4 = new();
                        context4.SaveChanges();
                        break;
                    case ActiveEntity.Orders:
                        Ispr2525KazadaevNvCursovoiContext context5 = new();
                        context5.SaveChanges();
                        break;
                    case ActiveEntity.OrderDetails:
                        Ispr2525KazadaevNvCursovoiContext context6 = new();
                        context6.SaveChanges();
                        break;
                    case ActiveEntity.Customers:
                        Ispr2525KazadaevNvCursovoiContext context7 = new();
                        context7.SaveChanges();
                        break;
                    case ActiveEntity.Categories:
                        Ispr2525KazadaevNvCursovoiContext context8 = new();
                        context8.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

