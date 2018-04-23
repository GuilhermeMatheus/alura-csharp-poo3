using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenciadorBonificacao
    {
        public double ValorTotal { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            Console.WriteLine("Registrando funcionário " + funcionario.Nome);
            ValorTotal += funcionario.GetBonificacao();
        }
    }
}
