using AutoMapper;
using BACKEND.Models;
using BACKEND.Models.DTOs;

namespace BACKEND.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTORead>();
            CreateMap<User, UserDTOAdminRead>();
            CreateMap<UserDTORegister, User>();

            CreateMap<Category, CategoryDTORead>();
            CreateMap<CategoryDTOWrite, Category>();

            CreateMap<Product, ProductDTORead>();
            CreateMap<Product, ProductDTOAdminRead>()
                .ForCtorParam("CategoryIds", opt => opt.MapFrom(src => src.Categories.Select(c => c.Id).ToList()))
                .ForCtorParam("CategoryNames", opt => opt.MapFrom(src => src.Categories.Select(c=>c.CategoryName).ToList()));
            CreateMap<ProductDTOAdminWrite, Product>();

            CreateMap<Address, AddressDTORead>();
            CreateMap<AddressDTOWrite, Address>();

            CreateMap<Payment, PaymentDTORead>()
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId));
            CreateMap<Payment, PaymentDTOAdminRead>()
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.UserId))
                .ForCtorParam("OrderId", opt => opt.MapFrom(src => src.OrderId));
            CreateMap<PaymentDTOWrite, Payment>();

            CreateMap<ProductOrder, ProductOrderDTO>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.ProductId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Price))
                .ForCtorParam("ImageUrl", opt => opt.MapFrom(src => src.Product.ImageUrl));
            CreateMap<ProductOrder, ProductOrderDTOAdminRead>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.ProductId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Price))
                .ForCtorParam("Sku", opt => opt.MapFrom(src => src.Product.Sku));

            CreateMap<Order, OrderDTORead>()
                .ForCtorParam("ShippingAddress", opt => opt.MapFrom(src => src.ShippingAddress))
                .ForCtorParam("BillingAddress", opt => opt.MapFrom(src => src.BillingAddress))
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.ProductOrders));
            CreateMap<Order, OrderDTOAdminRead>()
                .ForCtorParam("UserId", opt => opt.MapFrom(src => src.UserId))
                .ForCtorParam("ShippingAddress", opt => opt.MapFrom(src => src.ShippingAddressId))
                .ForCtorParam("BillingAddress", opt => opt.MapFrom(src => src.BillingAddressId))
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.ProductOrders));

            CreateMap<CartProduct, CartProductDTO>()
                .ForCtorParam("ProductId", opt => opt.MapFrom(src => src.ProductId))
                .ForCtorParam("Name", opt => opt.MapFrom(src => src.Product.Name))
                .ForCtorParam("Price", opt => opt.MapFrom(src => src.Product.Price))
                .ForCtorParam("ImageUrl", opt => opt.MapFrom(src => src.Product.ImageUrl));
            CreateMap<Cart, CartDTORead>()
                .ForCtorParam("Products", opt => opt.MapFrom(src => src.CartProducts));
        }
    }
}
