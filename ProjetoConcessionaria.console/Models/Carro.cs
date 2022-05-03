namespace ProjetoConcessionaria.Models
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }
        public Carro(string marca, string modelo, string ano, int quilometragem, string cor, double valor, string combustivel, bool transmissaoAutomatica) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
            SetCombustivel(combustivel);
            SetTransmissaoAutomatica(transmissaoAutomatica);
        }

        public void SetTransmissaoAutomatica(bool transmissaoAutomatica)
        {
            TransmissaoAutomatica = transmissaoAutomatica;
        }

        public bool GetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }

        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }

        public string GetCombustivel()
        {
            return Combustivel;
        }

        public override double CalcularValor()
        {
            if (TransmissaoAutomatica)
            {
                Valor = Valor * 1.20;
            }
            return Valor;
        }
    }
}