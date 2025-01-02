namespace Dominio.Entidade
{
    public class Usuario
    {
        public Usuario(string nome, string email, string senha, DateTime dataCriacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCriacao = dataCriacao;
        }

        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCriacao { get; private set; }
        // DÚVIDAS //
        // CRIAR O PROP COM ROLE?
        // PRIVATE DEVE FICAR EM TODOS?







    }
}