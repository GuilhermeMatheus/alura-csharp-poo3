using ByteBank.Sistemas;
using ByteBank.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public string Senha { get; set; }

        public ParceiroComercial(string nome, string cnpj)
        {
            Nome = nome;
            CNPJ = cnpj;
        }

        public bool Autentica(string senha)
        {
            return VerificadorSenha.Verificar(senha, this.Senha);
        }
    }
}
