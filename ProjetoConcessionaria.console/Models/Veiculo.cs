namespace ProjetoConcessionaria.Models
{
    public class Veiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Ano { get; set; }
        protected int Quilometragem { get; set; }
        protected string Cor { get; set; }
        protected double Valor { get; set; }

        public Veiculo(string marca, string modelo, string ano, int quilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
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
            Ano = ano;
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
            Valor = valor;
        }

        public double GetValor()
        {
            return Valor;
        }

        public virtual double CalcularValor()
        {
            return Valor;
        }
    }
}