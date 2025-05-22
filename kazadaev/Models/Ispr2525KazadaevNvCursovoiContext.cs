using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace kazadaev.Models;

public partial class Ispr2525KazadaevNvCursovoiContext : DbContext
{
    public Ispr2525KazadaevNvCursovoiContext()
    {
    }

    public Ispr2525KazadaevNvCursovoiContext(DbContextOptions<Ispr2525KazadaevNvCursovoiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-25_KazadaevNV_Cursovoi;uid=ISPr25-25_KazadaevNV;pwd=ISPr25-25_KazadaevNV", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.42-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategories).HasName("PRIMARY");

            entity.Property(e => e.IdCategories).HasColumnName("idCategories");
            entity.Property(e => e.CategoriesName).HasMaxLength(105);
            entity.Property(e => e.Descriptions).HasMaxLength(255);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.IdCustomers).HasName("PRIMARY");

            entity.HasIndex(e => e.UsersIdUsers, "fk_Customers_Users1_idx");

            entity.HasIndex(e => e.Email, "fk_Customers_Users1_idx1");

            entity.HasIndex(e => new { e.Phone, e.Email, e.Name, e.UsersIdUsers }, "idCustomers_idx");

            entity.Property(e => e.IdCustomers).HasColumnName("idCustomers");
            entity.Property(e => e.Email).HasMaxLength(105);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(105)
                .HasColumnName("phone");
            entity.Property(e => e.UsersIdUsers).HasColumnName("Users_idUsers");

            entity.HasOne(d => d.UsersIdUsersNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.UsersIdUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Customers_Users1");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrders).HasName("PRIMARY");

            entity.HasIndex(e => e.CustomersIdCustomers, "fk_Orders_Customers1_idx");

            entity.HasIndex(e => e.StatusIdStatus, "fk_Orders_Status1_idx");

            entity.Property(e => e.IdOrders).HasColumnName("idOrders");
            entity.Property(e => e.CustomersIdCustomers).HasColumnName("Customers_idCustomers");
            entity.Property(e => e.Orderdate).HasMaxLength(50);
            entity.Property(e => e.StatusIdStatus).HasColumnName("Status_idStatus");

            entity.HasOne(d => d.CustomersIdCustomersNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomersIdCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Orders_Customers1");

            entity.HasOne(d => d.StatusIdStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusIdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Orders_Status1");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.IdOrderDetails).HasName("PRIMARY");

            entity.HasIndex(e => e.OrdersIdOrders, "fk_OrderDetails_Orders1_idx");

            entity.HasIndex(e => e.ProductIdProduct, "fk_OrderDetails_Product1_idx");

            entity.Property(e => e.IdOrderDetails).HasColumnName("idOrderDetails");
            entity.Property(e => e.OrdersIdOrders).HasColumnName("Orders_idOrders");
            entity.Property(e => e.ProductIdProduct).HasColumnName("Product_idProduct");

            entity.HasOne(d => d.OrdersIdOrdersNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrdersIdOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_OrderDetails_Orders1");

            entity.HasOne(d => d.ProductIdProductNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductIdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_OrderDetails_Product1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PRIMARY");

            entity.ToTable("Product");

            entity.HasIndex(e => e.CategoriesIdCategories, "fk_Product_Categories1_idx");

            entity.Property(e => e.IdProduct).HasColumnName("idProduct");
            entity.Property(e => e.CategoriesIdCategories).HasColumnName("Categories_idCategories");
            entity.Property(e => e.Productname).HasMaxLength(105);

            entity.HasOne(d => d.CategoriesIdCategoriesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoriesIdCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Product_Categories1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Role1)
                .HasMaxLength(25)
                .HasColumnName("Role");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("Status");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Status1)
                .HasMaxLength(105)
                .HasColumnName("Status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUsers).HasName("PRIMARY");

            entity.Property(e => e.IdUsers).HasColumnName("idUsers");
            entity.Property(e => e.Password).HasMaxLength(105);
            entity.Property(e => e.Role).HasColumnType("enum('Администратор','Зам директора','Директор')");
            entity.Property(e => e.UsersName).HasMaxLength(105);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
