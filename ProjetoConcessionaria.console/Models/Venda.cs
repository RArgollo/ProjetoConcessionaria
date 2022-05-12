namespace ProjetoConcessionaria.Models
{
    public class Venda
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }

        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaPagamento, double valorFinal)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
            SetFormaPagamento(formaPagamento);
            SetValorFinal(valorFinal);
        }

        public Venda()
        {

        }

        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }

        public Cliente GetComprador()
        {
            return Comprador;
        }

        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }

        public Funcionario GetVendedor()
        {
            return Vendedor;
        }

        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }

        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }

        public void SetFormaPagamento(string formaPagamento)
        {
            FormaPagamento = formaPagamento;
        }

        public string GetFormaPagamento()
        {
            return FormaPagamento;
        }

        public void SetValorFinal(double valorFinal)
        {
            ValorFinal = valorFinal;
        }

        public double GetValorFinal()
        {
            return ValorFinal;
        }

        public double AplicarDesconto()
        {
            if (Vendedor.GetCargo() == "gerente")
            {
                ValorFinal = ValorFinal * 0.95;
            }
            return ValorFinal;
        }
    }
}