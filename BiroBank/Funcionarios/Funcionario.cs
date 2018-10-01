using System;


namespace BiroBank.Funcionarios {
    public abstract class Funcionario {

        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public string Situtação { get; set; }
        public double Bonificacao;
        DateTime DataAdmissao;
        DateTime DataDemissao;
        

        public abstract double PorcentagemAumentoSalario();
        public abstract double GetBonificao();

        public Funcionario(string nome, string cpf, double salario) {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            Situtação = "Empregado";
        }

        public double SetSalario(double novoSalario) {
            return Salario = novoSalario;
        }

        public double GetSalario() {
            return Salario;
        }

        public string SetCargo(string cargo) {
            Cargo = cargo;
            return Cargo;
        }

        public DateTime SetDataAdmissao(DateTime admissao) {
            return DataAdmissao = admissao;
        }

        public string GetDataAdmissao() {
            return String.Format("{0}/{1}/{2}", DataAdmissao.Day, DataAdmissao.Month, DataAdmissao.Year);
        }

        public DateTime SetDataDemissao(DateTime demissao) {
            return DataDemissao = demissao;
        }

        public string GetDataDemissao() {
            return String.Format("{0}/{1}/{2}", DataDemissao.Day, DataDemissao.Month, DataDemissao.Year);
        }


        public string GetSalarioFormatado() {
            return string.Format("{0:0,0.00}", Salario);
        }
    }
}
