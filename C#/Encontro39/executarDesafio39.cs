using Atacado.Modelo.RH;
using Atacado.FakeDB.RH;
using DesafiosDaGripe01;
using DesafiosDaGripe01.Problemas;
using System;
using Atacado.Modelo.IBGE;
using Atacado.FakeDB.IBGE;
using Atacado.Modelo.Ancestral;

namespace DesafioDaGripe01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ExecutarExercicioIBGE01();
            //ExecutarExercicioIBGE02();
            //ExecutarExercicioIBGE03();
            //ExecutarAtivarFuncionario();
            //ExecutarDesativarFuncionario();
            Console.ReadLine();
        }
        
        public static void ExecutarExercicioIBGE01()
        {
            Console.WriteLine("Informe o nome de um estado: ");
            string sigla = Console.ReadLine();
            List<Estado> estados = EstadoFakeDB.Estados.Where(pes => pes.SiglaUF == sigla.ToUpper()).ToList();
            ProblemasIBGE.ListarEstados(estados);
        }

        public static void ExecutarExercicioIBGE02()
        {
            Console.Write("Informe a sigla de um estado: ");
            string sigla = Console.ReadLine();
            List<Municipio> municipios = MunicipioFakeDB.Municipios.Where(pes => pes.SiglaUF == sigla.ToUpper()).ToList();
            Console.WriteLine("");
            ProblemasIBGE.ListarMunicipiosPorEstado(municipios);
        }

        public static void ExecutarExercicioIBGE03()
        { 
            Console.WriteLine("Informe o nome de uma região do Brasil: ");
            string regiao = Console.ReadLine();
            List<Estado> estados = EstadoFakeDB.Estados.Where(pes => pes.RegiaoBrasil.StartsWith(regiao)).ToList();
            ProblemasIBGE.ListarEstadosPorRegiao(estados);
        }

        public static void ExecutarAtivarFuncionario()
        {
            Console.WriteLine("Informe o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasFuncionario.AtivarRegistro(codigo);
        }

        public static void ExecutarDesativarFuncionario()
        {
            Console.WriteLine("Informe o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasFuncionario.InativarRegistro(codigo);
        }

    }
}
