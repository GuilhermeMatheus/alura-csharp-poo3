using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Entrar(IAutenticavel autenticavel, string senha)
        {
            bool autenticado = autenticavel.Autentica(senha);

            if (!autenticado)
            {
                Console.WriteLine("Ops, não pode entrar no Sistema Interno.");
                return false;
            }

            Console.WriteLine("Bem vindo ao Sistema Interno.");
            return true;
        }
    }
}
