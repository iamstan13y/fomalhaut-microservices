using AutoMapper;
using Discount.gRPC.Models;
using Discount.gRPC.Protos;

namespace Discount.gRPC.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
