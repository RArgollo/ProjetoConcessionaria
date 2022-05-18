namespace ProjetoConcessionaria.Models
{
    public class Funcionario : Pessoa
    {
        private string Cargo { get; set; }

        public Funcionario(string nome, string cpf, string dataNascimento, string cargo) : base(nome, cpf, dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
            SetCargo(cargo);
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