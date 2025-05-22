using kazadaev.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class director : Form
    {
        private Avtorisation _form1;
        public director(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += director_FormClosed;
        }

        private void director_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context = new();
            var Users = context.Users
                .OrderBy(x => x.IdUsers)
                .Select(x => new
                {
                    x.IdUsers,
                    x.UsersName,
                    x.Password,
                    x.Role
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context2 = new();
            var Status = context2.Statuses
                .OrderBy(x => x.IdStatus)
                .Select(x => new
                {
                    x.IdStatus,
                    x.Status1
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context3 = new();
            var Product = context3.Products
                .Include(x => x.CategoriesIdCategories)
                .OrderBy(x => x.IdProduct)
                .Select(x => new
                {
                    x.IdProduct,
                    x.Productname,
                    x.Price,
                    x.StockQuantity,
                    x.CategoriesIdCategories
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context4 = new();
            var Role = context4.Roles
                .OrderBy(x => x.IdRole)
                .Select(x => new
                {
                    x.IdRole,
                    x.Role1,

                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context5 = new();
            var Orders = context5.Orders
                .Include(x => x.StatusIdStatus)
                .Include(x => x.CustomersIdCustomers)
                .OrderBy(x => x.IdOrders)
                .Select(x => new
                {
                    x.IdOrders,
                    x.Orderdate,
                    x.TotalAmount,
                    x.StatusIdStatus,
                    x.CustomersIdCustomers

                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context6 = new();
            var OrderDetails = context6.OrderDetails
                .Include(x => x.ProductIdProduct)
                .Include(x => x.OrdersIdOrders)
                .OrderBy(x => x.IdOrderDetails)
                .Select(x => new
                {
                    x.IdOrderDetails,
                    x.Quantity,
                    x.Price,
                    x.ProductIdProduct,
                    x.OrdersIdOrders
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context7 = new();
            var Customers = context6.Customers
                .Include(x => x.UsersIdUsers)
                .OrderBy(x => x.IdCustomers)
                .Select(x => new
                {
                    x.IdCustomers,
                    x.Name,
                    x.Phone,
                    x.Email,
                    x.UsersIdUsers
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525KazadaevNvCursovoiContext context8 = new();
            var Categories = context8.Categories
                .OrderBy(x => x.IdCategories)
                .Select(x => new
                {
                    x.IdCategories,
                    x.CategoriesName,
                    x.Descriptions,
                });
        }

        private void director_Load(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Users.ToList();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Users.ToList();
        }
        private void Status_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Statuses.ToList();
        }

        private void Role_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Roles.ToList();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Products.ToList();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Orders.ToList();
        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.OrderDetails.ToList();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Customers.ToList();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Categories.ToList();
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
