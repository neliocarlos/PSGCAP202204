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
            //Encontro22_Codigo01();
            //Encontro22_Codigo02();
            //Desafio_001();
            //Desafio_002();
            //Desafio_003();
            //Desafio_004();
            //Desafio_005();
            //Desafio_006();
            //Desafio_007();
            //Desafio_008();
            //Desafio_009();
            //Desafio_010();
            //Encontro24_Codigo01();
            //Desafio_011();
            //Desafio_012();
            //Encontro24_Codigo02();
            //Desafio_013();
            //Desafio_014();
            //Desafio_015();
            //Desafio_016();
            //Desafio_017();
            //Desafio_018();
            //Desafio_019();
            //Desafio_020();
            //Desafio_021();
            //Desafio_022();
            //Desafio_023();
            //Desafio_024();
            //Desafio_025();
            //Desafio_026();
            //Desafio_027();
            //Desafio_028();
            //Desafio_029();
            //Desafio_030();
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

            Console.ReadLine();
        }

        /// <summary>
        /// Desafios:
        /// 001 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz quadrada.
        /// 002 - Desenvolva um programa que leia as duas notas de um aluno,  calcule e mostre a sua média.
        /// 003 - Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.
        /// 004 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
        /// 005 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos dólares ela pode comprar. Considere US$ 1,00 = R$ 5,00
        /// 006 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule a sua área e a quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.
        /// 007 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com 5% de desconto.
        /// 008 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário, com 15% de aumento.
        /// 009 – Escreva um programa que converta uma temperatura digitada em graus celsius para farenheit.
        /// 010 – Escreva um programa que pergunte a quantidade de km percorridos por um carro alugado, e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo que o carro custa R$ 60,00 por dia e R$ 0,15 por km rodado.
        /// 011 – um professor quer armazenas o nome dos seus alunos para realizar algumas tarefas.Faça um programa que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados.
        /// 012 – o mesmo professor quer agora, além de exibir, ordenar a lista. Faça um programa que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados, de forma ordenada.
        /// 013 – o mesmo professor quer sortear um dos seus alunos para apagar o quadro. Faça um programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido. 
        /// 014 – o mesmo professor quer sortear a ordem de apresentação de trabalhos dos alunos. Faça um programa que leia o nome dos quatro alunos e a ordem sorteada.
        /// 015 – agora, o professor deseja sortear da lista embaralha quem será o primeiro apresentar o trabalho. Faça um programa que leia o nome dos alunos, embaralhe a ordem de apresentação e sorteie um destes alunos para apresentar primeiro.
        /// 016 ao 030 - "AVALIAÇÃO"
        /// 
        /// </summary>
        public static void Encontro22_Codigo01()
        {
            Console.WriteLine("Testando o laço while...");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Testando o laço do/while...");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }

        public static void Encontro22_Codigo02()
        {
            int parada = 45;
            for (int i = 0; i < parada; i++)
            {
                Console.WriteLine("Mensagem {0} de {1}.", i, parada);
            }
            Console.WriteLine("Laço for terminou.");
        }

        public static void Desafio_001()
        {
            Console.Write("Informe um valor:");
            string valor = Console.ReadLine();
            int num = Convert.ToInt32(valor);
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt(num);

            Console.WriteLine("O dobro de {0} vale {1}", num, dobro);
            Console.WriteLine("O triplo de {0} vale {1}", num, triplo);
            Console.WriteLine("A raiz de {0} vale {1}", num, raiz);

        }

        public static void Desafio_002()
        {
            Console.Write("Digite a primeira nota:");
            float nota_1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite a segunda nota:");
            float nota_2 = Convert.ToSingle(Console.ReadLine());
            float media = (nota_1 + nota_2) / 2;
            Console.WriteLine("A média do aluno foi {0}", media);
        }

        public static void Desafio_003()
        {
            Console.Write("Informe um valor em metros:");
            float metros = Convert.ToSingle(Console.ReadLine());
            float cent = metros * 100;
            float mili = cent * 10;
            Console.WriteLine("O objeto possui {0} centimetros ou {1} milimetros.", cent, mili);
        }

        public static void Desafio_004()
        {
            Console.Write("Informe um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int valor = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, valor);
            }
        }

        public static void Desafio_005()
        {
            Console.Write("Informe quantos reais você possui em sua carteira:");
            string valor = Console.ReadLine();
            float reais = Convert.ToSingle(valor);
            float dollar = reais / 5;
            if (dollar < 1)
            {
                dollar = dollar * 100;
                Console.WriteLine("Você pode comprar {0} centavos de dólar.", dollar);
            }
            else if (dollar < 2)
            {
                Console.WriteLine("Você pode comprar {0} dólar.", dollar);
            }
            else
            {
                Console.WriteLine("Você pode comprar {0} dólares.", dollar);
            }
        }

        public static void Desafio_006()
        {
            Console.Write("Informe a largura da parede:");
            float largura = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe a altura da parede:");
            float altura = Convert.ToSingle(Console.ReadLine());
            float area = altura * largura;
            Console.WriteLine("A parede possui {0}m², e é necessário {1} litros de tinta para pintá-la.", area, area / 2);
        }

        public static void Desafio_007()
        {
            Console.Write("Digite o valor do produto:");
            float valor = Convert.ToSingle(Console.ReadLine());
            float desc = valor - (valor * 5 / 100);
            Console.WriteLine("Valor com desconto igual a {0} reais.", desc);
        }

        public static void Desafio_008()
        {
            Console.Write("Informe o salário do funcionário:");
            float salario = Convert.ToSingle(Console.ReadLine());
            float aumento = salario + (salario * 15 / 100);
            Console.WriteLine("Novo salário de {0}R$.", aumento);
        }

        public static void Desafio_009()
        {
            Console.Write("Digite a temperatura em Cº.");
            float C = Convert.ToSingle(Console.ReadLine());
            double F = (C * 1.8) + 32;
            Console.WriteLine("Temperatura igual a {0}Fº.", F);
        }

        public static void Desafio_010()
        {
            Console.Write("Informe a quilometragem rodada:");
            float km = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe os dias usados:");
            float dias = Convert.ToSingle(Console.ReadLine());
            double custo = (60 * dias) + (km * 0.15);
            Console.WriteLine("Custo total do aluguel do carro igual a R${0}.", custo);
        }

        public static void Encontro24_Codigo01()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            for (int i = 0; i <= numeros.Count(); i++)
            {
                Console.WriteLine(i);
            }

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

        public static void Desafio_011()
        {
            List<string> nomes = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qtde de alunos na lista: {0}", nomes.Count());
                Console.Write("Digite o nome do aluno:");
                nomes.Add(Console.ReadLine());
                Console.Write("Desaja terminar (S/N)?");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Qtde de alunos na lista: {0}", nomes.Count());
            Console.WriteLine("Lista de alunos:");
            foreach (string s in nomes)
            {
                Console.WriteLine("--> {0}", s);
            }
        }

        public static void Desafio_012()
        {
            List<string> nomes = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qtde de alunos na lista: {0}", nomes.Count());
                Console.Write("Digite o nome do aluno:");
                nomes.Add(Console.ReadLine());
                Console.Write("Desaja terminar (S/N)?");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Qtde de alunos na lista: {0}", nomes.Count());
            Console.WriteLine("Lista de alunos:");
            nomes.Sort();
            foreach (string s in nomes)
            {
                Console.WriteLine("--> {0}", s);
            }
        }

        public static void Encontro24_Codigo02()
        {
            Random rand = new Random();
            //rand.Next();
            //rand.Next(100);
            //rand.Next(1, 100);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número gerado = {0}", rand.Next(100));
            }
        }

        public static List<string> CriarListaDeNomes()
        {
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Matheus");
            listaDeNomes.Add("Lucas");
            listaDeNomes.Add("João");
            listaDeNomes.Add("Judas");
            listaDeNomes.Add("Tadeu");
            listaDeNomes.Add("Tiago");
            listaDeNomes.Add("Marcos");
            listaDeNomes.Add("André");
            listaDeNomes.Add("Simão");
            listaDeNomes.Add("Pedro");
            listaDeNomes.Add("Tomé");
            listaDeNomes.Add("Filipe");
            return listaDeNomes;
        }

        public static void Desafio_013()
        {
            List<string> lista = CriarListaDeNomes();
            Random random = new Random();
            int indice = random.Next(lista.Count());
            Console.WriteLine("Índice sorteado: {0}.", indice);
            Console.WriteLine("Nome sorteado: {0}.", lista[indice]);
        }

        public static void Desafio_014()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("ORIGINAL");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-------------");
            Random random = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => random.Next()).ToList();
            Console.WriteLine("EMBARALHADA");
            foreach (string str in listaEmbaralhada)
            {
                Console.WriteLine(str);
            }
        }

        public static void Desafio_015()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("Lista Original:");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------");
            Random rand = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => rand.Next()).ToList();
            Console.WriteLine("Lista Embaralhada:");
            foreach (string str in listaEmbaralhada)
            {
                Console.WriteLine(str);
            }

            int indice = rand.Next(listaEmbaralhada.Count());
            Console.WriteLine("-----------------");
            Console.WriteLine("Índice sorteado: {0}.", indice);
            Console.WriteLine("Nome sorteado: {0}.", listaEmbaralhada[indice]);
        }

        public static void Desafio_016()
        {
            Console.Write("Digite um número: ");
            float num = Convert.ToSingle(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} é par.", num);
            }
            else
            {
                Console.WriteLine("{0} é ímpar.", num);
            }
        }

        public static void Desafio_017()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            string nomeReplace = nome.Replace(" ", "");
            string[] palavras = nome.Split(' ');
            Console.WriteLine("Olá meu nome é {0}.", nome);
            Console.WriteLine("UpperCase: {0}", nome.ToUpper());
            Console.WriteLine("LowerCase: {0}", nome.ToLower());
            Console.WriteLine("Número de letras no nome: {0}", nomeReplace.Count());
            Console.WriteLine("Número de letras no primeiro nome: {0}", palavras[0].Count());
        }

        public static void Desafio_018()
        {
            Console.WriteLine("Informe a operação desejada(A/S/M/D): ");
            String op = Console.ReadLine();
            Console.WriteLine("Informe o primeiro valor: ");
            float valor1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float valor2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("          ");
            if (op.ToUpper() == "A")
            {
                float adc = valor1 + valor2;
                Console.WriteLine("{0} + {1} = {2}", valor1, valor2, adc);
            }
            else if (op.ToUpper() == "S")
            {
                float sub = valor1 - valor2;
                Console.WriteLine("{0} - {1} = {2}", valor1, valor2, sub);
            }
            else if (op.ToUpper() == "M")
            {
                float mult = valor1 * valor2;
                Console.WriteLine("{0} x {1} = {2}", valor1, valor2, mult);
            }
            else if (op.ToUpper() == "D")
            {
                float div = valor1 / valor2;
                Console.WriteLine("{0} / {1} = {2}", valor1, valor2, div);
            }
        }

        public static void Desafio_019()
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão!");
            }
            else if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida.");
            }

        }

        public static void Desafio_020()
        {
            Console.WriteLine("Escreva uma frase: ");
            string frase = Console.ReadLine();
            string fraseSemA = frase.Replace("A", "&").Replace("a", "&");
            Console.WriteLine(fraseSemA);
        }

        public static void Desafio_021()
        {
            Console.WriteLine("Informe seu salário: ");
            float salario = Convert.ToSingle(Console.ReadLine());
            float corrSal;
            if (salario < 1700)
            {
                corrSal = salario + 300;
            }
            else
            {
                corrSal = salario + 200;
            }
            Console.WriteLine("Salario com reajuste igual a R${0}.", corrSal);
        }

        public static void Desafio_022()
        {
            Console.Write("Informe seu peso(kg): ");
            float peso = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe sua altura(m): ");
            float alt = Convert.ToSingle(Console.ReadLine());
            float imc = peso / (alt * alt);
            Console.WriteLine("Seu IMC é de {0} kg/m².", imc);
        }

        public static void Desafio_023()
        {
            Console.Write("Informe a altura da caixa d'água(m): ");
            float alt = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe a área da base da caixa d'água(m²): ");
            float areaBase = Convert.ToSingle(Console.ReadLine());
            float volume = alt * areaBase;
            float qtdeAgua = volume * 1000;
            Console.WriteLine("Volume de {0} m³ ou {1} litros de água.", volume, qtdeAgua);
        }

        public static void Desafio_024()
        {
            Console.Write("Informe a altura do cilindro(m): ");
            float alt = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe o raio da base do cilindro(m): ");
            float raio = Convert.ToSingle(Console.ReadLine());
            double volume = Math.PI * (raio * raio) * alt;
            Console.WriteLine("Volume do cilindro igual a {0} m³", volume);
        }

        public static void Desafio_025()
        {
            Console.Write("Informe um número qualquer: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe outro número qualquer: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            float num3 = (num2 > num1) ? num2 - num1 : num1 - num2;
            Console.WriteLine(Math.Pow(num3, 2));
        }

        public static void Desafio_026()
        {
            Console.Write("Informe o raio da esfera(cm): ");
            float raio = Convert.ToSingle(Console.ReadLine());
            double volume = (4 / 3) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine("Volume igual a {0} cm³.", volume);
        }

        public static void Desafio_027()
        {
            Console.Write("Digite um número real: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite outro número real: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            float adc = num1 + num2;
            float sub = num1 - num2;
            float mult = num1 * num2;
            float div = num1 / num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, adc);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, mult);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, div);
        }

        public static void Desafio_028()
        {
            Console.Write("Informe a quilometragem rodada na viagem: ");
            float km = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe quantos km/L seu carro faz em média: ");
            float kmLitro = Convert.ToSingle(Console.ReadLine());
            float consumo = km / kmLitro;
            Console.WriteLine("Seu carro consumiu aproximadamente {0} litros de combustível.", consumo);
        }

        public static void Desafio_029()
        {
            Console.Write("Informe o valor original da prestação: ");
            float prest = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe a quantidade de dias que o pagamento está atrasado: ");
            float diasAtrs = Convert.ToSingle(Console.ReadLine());
            Console.Write("Informe a % de juros: ");
            float juros = Convert.ToSingle(Console.ReadLine());
            for (int i = 1; i <= diasAtrs; i++)
            {
                prest = prest + (prest * (juros / 100));
            }
            Console.WriteLine("Prestação atualizada no valor de R${0}.", prest);
        }

        public static void Desafio_030()
        {
            float numMaior = 0;
            float numMenor = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("Informe um número qualquer: ");
                float num = Convert.ToSingle(Console.ReadLine());
                if (i == 0)
                {
                    numMaior = num;
                    numMenor = num;
                }
                else if (num > numMaior)
                {
                    numMaior = num;
                }
                else if (num < numMenor)
                {
                    numMenor = num;
                }
            }
            Console.WriteLine("O maior número é {0} e o menor é {1}.", numMaior, numMenor);
        }

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
