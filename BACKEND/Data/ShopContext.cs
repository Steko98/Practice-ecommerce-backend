using BACKEND.Models;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.Property(e => e.Id).HasColumnName("user_id");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.LastName).HasColumnName("last_name");
                entity.Property(e => e.Password).HasColumnName("password_hash");
                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.ToTable("product_order");
                entity.Property(e => e.Id).HasColumnName("product_order_id");
                entity.Property(e => e.ProductId).HasColumnName("product_id");
                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.HasOne(e => e.Product)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(po => po.ProductId);

                entity.HasOne(e => e.Order)
                    .WithMany(o => o.ProductOrders)
                    .HasForeignKey(e => e.OrderId);

                entity.HasIndex(e => e.ProductId);
                entity.HasIndex(e => e.OrderId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");
                entity.Property(e => e.Id).HasColumnName("product_id");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
                entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payments");
                entity.Property(e => e.Id).HasColumnName("payment_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.OrderId).HasColumnName("order_id");
                entity.Property(e => e.PayMethod).HasColumnName("pay_method");
                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");
                entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");
                entity.Property(e => e.PaymentDate).HasColumnName("payment_date");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");
                entity.Property(e => e.Id).HasColumnName("order_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");
                entity.Property(e => e.OrderStatus).HasColumnName("order_status");
                entity.Property(e => e.OrderDate).HasColumnName("order_date");
                entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");
                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");
                entity.Property(e => e.Id).HasColumnName("category_id");
                entity.Property(e => e.CategoryName).HasColumnName("category_name");
            });

            modelBuilder.Entity<CartProduct>(entity =>
            {
                entity.ToTable("cart_product");
                entity.Property(e => e.CartId).HasColumnName("cart_id");
                entity.Property(e => e.ProductId).HasColumnName("product_id");
                entity.Property(e => e.Quantity).HasColumnName("quantity").HasDefaultValue(1);

                entity.HasKey(e => new { e.CartId, e.ProductId });
                entity.HasOne(e => e.Cart)
                    .WithMany(c => c.CartProducts)
                    .HasForeignKey(e => e.CartId);
                entity.HasOne(e => e.Product)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(e => e.ProductId);
                entity.HasIndex(e => e.CartId);
                entity.HasIndex(e => e.ProductId);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("carts");
                entity.Property(e => e.Id).HasColumnName("cart_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("addresses");
                entity.Property(e => e.Id).HasColumnName("address_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.AddressLine1).HasColumnName("address_line_1");
                entity.Property(e => e.AddressLine2).HasColumnName("address_line_2");
                entity.Property(e => e.PostalCode).HasColumnName("postal_code");
                entity.Property(e => e.AddressType).HasColumnName("address_type");
            });
             
        }
    }
}
