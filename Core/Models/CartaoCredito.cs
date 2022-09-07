using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CartaoCredito
    {
        public Guid idCartao { get; set; }
        public string? nomeCartao { get; set; }
        public string? emissor { get; set; }
        public string? bandeira { get; set; }
        public decimal? limite { get; set; }
        public bool? status { get; set; }
    }
}
