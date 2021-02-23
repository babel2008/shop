using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
         Task<CustomerBasket> GetBasketAsync(string baskedId);
         Task<CustomerBasket> UpdateBasketAsync(CustomerBasket backet);
         Task<bool> DeleteBasketAsync(string baskedId);
    }
}