using ProjetoConcessionaria.Lib.Exceptions;

namespace ProjetoConcessionaria.Lib.Models
{

    public class Cliente : Pessoa
    {
        private string Email { get; set; }
        private string Telefone { get; set; }
        public virtual List<Venda> Vendas { get; set; }

        public Cliente(string nome, string cpf, string dataNascimento, string email, string telefone) : base(nome, cpf, dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
            SetEmail(email);
            SetTelefone(telefone);
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
            if (telefone.Length < 8 || telefone.Length > 15)
            {

                throw new InputInvalidoException("Telefone deve ter entre 8 e 15 dígitos");
            }
            else
            {
                Telefone = telefone;
            }
        }

        public void ValidacaoEmail(string email)
        {
            if (email.Contains("@"))
            {
                Email = email;
            }
            else
            {
                throw new InputInvalidoException("Email inválido");
            }
        }
    }
}