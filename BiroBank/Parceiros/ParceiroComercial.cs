using BiroBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Parceiros {
    public class ParceiroComercial : Parceiro {

        public ParceiroComercial(string nome, string cpfCnpj) : base(nome, cpfCnpj) {
            TipoDeParceiro = "Parceiro Comercial";
        }

    }
}
