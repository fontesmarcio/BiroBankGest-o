using BiroBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Parceiros {
    public abstract class Parceiro : IAutenticavel {
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; private set; }
        public string TipoDeParceiro { get; set; }


        public Parceiro(string nome, string cpfCnpj) {
            Nome = nome;
            CPFCNPJ = cpfCnpj;
        }


        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
