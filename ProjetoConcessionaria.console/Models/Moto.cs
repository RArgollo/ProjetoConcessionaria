using ProjetoConcessionaria.console.Exceptions;
namespace ProjetoConcessionaria.Models
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }

        public Moto(string marca, string modelo, string ano, int quilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }

        public Moto()
        {

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

            if (Partida == "injecao eletronica")
            {
                Valor = (Valor + (Cilindrada * 50)) * 1.1;
            }
            return Valor;
        }

        public override void ValidarValor(double valor)
        {
            if (valor < 2000)
            {
                throw new InputInvalidoException("Valor deve ser maior que 5mil");
            }
            Valor = valor;
        }
    }
}