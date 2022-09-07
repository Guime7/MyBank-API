using Core.Interfaces.Repositories;
using Core.Models;
using Infrastructure.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class CartaoCreditoRepository : ICartaoCreditoRepository
    {
        private MyBankContext _context;
        public CartaoCreditoRepository(MyBankContext context)
        {
            _context = context;
        }
        public CartaoCredito getCartao()
        {
            return
                (from c in _context.cartao_credito
                 select new CartaoCredito
                 {
                     idCartao = c.id_cartao,
                     nomeCartao = c.nome_cartao,
                     bandeira = c.bandeira,
                     emissor = c.emissor,
                     limite = c.limite,
                     status = c.status,
                 }).First();
        }
    }
}
