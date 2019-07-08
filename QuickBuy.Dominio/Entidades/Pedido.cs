using QuickBuy.Dominio.ObjetoDeValor;       
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        /*Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos*/
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaDePagamentoId { get; set; }
        public FormaDePagamento FormadePagamento { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de pedido.");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve ser informado.");
            if (FormaDePagamentoId == 0)
                AdicionarCritica("Crítica - Não foi informada forma de pagamento.");
        }
    }
}
