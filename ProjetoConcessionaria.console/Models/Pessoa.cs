namespace ProjetoConcessionaria.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
        }

        public Pessoa()
        {
            
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }

        public string GetCPF()
        {
            return CPF;
        }

        public void SetDataNascimento(string dataNascimento)
        {
            DataNascimento = DateTime.Parse(dataNascimento);
        }

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
    }
}