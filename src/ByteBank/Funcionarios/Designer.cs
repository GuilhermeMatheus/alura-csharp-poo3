using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double GetBonificacao()
        {
            return base.Salario * 0.1;
        }
    }
}
