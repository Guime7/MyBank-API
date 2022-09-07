using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CartaoCredito
    {
        public string? id_cartao { get; set; }

        public string? nome_cartao { get; set; }

        public string? emissor { get; set;}

        public string? bandeira { get; set; }

        public decimal limite { get; set; }

        public string? status { get; set; }
    }
}
