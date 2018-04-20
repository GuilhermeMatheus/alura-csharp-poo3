using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Utilidades
{
    public static class VerificadorSenha
    {
        public static bool Verificar(string senhaRecebida, string senhaVerdadeira)
        {
            return senhaRecebida == senhaVerdadeira;
        }
    }
}
