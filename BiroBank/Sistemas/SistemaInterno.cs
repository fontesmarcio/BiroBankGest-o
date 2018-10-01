using BiroBank.Funcionarios;
using BiroBank.Mensagens;
using BiroBank.Parceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Sistemas {
    class SistemaInterno {
        public bool LogarParceiro(Parceiro parceiro, string senha) {

            Mensagem mensagens = new Mensagem();

            bool parceiroAutenticado = parceiro.Autenticar(senha);

            if (parceiroAutenticado) {
                mensagens.BoasVindasParceiroLogado(parceiro);
                return true;
            } else {
                Console.WriteLine("Senha incorreta!\n");
                return false;
            }

        }

        public bool LogarFuncionario(FuncionarioAutenticavel funcionario, string senha) {

            Mensagem mensagens = new Mensagem();

            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado) {
                mensagens.BoasVindasFuncionarioLogado(funcionario);
                return true;
            } else {
                Console.WriteLine("Senha incorreta!\n");
                return false;
            }

        }
    }
}
