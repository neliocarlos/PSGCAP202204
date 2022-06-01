using System;
using Atacado.Modelo.RH;
using Atacado.FakeDB.RH;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Modelo.Ancestral;

namespace DesafiosDaGripe01
{
    public static class ProblemasFuncionario
    {
        public static void DadosFuncionario(Funcionario empregado)
        {
            Console.Write("Nome: {0} ", empregado.Nome);
            Console.WriteLine("{0}", empregado.SobreNome);
            Console.WriteLine("Sexo: {0}", empregado.Sexo);
            Console.WriteLine("Email: {0}", empregado.Email);
            Console.WriteLine("Telefone: {0}", empregado.Telefone);
            Console.WriteLine("Situacao: {0}", empregado.Situacao);
        }
                
         public static Funcionario AtivarRegistro(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Ativo;
                DadosFuncionario(funcionario);
            }
            return funcionario;
        }

        public static Funcionario InativarRegistro(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Inativo;
                DadosFuncionario(funcionario);
            }
            return funcionario;
        }

    }
}
