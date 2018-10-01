using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiroBank.Funcionarios {
    public class Designer : Funcionario{

        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario) {
            SetCargo("Designer");
        }

        public override double GetBonificao() {
            return Bonificacao = Salario * 0.17;
        }

        public override double PorcentagemAumentoSalario() {
            return 1.11;
        }
    }
}
