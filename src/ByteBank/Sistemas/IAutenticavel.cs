using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        string Senha { get; set; }
        bool Autentica(string senha);
    }
}
