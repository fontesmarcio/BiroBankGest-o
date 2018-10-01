using System;
using BiroBank.Funcionarios;
using BiroBank.Mensagens;
using BiroBank.Parceiros;
using BiroBank.Sistemas;

namespace BiroBank {
    class Program {
        static void Main(string[] args) {
            Mensagem mensagem = new Mensagem();
            Gerenciador gerenciador = new Gerenciador();

            Diretor roberta = new Diretor("Roberta", "546.000.000-28", 5000);
            GerenteDeConta jorge = new GerenteDeConta("Jorge", "546.000.001-28", 4200);
            Designer tayara = new Designer("Tayara", "546.001.001-28", 3200);
            Auxiliar mateus = new Auxiliar("Mateus", "544.001.001-28", 1200);

            gerenciador.Admitir(roberta, new DateTime(2016, 08, 15));
            gerenciador.Admitir(jorge, new DateTime(2016, 07, 15));
            gerenciador.Admitir(tayara, new DateTime(2017, 07, 15));
            gerenciador.Admitir(mateus, new DateTime(2018, 02, 15));

            gerenciador.AumentarSalario(jorge);
            gerenciador.AumentarSalario(mateus);

            mensagem.BoasVindas();

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Consultar ficha de funcionários");
            Console.WriteLine("2 - Logar no sistema");
            var escolha = Console.ReadLine();
            Console.WriteLine();

            if (escolha == "1") {
                mensagem.ApresentarFuncionario(roberta);
                mensagem.ApresentarFuncionario(jorge);
                mensagem.ApresentarFuncionario(tayara);
                mensagem.ApresentarFuncionario(mateus);

                mensagem.ExibirTotalBonificacao(gerenciador.GetTotalBonificacao());
                mensagem.ExibirQuantidadeFuncionarios(gerenciador.GetTotalDeFuncionarios());

            } else if (escolha == "2") {
                UsarSistema();
            } else {
                Console.WriteLine("Opção inválida!");
            }

        }

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("Roberta", "546.000.000-28", 5000);
            roberta.Senha = "123";

            GerenteDeConta jorge = new GerenteDeConta("Jorge", "546.000.001-28", 4200);
            jorge.Senha = "124";

            ParceiroComercial cleyton = new ParceiroComercial("Cleyton", "750.899.789");
            cleyton.Senha = "128";

            sistemaInterno.LogarFuncionario(roberta, "123");
            sistemaInterno.LogarFuncionario(jorge, "124");
            sistemaInterno.LogarParceiro(cleyton, "128");
        }


    }
}
