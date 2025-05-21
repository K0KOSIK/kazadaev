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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    BindAlertLogs((Users)entityData);
                    break;
                case ActiveEntity.Statuses:
                    BindDeviceType((Statuses)entityData);
                    break;
                case ActiveEntity.Products:
                    BindPerformanceReports((Products)entityData);
                    break;
                case ActiveEntity.Roles:
                    BindMonitoringData((Roles)entityData);
                    break;
                case ActiveEntity.Orders:
                    BindPLC_Devices((Orders)entityData);
                    break;
                case ActiveEntity.OrderDetails:
                    BindSeverity((OrderDetails)entityData);
                    break;
                case ActiveEntity.Customers:
                    BindStatus((Customers)entityData);
                    break;
                case ActiveEntity.Categories:
                    BindStatus((Categories)entityData);
                    break;
            }
        }
        private void editing_Load(object sender, EventArgs e)
        {

        }
    }
}
