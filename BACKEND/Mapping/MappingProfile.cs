using AutoMapper;
using BACKEND.Models;
using BACKEND.Models.DTOs;

namespace BACKEND.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTORead>()
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.Id));
            CreateMap<User, UserDTOAdminRead>()
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.Id));
            CreateMap<UserDTOWrite, User>();

            CreateMap<Category, CategoryDTORead>()
                .ForCtorParam("CategoryId", opt => opt.MapFrom(src => src.Id));
            CreateMap<CategoryDTOWrite, Category>();

            CreateMap<Product, ProductDTORead>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.Id));
            CreateMap<Product, ProductDTOAdminRead>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("CategoryIds", opt => opt.MapFrom(src => src.Categories.Select(c => c.Id).ToList()))
                .ForCtorParam("CategoryNames", opt => opt.MapFrom(src => src.Categories.Select(c=>c.CategoryName).ToList()));
            CreateMap<ProductDTOAdminWrite, Product>();

            CreateMap<Address, AddressDTORead>()
                .ForCtorParam("AddressId", opt => opt.MapFrom(src => src.Id));
            CreateMap<AddressDTOWrite, Address>();

            CreateMap<Payment, PaymentDTORead>()
                .ForCtorParam("PaymentId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId));
            CreateMap<Payment, PaymentDTOAdminRead>()
                .ForCtorParam("PaymentId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.UserId))
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId));
            CreateMap<PaymentDTOWrite, Payment>();
            CreateMap<PaymentDTOAdminUpdate, Payment>();

            CreateMap<ProductOrder, ProductOrderDTO>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Price))
                .ForCtorParam("ImageUrl", opt => opt.MapFrom(src => src.Product.ImageUrl));
            CreateMap<ProductOrder, ProductOrderDTOAdminRead>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Price))
                .ForCtorParam("Sku", opt => opt.MapFrom(src => src.Product.Sku));
            CreateMap<ProductOrderDTOWrite, ProductOrder>();

            CreateMap<Order, OrderDTORead>()
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("ShippingAddress", opt => opt.MapFrom(src => src.ShippingAddress))
                .ForCtorParam("BillingAddress", opt => opt.MapFrom(src => src.BillingAddress))
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.ProductOrders));
            CreateMap<Order, OrderDTOAdminRead>()
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.UserId))
                .ForCtorParam("ShippingAddress", opt => opt.MapFrom(src => src.ShippingAddressId))
                .ForCtorParam("BillingAddress", opt => opt.MapFrom(src => src.BillingAddressId))
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.ProductOrders));
            CreateMap<OrderDTOWrite, Order>();
            CreateMap<OrderDTOAdminUpdate, Order>();

            CreateMap<CartProduct, CartProductDTO>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.ProductId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Product.Price))
                .ForCtorParam("ImageUrl", opt => opt.MapFrom(src => src.Product.ImageUrl));
            CreateMap<CartProductDTOWrite, CartProduct>();
            CreateMap<Cart, CartDTORead>()
                .ForCtorParam("CartId", opt => opt.MapFrom(src => src.Id))
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.CartProducts))
                    .ForCtorParam("TotalAmount", opt => opt.MapFrom(
        src => src.CartProducts.Sum(cp => cp.Product.Price * cp.Quantity)
    ));
            CreateMap<CartDTOWrite, Cart>();
        }


    }
}
