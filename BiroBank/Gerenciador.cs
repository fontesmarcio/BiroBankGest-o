using BiroBank.Funcionarios;
using System;


namespace BiroBank {
    public class Gerenciador  {
        private double _totalBonificacao;
        public static int TotalDeFuncionarios { get; private set; }

        public void Admitir(Funcionario funcionario, DateTime admissao) {
            funcionario.SetDataAdmissao(admissao);
            funcionario.Situtação = "Empregado";
            RegistrarBonificacaoNoTotal(funcionario);
            TotalDeFuncionarios++;
        }


        public void Demitir(Funcionario funcionario, DateTime demissao) {
            funcionario.SetDataDemissao(demissao);
            funcionario.Situtação = "Demitido";
            RetirarBonificacaoDoTotal(funcionario);
            TotalDeFuncionarios--;
        }

        private void RegistrarBonificacaoNoTotal(Funcionario funcionario) {
            funcionario.GetBonificao();
            _totalBonificacao += funcionario.Bonificacao;
        }

        private void RetirarBonificacaoDoTotal(Funcionario funcionario) {
            funcionario.GetBonificao();
            _totalBonificacao -= funcionario.Bonificacao;
        }

        private double AtualizarTotalBonificacao(Funcionario funcionario) {
            funcionario.GetBonificao();
            return _totalBonificacao += funcionario.Bonificacao;
        }

        public double GetTotalBonificacao() {
            return _totalBonificacao;
        }

        public int GetTotalDeFuncionarios() {
            return TotalDeFuncionarios;
        }

        public double AumentarSalario(Funcionario funcionario) {
            double novoSalario = funcionario.GetSalario() + ( funcionario.GetSalario() * funcionario.PorcentagemAumentoSalario());
            AtualizarTotalBonificacao(funcionario);
            return funcionario.SetSalario(novoSalario);
        }

    }
}
