using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3.cs
{
    internal class AtividadesOAT3Part1
    {
        public void Atividade1()
        {
            int escolha = 0;
            int médio = 0;
            int qtdmínima = 0, qtdmáxima = 0;

            Console.WriteLine("calcular estoque de peças");
            Console.WriteLine();
            Console.WriteLine("estoque médio");
            Console.WriteLine("quantidade_mínima");
            Console.WriteLine("quantidade_máxima");

            Console.WriteLine("informe o estoque médio");
            médio = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade mínima");
            qtdmínima = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade máxima");
            qtdmáxima = int.Parse(Console.ReadLine());

            médio = (qtdmínima + qtdmáxima) / 2;
            Console.WriteLine(" o estoque médio é:" + médio);
            Console.WriteLine();




        }
        public void Atividade2()
        {
            double cotação_dolar, valor_dolar, valor_real;

            Console.WriteLine("digite a cotação do dolar:");
            cotação_dolar =
            double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor em dolar:");
            valor_dolar =
            double.Parse(Console.ReadLine());

            valor_real = cotação_dolar * valor_dolar;
            Console.WriteLine("o valor em reais é:" + valor_real);



        }
        public void Atividade3()
        {
            int id_vendedor, cod_peca, qtd_vendida;
            decimal preco_unit, comissao, porcentagemcomissao;

            Console.WriteLine("Digite o ID do vendedor:");
            int id_Vendedor =
            int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da peça:");
            int Cod_Peca =
            int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário da peça:");
            decimal Preco_Unit =
            decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade vendida:");
            int Qtd_Vendida =
            int.Parse(Console.ReadLine());

            comissao = Preco_Unit * Qtd_Vendida * 5 / 100;

            Console.WriteLine("o valor da comissão é de " + comissao);



        }
        public void Atividade4()
        {
            int valores;
            int Soma;
            int Mult;

            Console.WriteLine("informe o valor de A:");
            int A =
            int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de B:");
            int B =
            int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de C:");
            int C =
            int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor de D");
            int D =
            int.Parse(Console.ReadLine());
            {
                int ValorSoma = A + B;
                int ValorMult = A * B;
                Console.WriteLine("o valor da soma de A+B é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de A*B é " + ValorMult);
            }
            {
                int ValorSoma = A + C;
                int ValorMult = A * C;
                Console.WriteLine("o valor da soma de A+C é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de A*C é " + ValorMult);
            }
            {
                int ValorSoma = A + D;
                int ValorMult = A * D;
                Console.WriteLine("o valor da soma de A+D é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de A*D é " + ValorMult);
            }
            {
                int ValorSoma = B + C;
                int ValorMult = B * C;
                Console.WriteLine("o valor da soma de B+C é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de B*C é " + ValorMult);

            }
            {
                int ValorSoma = B + D;
                int ValorMult = B * D;
                Console.WriteLine("o valor da soma de B+D é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de B*D é " + ValorMult);
            }
            {
                int ValorSoma = C + D;
                int ValorMult = C * D;
                Console.WriteLine("o valor da soma de C+D é " + ValorSoma);
                Console.WriteLine("o valor da multiplicacao de C*D é " + ValorMult);
            }
            int.Parse(Console.ReadLine());





        }
        public void Atividade5()
        {
            decimal tempo;
            decimal vlmedia;
            decimal distancia = 0;
            decimal consumo = 0;

            Console.WriteLine("informe o tempo gasto na viagem");
            tempo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("infome a velocidade media em kl/h");
            vlmedia = decimal.Parse(Console.ReadLine());

            distancia = tempo * vlmedia;
            consumo = distancia / 12;
            Console.WriteLine();

            Console.WriteLine("a distancia percorrida foi de:" + distancia + " kl:");
            Console.WriteLine("o consumo foi de:" + consumo + " litros:");
            Console.WriteLine();





        }
        public void Atividade6()
        {
            int F, C;

            Console.WriteLine("digite a temperatura em C°");

            int c =
            int.Parse(Console.ReadLine());
            Console.WriteLine();

            F = (9 * c + 160) / 5;
            Console.WriteLine("a temperatura convertida para fahrenheit é:" + F);
            Console.WriteLine();




        }
        public void Atividade7()
        {
            Console.WriteLine("digite a temperatura em F°");

            int f =
            int.Parse(Console.ReadLine());
            Console.WriteLine();

           double C = f - 32 * 5 / 9;
            Console.WriteLine("a temperatura convertida para celsius é:" + C);
            Console.WriteLine();



        }
        public void Atividade8()
        {
            int R, A;
            double V;

            Console.WriteLine("digite o raio da lata");
            int r =
            int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("digite a altura da lata");
            int a =
            int.Parse(Console.ReadLine());
            Console.WriteLine();

            V = 3.14159 * (r * r) * a;

            Console.WriteLine($"o valor do volume é: {V}");

            Console.ReadKey();



        }
        public void Atividade9()
        {
            int anos, meses, dias, tdias;

            Console.WriteLine("digite os anos");
            int Anos =
            int.Parse(Console.ReadLine());

            Console.WriteLine("digite os meses");
            int Meses =
            int.Parse(Console.ReadLine());



            Console.WriteLine("digite os dias");
            int Dias =
            int.Parse(Console.ReadLine());

            tdias = Anos * 365 + Meses * 30 + Dias;
            Console.WriteLine("idade total em dias: " + tdias + " dias");




        }
        public void Atividade10()
        {
            int num1, num2;
            Boolean Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorouIgual = false, MenorouIgual = false;

            Console.WriteLine("digite o primeiro número");
            int Num1 =
            int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número");
            int Num2 =
            int.Parse(Console.ReadLine());

            if (Num1 == Num2) Igual = true;
            if (Num1 != Num2) NaoIgual = true;
            if (Num1 > Num2) Maior = true;
            if (Num1 < Num2) Menor = true;
            if (Num1 >= Num2) MaiorouIgual = true;
            if (Num1 <= Num2) MenorouIgual = (true);

            Console.WriteLine("Igual:" + Igual);
            Console.WriteLine("NãoIgual:" + NaoIgual);
            Console.WriteLine("Maior:" + Maior);
            Console.WriteLine("Menor:" + Menor);
            Console.WriteLine("Maior ou igual:" + MaiorouIgual);
            Console.WriteLine("Menor ou igual:" + MenorouIgual);

            Console.WriteLine();





        }
        public void Atividade11()
        {
            int a, b, Troca;

            Console.WriteLine("digite o primeiro valor");
            int A =
            int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            int B =
            int.Parse(Console.ReadLine());

            Troca = A;
            A = B;
            B = Troca;

            Console.WriteLine("o valor de A: é " + A);
            Console.WriteLine("o valor de B: é " + B);



        }
        public void Atividade12()
        {
            int x, modulo;

            Console.WriteLine("digite um número:");
            int X =
            int.Parse(Console.ReadLine());
            if (X >= 0)
            {
                modulo = X * (-1);
            }
            else
            {
                modulo = X;
            }
            Console.WriteLine(" o modulo de X, é " + modulo);



        }
        public void Atividade13()
        {
            int[] numeros = new int[3];
            Console.WriteLine(" digite tres numero:");
            for (int x = 0; x < 3; x++)
            {
                numeros[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" os numeros em ordem decrescente são:");
            Console.WriteLine("");
            Array.Sort(numeros);
            Array.Reverse(numeros);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();




        }
        public void Atividade14()
        {
            int num1, num2;
            int diferenca;

            Console.WriteLine("digite um numero");
            int Num1 =
             int.Parse(Console.ReadLine());

            Console.WriteLine("digite mais um numero");
            int Num2 =
             int.Parse(Console.ReadLine());

            if (Num1 > Num2)
            {
                diferenca = Num1 - Num2;
                Console.WriteLine("a diferença do maior para o menor é:" + diferenca + "");
            }
            else
            {
                diferenca = Num2 - Num1;
                Console.WriteLine("a diferença do maior para o menor é:" + diferenca + "");
            }

            Console.ReadLine();



        }
        public void Atividade15()
        {
            int nota1, nota2, nota3, nota4, media, recuperacao;

            Console.WriteLine("Informe a primeira nota:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota:");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota:");
            nota4 = int.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 7)
            {
                Console.WriteLine(" Aprovado! Sua média foi de: " + media);
            }
            else if (media < 7)
            {
                Console.WriteLine("Infome a nota da recuperação:");
                recuperacao = int.Parse(Console.ReadLine());
                media = media + recuperacao;
                if (media >= 7)
                {
                    Console.WriteLine("Aprovado na recuperação com a média: " + media);
                }
                else
                    Console.WriteLine("Reprovado na recuperação com a média: " + media);
            }



        }
        public void Atividade16()
        {
            int num1, num2;

            Console.WriteLine("informe o primeiro número");
            int Num1 =
            int.Parse(Console.ReadLine());


            Console.WriteLine("informe o segundo número");
            int Num2 =
            int.Parse(Console.ReadLine());

            if (Num1 > Num2)
            {
                Console.WriteLine("o  valor do maior número é : " + Num1);
            }
            else if (Num1 < Num2)
            {
                Console.WriteLine("o valor do menor número é : " + Num1);
            }
            else if (Num1 == Num2)
            {
                Console.WriteLine("os dois números são iguais");
            }
            else
            {
                Console.WriteLine("os dois números são iguais: ");
            }
            Console.ReadKey();




        }
        public void Atividade17()
        {
            int valor1;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            if (valor1 >= 0 && valor1 <= 9)
            {
                Console.WriteLine("Valor válido!");
            }
            else
                Console.WriteLine("Valor inválido!");




        }
        public void Atividade18()
        {
            int CODIGO = 0;
            Console.WriteLine("digite o código");
            CODIGO = int.Parse(Console.ReadLine());

            switch (CODIGO)
            {
                case 1:
                    Console.WriteLine("código igual a um");
                    break;

                case 2:
                    Console.WriteLine("código igual a dois");
                    break;

                case 3:
                    Console.WriteLine("cógido igual a três");
                    break;

                default:
                    Console.WriteLine("código inválido");
                    break;
            }



        }
        public void Atividade19()
        {
            int A, B, C;

            Console.Write("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            if (A == B && A == C)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
                Console.WriteLine("O triângulo é escaleno.");




        }
        public void Atividade20()
        {
            int maior, menor, soma;
            double valor;
            int mult, divisao;
            Console.WriteLine("digite o primeiro número:");
            int a =
            int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número:");
            int b =
            int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro número:");
            int c =
            int.Parse(Console.ReadLine());
            maior = a;
            if (a < b)
            {
                maior = b;
            }
            if (a < c)
            {
                maior = c;
            }
            menor = a;
            if (a > b)
            {
                menor = b;
            }
            if (a > c)
            {
                menor = c;
            }

            Console.WriteLine("o maior número é: " + maior);
            Console.WriteLine("o menor número é: " + menor);
            Console.WriteLine("");
            mult = menor * maior;
            divisao = maior / menor;
            Console.WriteLine($"a multiplicação do menor com o maior número é :" + mult);
            Console.WriteLine($"a divisão do maior com o menor número é :" + divisao);
            Console.ReadLine();





        }

        public void Atividade21()
        {
            int num = 0;

            Console.WriteLine("informe um numero");
            int Num = int.Parse(Console.ReadLine());
            if (Num < 0)
            {
                Console.WriteLine("numero negativo:" + Num);
            }
            else if (Num > 0)
            {
                Console.WriteLine("numero positivo:" + Num);
            }
            Console.WriteLine("pare");
            Console.WriteLine();




        }
        public void Atividade22()
        {
            double A = 0, B = 0;
            int num;

            Console.WriteLine("digite um numero");
            int Num = int.Parse(Console.ReadLine());
            if (Num > 0)
            {
                A = Num;
                Console.WriteLine(" A = numero positivo");
            }
            else if (Num < 0)
            {
                B = Num;
                Console.WriteLine("B = numero negativo");
            }
            Console.WriteLine(" positivo " + A);
            Console.WriteLine(" negativo " + B);





        }


































































































    }
}
