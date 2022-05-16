using ProjetoConcessionaria.console.Exceptions;
namespace ProjetoConcessionaria.Models
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string cpf, string dataNascimento, string email, string telefone) : base(nome, cpf, dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
            SetEmail(email);
            SetTelefone(telefone);
        }

        public Cliente()
        {

        }


        public void SetEmail(string email)
        {
            ValidacaoEmail(email);
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetTelefone(string telefone)
        {
           ValidacaoTelefone(telefone);
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public void ValidacaoTelefone(string telefone)
        {
            if (telefone.Length < 8 || telefone.Length < 15)
            {
                Telefone = telefone;
            }
            else
            {
                throw new InputInvalidoException("Telefone deve ter entre 8 e 15 dígitos");
            }
        }

        public void ValidacaoEmail(string email){
            if (email.Contains("@")){
                Email = email;
            }
            else{
                throw new InputInvalidoException("Email inválido");
            }
        }
    }
}