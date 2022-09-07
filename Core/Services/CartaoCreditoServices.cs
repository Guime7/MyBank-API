using Core.Interfaces.Services;
using Core.Interfaces.Repositories;
using Core.Models;

namespace Core.Services
{
    public class CartaoCreditoServices : ICartaoCreditoServices
    {
        private ICartaoCreditoRepository _cartaoCreditoRepository;
        public CartaoCreditoServices(ICartaoCreditoRepository cartaoCreditoRepository)
        {
            _cartaoCreditoRepository = cartaoCreditoRepository;
        }

        public CartaoCredito GetCartao()
        {
            return new CartaoCredito();
        }
    }
}
