namespace ProjetoConcessionaria.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }

        public Moto(string marca, string modelo, string ano, int quilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }

        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetPartida(string partida)
        {
            Partida = partida;
        }

        public string GetPartida()
        {
            return Partida;
        }

        public override double CalcularValor()
        {
            Valor = (Cilindrada * 50);
            if (Partida == "injecao eletronica")
            {
                Valor = Valor * 1.1;
            }
            return Valor;
        }
    }
}