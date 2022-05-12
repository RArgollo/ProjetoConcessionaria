namespace ProjetoConcessionaria.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string cpf, string dataNascimento, string cargo) : base(nome, cpf, dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
            SetCargo(cargo);
        }

        public Funcionario()
        {

        }

        public void SetCargo(string cargo)
        {
            Cargo = cargo;
        }

        public string GetCargo()
        {
            return Cargo;
        }
    }
}