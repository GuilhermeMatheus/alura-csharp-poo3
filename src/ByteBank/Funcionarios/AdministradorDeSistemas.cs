using ByteBank.Sistemas;
using ByteBank.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class AdministradorDeSistemas : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autentica(string senha)
        {
            return VerificadorSenha.Verificar(senha, this.Senha);
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.5;
        }
    }
}
