using ProjetoConcessionaria.console.Exceptions;
namespace ProjetoConcessionaria.Models
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }

        public Veiculo(string marca, string modelo, string ano, int quilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
        }

        public Veiculo()
        {
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetAno(string ano)
        {
            ValidarAno(ano);
        }

        public string GetAno()
        {
            return Ano;
        }

        public void SetQuilometragem(int quilometragem)
        {
            Quilometragem = quilometragem;
        }

        public int GetQuilometragem()
        {
            return Quilometragem;
        }

        public void SetCor(string cor)
        {
            Cor = cor;
        }

        public string GetCor()
        {
            return Cor;
        }

        public void SetValor(double valor)
        {
            ValidarValor(valor);
        }

        public double GetValor()
        {
            return Valor;
        }

        public virtual double CalcularValor()
        {
            return Valor;
        }

        public void ValidarAno(string ano)
        {
            var anoData = DateTime.Parse($"01/01/{ano}");
            if (anoData.Year > 2004)
            {
                Ano = ano;
            }
            else
            {
                throw new InputInvalidoException("Ano deve ser maior que 2004");
            }
        }

        public virtual void ValidarValor(double valor){

        }
    }
}