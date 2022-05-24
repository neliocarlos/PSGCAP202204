
using CapConsoleApp2.EstudoPOO;
using Models;
using FakeDB.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp.Desafios
{
    public class DesafioDojo2
    {
        private List<Estado> listaEstadosRegiaoSelecionada;
        private List<Municipio> listaConsultarMunicipioPeloNome;
        private List<Estado> estados;
        private List<Estado> sigla;
        private List<Municipio> listaMunicipioPorEstado;
        private List<Municipio> pesquisarMunicipioPorIBGE7;
        private List<Municipio> pesquisarMunicipioPorCep;

        public DesafioDojo2()
        {

        }

        public void Executar()
        {
            this.PesquisarPorNome();
            this.PesquisarPorSigla();
            this.ListaEstadosRegiao();
            this.ConsultarMunicipioPeloNome();
            this.ListaMunicipiosPorEstado();
            this.PesquisarMunicipioPorIBGE7();
            this.PesquiseMunicipioPorCep();
        }

        /// <summary>
        /// KALI
        /// </summary>
        private void PesquisarPorNome()
        {
            Console.Write("Digite o nome de um Estado: ");
            string nome = Console.ReadLine();
            this.estados = FakeDB.IBGE.EstadoFakeDB.Estados.Where(pes => pes.NomeEstado.StartsWith(nome)).ToList();
            Console.WriteLine("número de estados encontrados: {0}.", this.estados.Count());
            foreach (Estado item in this.estados)
            {
                Console.WriteLine("- Estado encontrado -");
                item.ImprimirSigla();
                item.ImprimirRegiao();
            }
            Console.WriteLine();
        }

        private void PesquisarPorSigla()
        {

            while (true)
            {
                Console.Write("Digite uma Sigla de Estado: ");
                string nome = Console.ReadLine();
                if (nome.Length != 2)
                {
                    Console.WriteLine("Sigla não encontrada, digite novamente!");
                }
                this.sigla = FakeDB.IBGE.EstadoFakeDB.Estados.Where(pes => pes.Siglauf == nome).ToList();
                Console.WriteLine("número de Siglas encontradas: {0}.", this.sigla.Count());
                foreach (Estado item in this.sigla)
                {
                    Console.WriteLine("- Sigla encontrada -");
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                }
                Console.Write("Deseja parar (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// NELIO
        /// </summary>
        private void ListaEstadosRegiao()
        {
            while (true)
            {
                Console.WriteLine("-Lista para mostrar todos os estados da região desejada-");
                Console.WriteLine("Escolha a região desejada: ");
                string regiao = Console.ReadLine();
                this.listaEstadosRegiaoSelecionada = FakeDB.IBGE.EstadoFakeDB.Estados
                    .Where(pes => pes.NomeRegiao.ToUpper() == regiao || pes.NomeRegiao.ToLower() == regiao || pes.NomeRegiao == regiao)
                    .ToList();
                Console.WriteLine("Estados da regiao {0}:", regiao);
                foreach (Estado item in this.listaEstadosRegiaoSelecionada)
                {
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                }
                if (this.listaEstadosRegiaoSelecionada.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa região não existe.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// LUCAS
        /// </summary>
        private void ConsultarMunicipioPeloNome()
        {

            while (true)
            {
                Console.Write("Qual o município que você procura? >");
                string nomem = Convert.ToString(Console.ReadLine());

                this.listaConsultarMunicipioPeloNome = MunicipioFakeDB.Municipios.Where(pes => pes.NomeMunicipio == nomem).ToList();
                foreach (Municipio item in this.listaConsultarMunicipioPeloNome)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    item.ImprimirSigla();
                    Console.ResetColor();

                }
                if (this.listaConsultarMunicipioPeloNome.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existe ninguem com esse nome");
                    Console.ResetColor();
                }

                Console.Write("Deseja parar (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// MATHEUS
        /// </summary>
        public void ListaMunicipiosPorEstado()
        {
            Console.WriteLine("-- EXERCÍCIO  8");
            Console.WriteLine("Digite a sigla do estado (RO): ");
            string opcao = Console.ReadLine();
            this.listaMunicipioPorEstado = MunicipioFakeDB.Municipios.Where(pes => pes.Siglauf == opcao).ToList();
            if (this.listaMunicipioPorEstado.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.listaMunicipioPorEstado)
                {
                    item.ImprimirSigla();
                }
            }
            Console.WriteLine("Total de Registros: {0}", this.listaMunicipioPorEstado.Count());
            Console.ReadLine();
            Console.WriteLine();
        }

        /// <summary>
        /// ANDRESSA
        /// </summary>
        public void PesquisarMunicipioPorIBGE7()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 09 --");
            Console.WriteLine("Digite o Código do IBGE: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            this.pesquisarMunicipioPorIBGE7 = MunicipioFakeDB.Municipios.Where(pes => pes.Ibge7 == resposta).ToList();
            if (this.pesquisarMunicipioPorIBGE7.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.pesquisarMunicipioPorIBGE7)
                {
                    item.ImprimirSigla();
                }
            }
            Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorIBGE7.Count());
            Console.WriteLine();
        }

        public void PesquiseMunicipioPorCep()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 10 --");
            Console.WriteLine("Digite o CEP: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            this.pesquisarMunicipioPorCep = MunicipioFakeDB.Municipios.Where(pes => pes.Cep == resposta).ToList();
            if (this.pesquisarMunicipioPorCep.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.pesquisarMunicipioPorCep)
                {
                    item.ImprimirSigla();
                }

            }
            Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorCep.Count());
            Console.WriteLine("-- FIM EXERCÍCIO 10 --");
            Console.ReadLine();

        }
    }
}
