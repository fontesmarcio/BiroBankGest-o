using BiroBank.Funcionarios;


namespace BiroBank.Sistemas {
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario) { }

        public bool Autenticar(string senha) {
            return Senha == senha;
        }

    }
}
