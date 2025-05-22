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
    public partial class Deputy_Director : Form
    {
        private Avtorisation _form1;
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        public Deputy_Director(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Deputy_Director_FormClosed;
        }

        private void Deputy_Director_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        private void UpdateInfo()
        {
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

        private void Orders_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Orders.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            activeEntity = ActiveEntity.Orders;
        }

        private void Status_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Statuses.ToList();
            dataGridView1.Columns[2].Visible = false;
            activeEntity = ActiveEntity.Statuses;
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Products.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.Products;

        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.OrderDetails.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.OrderDetails;
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Customers.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            activeEntity = ActiveEntity.Customers;
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Categories.ToList();
            dataGridView1.Columns[3].Visible = false;
            activeEntity = ActiveEntity.Categories;
        }

        private void Deputy_Director_Load(object sender, EventArgs e)
        {
            Ispr2525KazadaevNvCursovoiContext context = new();
            dataGridView1.DataSource = context.Orders.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            activeEntity = ActiveEntity.Orders;
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (activeEntity == ActiveEntity.Statuses)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex = new();
                        var Statuses = contex.Statuses.Where(x => x.IdStatus == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Statuses.ExecuteDelete();
                            contex.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex.Statuses.ToList();
                            dataGridView1.Columns[2].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }
            if (activeEntity == ActiveEntity.Products)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex3 = new();
                        var Products = contex3.Products.Where(x => x.IdProduct == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Products.ExecuteDelete();
                            contex3.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex3.Products.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Orders)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex4 = new();
                        var Orders = contex4.Orders.Where(x => x.IdOrders == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Orders.ExecuteDelete();
                            contex4.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex4.Orders.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;
                            dataGridView1.Columns[7].Visible = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.OrderDetails)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex5 = new();
                        var OrderDetails = contex5.OrderDetails.Where(x => x.IdOrderDetails == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            OrderDetails.ExecuteDelete();
                            contex5.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex5.OrderDetails.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Customers)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex6 = new();
                        var Customers = contex6.Customers.Where(x => x.IdCustomers == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Customers.ExecuteDelete();
                            contex6.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex6.Customers.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }
            if (activeEntity == ActiveEntity.Categories)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525KazadaevNvCursovoiContext contex6 = new();
                        var Categories = contex6.Categories.Where(x => x.IdCategories == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Categories.ExecuteDelete();
                            contex6.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex6.Categories.ToList();
                            dataGridView1.Columns[3].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.Y;
            if (activeEntity == ActiveEntity.Statuses)
            {
                try
                {
                    var Status = new Models.Status
                    {
                        IdStatus = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Status1 = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Statuses, Status);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context1 = new();
                        dataGridView1.DataSource = context1.Statuses.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Products)
            {
                try
                {
                    var Products = new Product
                    {
                        IdProduct = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Productname = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Price = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                        StockQuantity = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                        CategoriesIdCategories = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Products, Products);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context3 = new();
                        dataGridView1.DataSource = context3.Products.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Orders)
            {
                try
                {
                    var Orders = new Order
                    {
                        IdOrders = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Orderdate = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        TotalAmount = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                        StatusIdStatus = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                        CustomersIdCustomers = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Orders, Orders);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context4 = new();
                        dataGridView1.DataSource = context4.Orders.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.OrderDetails)
            {
                try
                {
                    var OrderDetails = new OrderDetail
                    {
                        IdOrderDetails = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Quantity = (int)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Price = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                        ProductIdProduct = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                        OrdersIdOrders = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.OrderDetails, OrderDetails);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context5 = new();
                        dataGridView1.DataSource = context5.OrderDetails.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Customers)
            {
                try
                {
                    var Customers = new Customer
                    {
                        IdCustomers = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        Name = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Phone = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        Email = (string)dataGridView1.SelectedRows[0].Cells[3].Value,
                        UsersIdUsers = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Customers, Customers);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context6 = new();
                        dataGridView1.DataSource = context6.Customers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Categories)
            {
                try
                {
                    var Categories = new Category
                    {
                        IdCategories = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        CategoriesName = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Descriptions = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Categories, Categories);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context6 = new();
                        dataGridView1.DataSource = context6.Categories.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.N;
            if (activeEntity == ActiveEntity.Statuses)
            {
                try
                {
                    var Status = new Models.Status
                    {
                        IdStatus = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Status1 = "",
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Statuses, Status);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context1 = new();
                        dataGridView1.DataSource = context1.Statuses.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Products)
            {
                try
                {
                    var Products = new Product
                    {
                        IdProduct = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Productname = "",
                        Price = 0,
                        StockQuantity = 0,
                        CategoriesIdCategories = 0,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Products, Products);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context3 = new();
                        dataGridView1.DataSource = context3.Products.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Orders)
            {
                try
                {
                    var Orders = new Order
                    {
                        IdOrders = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Orderdate = "",
                        TotalAmount = 0,
                        StatusIdStatus = 0,
                        CustomersIdCustomers = 0,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Orders, Orders);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context4 = new();
                        dataGridView1.DataSource = context4.Orders.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.OrderDetails)
            {
                try
                {
                    var OrderDetails = new OrderDetail
                    {
                        IdOrderDetails = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Quantity = 0,
                        Price = 0,
                        ProductIdProduct = 0,
                        OrdersIdOrders = 0,
                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.OrderDetails, OrderDetails);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context5 = new();
                        dataGridView1.DataSource = context5.OrderDetails.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Customers)
            {
                try
                {
                    var Customers = new Customer
                    {
                        IdCustomers = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        Name = "",
                        Phone = "",
                        Email = "",
                        UsersIdUsers = 0,

                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Customers, Customers);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context6 = new();
                        dataGridView1.DataSource = context6.Customers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Categories)
            {
                try
                {
                    var Categories = new Category
                    {
                        IdCategories = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        CategoriesName = "",
                        Descriptions = "",

                    };
                    this.Hide();
                    var editing = new editing(ActiveEntity.Categories, Categories);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525KazadaevNvCursovoiContext context6 = new();
                        dataGridView1.DataSource = context6.Categories.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
        }
    }
}
