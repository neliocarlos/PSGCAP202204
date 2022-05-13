using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Desafio_031();
            //Desafio_032();
            //Desafio_033();
            //Desafio_034();
            //Desafio_035();
            //Desafio_036();
            //Desafio_037();
            //Desafio_038();
            //Desafio_039();
            //Desafio_040();
        
        public static void Desafio_031()
        {
            Console.Write("Informe um número: ");
            float num = Convert.ToSingle(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", num);
                Console.WriteLine("O número {0} é múltiplo de 2.", num);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", num);
            }
            if (num % 3 == 0)
            {
                Console.WriteLine("O número {0} é múltiplo de 3.", num);
            }
            if (num % 5 == 0)
            {
                Console.WriteLine("O número {0} é múltiplo de 5.", num);
            }
        }

        public static List<string> ListaParaDesafios()
        {
            List<string> list = new List<string>();
            list.Add("Neymar");
            list.Add("Casemiro");
            list.Add("Rodrygo");
            list.Add("Alisson");
            list.Add("Gabriel");
            list.Add("Ederson");
            list.Add("Antony");
            list.Add("Vinicius");
            list.Add("Paquetá");
            list.Add("Raphinha");
            list.Add("Éder");
            list.Add("Roberto");
            list.Add("Phillipe");
            list.Add("Cristiano");
            list.Add("Bernardo");
            list.Add("Icardi");
            list.Add("Mbappe");
            list.Add("Módric");
            list.Add("Bruno");
            list.Add("Pogba");
            return list;
        }

        public static void Desafio_032()
        {
            List<string>  alunos = ListaParaDesafios();
            List<int> idades = new List<int>();
            for (int i = 0; i < alunos.Count(); i++)
            {
                Console.Clear();
                Console.Write("Informe a idade do aluno {0}: ", alunos[i]);
                idades.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int total = 0;
            foreach (int s in idades)
            {
                total = total + s;
            }
            float media = total / alunos.Count();

            for (int x = 0; x < alunos.Count(); x++)
            {
                Console.WriteLine("Aluno {0}. Idade {1}", alunos[x], idades[x]);
            }

            Console.WriteLine("A média de idade dos alunos é de {0} anos.", media);
        }

        public static void Desafio_033()
        {
            List<string> nomes = ListaParaDesafios();
            List<int> idades = new List<int>();
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.Write("Informe a idade de {0}: ", nomes[i]);
                idades.Add(Convert.ToInt32(Console.ReadLine()));
                if (idades[i] > 18)
                {
                    contador++;
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("{0}: {1} anos", nomes[x], idades[x]);
            }
            Console.WriteLine("{0} possuem mais de 18 anos.", contador);

        }

        public static void Desafio_034()
        {
            int soma = 0;
            for (int x = 1; x <= 1000; x++)
            {
                soma = soma + x;
            }
            Console.WriteLine(soma);
        }

        public static void Desafio_035()
        {
            for (int x = 1; x <= 100; x++)
            {
                if (x % 3 == 0)
                {
                    Console.Write(x+", ");
                }
            }
        }

        public static void Desafio_036()
        {
            List<string> nome = ListaParaDesafios();
            List<int> idade = new List<int>();
            List<string> nacionalidade = new List<string>();
            int contadorApto = 0;
            int contadorNaoApto = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.Clear();
                Console.Write("Informe a idade de {0}: ", nome[x]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Informe a nacionalidade de {0}: ", nome[x]);
                nacionalidade.Add(Console.ReadLine());
                if (idade[x] >= 16 && nacionalidade[x].ToUpper() == "BRASILEIRO" || nacionalidade[x].ToUpper() == "BRASILEIRA")
                {
                    contadorApto++;
                }
                else
                {
                    contadorNaoApto++;
                }
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} -- {1} anos -- {2}.", nome[i], idade[i], nacionalidade[i]);
            }
            Console.WriteLine("{0} aptos e {1} não aptos.", contadorApto, contadorNaoApto);
        }

        public static void Desafio_037()
        {
            List<string> nomes = ListaParaDesafios();
            List<double> salario = new List<double>();
            List<double> salarioReaj = new List<double>();
            for (int i = 0; i < nomes.Count(); i++)
            {
                Console.Clear();
                Console.Write("Informe o salário do funcionário/a {0}.", nomes[i]);
                salario.Add(Convert.ToSingle(Console.ReadLine()));
                if (salario[i] <= 300)
                {
                    double reajuste = salario[i] * 0.5;
                    salarioReaj.Add(salario[i] + reajuste);
                }
                else if (salario[i] > 300)
                {
                    double reajuste = salario[i] * 0.3;
                    salarioReaj.Add(salario[i] + reajuste);
                }
            }
            for (int x = 0; x < nomes.Count(); x++)
            {
                Console.WriteLine("Funcionário {0}: salário de R${1} reajustado para R${2}", nomes[x], salario[x], salarioReaj[x]);
            }
        }

        public static void Desafio_038()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma = soma + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Soma desses valores = {0}.", soma);
        }

        public static void Desafio_039()
        {
            for (int i = 1; i <= 120; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Desafio_040()
        {
            List<string> lista = ListaParaDesafios();
            List<string> alunos = new List<string>();
            List<int> matricula = new List<int>();
            List<float> altura = new List<float>();
            float menorAlt = 0;
            float maiorAlt = 0;
            int codMenorAlt = 0;
            int codMaiorAlt = 0;
            for (int i = 0; i < 10; i++)
            {
                alunos.Add(lista[i]);
                Console.Clear();
                matricula.Add(1000 + i);
                Console.WriteLine("Informe a altura do aluno(a): {0}.", alunos[i]);
                altura.Add(Convert.ToSingle(Console.ReadLine()));
                if (i == 0)
                {
                    menorAlt = altura[i];
                    maiorAlt = altura[i];
                    codMenorAlt = matricula[i];
                    codMaiorAlt = matricula[i];
                }
                else if (altura[i] < menorAlt)
                {
                    menorAlt = altura[i];
                    codMenorAlt = matricula[i];
                }
                else if (altura[i] > maiorAlt)
                {
                    maiorAlt = altura[i];
                    codMaiorAlt = matricula[i];
                }
            }
            Console.Clear();
            for (int x = 0; x < alunos.Count(); x++)
            {
                Console.WriteLine("Aluno {0} -- matricula {1} -- altura {2}", alunos[x], matricula[x], altura[x]);
            }
            Console.WriteLine("Código e altura do aluno mais alto: {0} -- {1}m.", codMaiorAlt, maiorAlt);
            Console.WriteLine("Código e altura do aluno mais baixo: {0} -- {1}m.", codMenorAlt, menorAlt);
        }
    }
}
