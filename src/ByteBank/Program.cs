using ByteBank.Contas;
using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarFuncionarios();
            RegistrarContas();

            Console.ReadLine();
        }

        private static void RegistrarContas()
        {
            Conta contaBruno = new ContaCorrente(836, 836754);
            Cliente bruno = new Cliente();
            bruno.Nome = "Bruno";
            contaBruno.Titular = bruno;
            contaBruno.Depositar(100);

            Conta contaLarissa = new ContaPoupanca(836, 836755, new DateTime(2020, 2, 5));
            Cliente larissa = new Cliente();
            larissa.Nome = "Larissa";
            contaLarissa.Titular = larissa;
            contaLarissa.Depositar(100);

            contaLarissa.Sacar(50);
            contaBruno.Sacar(50);

            EscreverContaESaldo(contaLarissa);
            EscreverContaESaldo(contaBruno);
        }

        private static void EscreverContaESaldo(Conta conta)
        {
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
        }

        private static void RegistrarFuncionarios()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            List<Funcionario> funcionarios = ObterFuncionariosLista();

            for (int indice = 0; indice < funcionarios.Count; indice++)
            {
                gerenciadorBonificacao.Registrar(funcionarios[indice]);
            }

            Console.WriteLine(gerenciadorBonificacao.ValorTotal);
        }

        private static Funcionario[] ObterFuncionariosArray()
        {
            Funcionario[] funcionarios = new Funcionario[3];

            Designer eduardo = new Designer();
            eduardo.Nome = "Eduardo";
            eduardo.Salario = 5000;
            funcionarios[0] = eduardo;

            Diretor carlos = new Diretor();
            carlos.Nome = "Carlos";
            carlos.Salario = 7000;
            funcionarios[1] = carlos;

            AdministradorDeSistemas bruna = new AdministradorDeSistemas();
            bruna.Nome = "Bruna";
            bruna.Salario = 7000;
            funcionarios[2] = bruna;

            return funcionarios;
        }

        private static List<Funcionario> ObterFuncionariosLista()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Designer eduardo = new Designer();
            eduardo.Nome = "Eduardo";
            eduardo.Salario = 5000;
            funcionarios.Add(eduardo);

            Diretor carlos = new Diretor();
            carlos.Nome = "Carlos";
            carlos.Salario = 7000;
            funcionarios.Add(carlos);

            AdministradorDeSistemas bruna = new AdministradorDeSistemas();
            bruna.Nome = "Bruna";
            bruna.Salario = 7000;
            funcionarios.Add(bruna);

            return funcionarios;
        }
    }
}
