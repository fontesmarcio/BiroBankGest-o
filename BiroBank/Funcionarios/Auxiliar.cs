using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Funcionarios {
    public class Auxiliar : Funcionario {

        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario) {
            SetCargo("Auxiliar");
        }

        public override double GetBonificao() {
            return Bonificacao = Salario * 0.2;
        }

        public override double PorcentagemAumentoSalario() {
            return 1.1;
        }
    }
}
