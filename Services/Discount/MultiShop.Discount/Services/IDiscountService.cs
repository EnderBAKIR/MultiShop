using MultiShop.Discount.DTOs;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();

        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);

        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);

        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);

        Task DeleteDiscountCouponAsync(int id);
        
        
    }
}
