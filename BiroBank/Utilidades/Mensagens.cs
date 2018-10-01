using BiroBank.Funcionarios;
using BiroBank.Parceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Mensagens {
    public class Mensagem {
        public void BoasVindas() {
            Console.WriteLine("#####################################################");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#    Bem-vindo(a) ao Biro Bank - O Banco Digital    #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#####################################################");
            Console.WriteLine();
        }

        public void BoasVindasFuncionarioLogado(Funcionario funcionario) {
            Console.WriteLine("#############################################################");                                                     
            Console.WriteLine($" Funcionario(a) {funcionario.Nome}, Bem-vindo(a) ao Sistema ");
            Console.WriteLine("#############################################################");
            Console.WriteLine();
        }

        public void BoasVindasParceiroLogado(Parceiro parceiro) {
            Console.WriteLine("#############################################################");
            Console.WriteLine($" Parceiro(a) {parceiro.Nome}, Bem-vindo(a) ao Sistema ");
            Console.WriteLine("#############################################################");
            Console.WriteLine();
        }

        public void ApresentarFuncionario(Funcionario funcionario) {
            if(funcionario.Situtação == "Empregado") {
                Console.WriteLine("#####################################################");
                Console.WriteLine($"              Ficha do funcionario                  ");
                Console.WriteLine($" Nome: {funcionario.Nome}");
                Console.WriteLine($" CPF: {funcionario.CPF}");
                Console.WriteLine($" Cargo: {funcionario.Cargo}");
                Console.WriteLine($" Salário: R$ {funcionario.GetSalarioFormatado()}");
                Console.WriteLine($" Situação: {funcionario.Situtação}");
                Console.WriteLine($" Data de admissão: {funcionario.GetDataAdmissao()}");
                Console.WriteLine("#####################################################\n");
            } else {
                Console.WriteLine("#####################################################");
                Console.WriteLine($"              Ficha do funcionario                  ");
                Console.WriteLine($" Nome: {funcionario.Nome}");
                Console.WriteLine($" CPF: {funcionario.CPF}");
                Console.WriteLine($" Cargo: {funcionario.Cargo}");
                Console.WriteLine($" Situação: {funcionario.Situtação}");
                Console.WriteLine($" Ultimo Salário: R$ {funcionario.GetSalarioFormatado()}");
                Console.WriteLine($" Data de admissão: {funcionario.GetDataAdmissao()}");
                Console.WriteLine($" Data da demissão: {funcionario.GetDataDemissao()}");
                Console.WriteLine("#####################################################\n");
            }
        }

        public void ExibirTotalBonificacao(double totalBonificacao) {
            Console.WriteLine($"Total de bonificações : {totalBonificacao}\n");
        }

        public void ExibirQuantidadeFuncionarios(int totalFuncionarios) {
            Console.WriteLine($"Total de funcionarios: {totalFuncionarios}\n");
        }

        
    }
}
