using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3.cs
{
    public  class Program
    {

        public static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("===========================================================================================");
            Console.WriteLine("|1 -   Calcular o estoque de peças                                                        |");
            Console.WriteLine("|2 -   Cotação do dollar                                                                  |");
            Console.WriteLine("|3 -   Calculo da comissão                                                                |");
            Console.WriteLine("|4 -   Soma e multiplicação de valores                                                    |");
            Console.WriteLine("|5 -   Calculo do combustivel                                                             |");
            Console.WriteLine("|6 -   Cenvereter de celsius para fahrnhereit                                             |");
            Console.WriteLine("|7 -   Convereter de fahrenheit para celsius                                              |");
            Console.WriteLine("|8 -   Calculo do Volume da lata de óleo.                                                 |");
            Console.WriteLine("|9 -   Idade de uma pessoa em dias                                                        |");
            Console.WriteLine("|10 -  Números iguais, maior, menor                                                       |");
            Console.WriteLine("|11 -  Trocar o valor de A e B                                                            |");
            Console.WriteLine("|12 -   Modulo do número                                                                  |");
            Console.WriteLine("|13 -   Números em ordem decrescente                                                      |");
            Console.WriteLine("|14 -   Diferenca maior e menor número                                                    |");
            Console.WriteLine("|15    - Nota dos alunos                                                                  |");
            Console.WriteLine("|16 -  Maior ou menor se for igual mostrar mensagem                                       |");
            Console.WriteLine("|17 -   Valor valido ou invalido                                                          |");
            Console.WriteLine("|18 -   Codigo do número                                                                  |");
            Console.WriteLine("|19 -   Valor do triangulo                                                                |");
            Console.WriteLine("|20 -   Valor maior que zero                                                              |");
            Console.WriteLine("|21 -   Número positivo ou negativo                                                       |");
            Console.WriteLine("|22 -   Se positivo em A se negativo em B                                                 |");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Escolha uma opcao:  ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    AtividadesOAT3Part1 exercicio1 = new AtividadesOAT3Part1();

                    exercicio1.Atividade1();


                    break;
                case 2:
                    AtividadesOAT3Part1 exercicio2 = new AtividadesOAT3Part1();
                    exercicio2.Atividade2();


                    break;
                case 3:
                    AtividadesOAT3Part1 exercicio3 = new AtividadesOAT3Part1();

                    exercicio3.Atividade3();


                    break;
                case 4:
                    AtividadesOAT3Part1 exercicio4 = new AtividadesOAT3Part1();

                    exercicio4.Atividade4();


                    break;
                case 5:
                    AtividadesOAT3Part1 exercicio5 = new AtividadesOAT3Part1();
                    exercicio5.Atividade5();


                    break;
                case 6:
                    AtividadesOAT3Part1 exercicio6 = new AtividadesOAT3Part1();
                    exercicio6.Atividade6();


                    break;
                case 7:
                    AtividadesOAT3Part1 exercicio7 = new AtividadesOAT3Part1();
                    exercicio7.Atividade7();


                    break;
                case 8:
                    AtividadesOAT3Part1 exercicio8 = new AtividadesOAT3Part1();

                    exercicio8.Atividade8();

                    break;
                case 9:
                    AtividadesOAT3Part1 exercicio9 = new AtividadesOAT3Part1();

                    exercicio9.Atividade9();


                    break;
                case 10:
                    AtividadesOAT3Part1 exercicio10 = new AtividadesOAT3Part1();

                    exercicio10.Atividade10();


                    break;
                case 11:
                    AtividadesOAT3Part1 exercicio11 = new AtividadesOAT3Part1();

                    exercicio11.Atividade11();


                    break;
                case 12:
                    AtividadesOAT3Part1 exercicio12 = new AtividadesOAT3Part1();

                    exercicio12.Atividade12();

                    break;
                    case 13:
                    AtividadesOAT3Part1 exercicio13 = new AtividadesOAT3Part1();

                    exercicio13.Atividade12();
                    break;
                    case 14:
                    AtividadesOAT3Part1 exercicio14 = new AtividadesOAT3Part1();

                    exercicio14.Atividade12();
                    break;
                    case 15:
                    AtividadesOAT3Part1 exercicio15 = new AtividadesOAT3Part1();

                    exercicio15.Atividade12();
                    break;
                    case 16:
                    AtividadesOAT3Part1 exercicio16 = new AtividadesOAT3Part1();

                    exercicio16.Atividade12();
                    break;
                    case 17:
                    AtividadesOAT3Part1 exercicio17 = new AtividadesOAT3Part1();

                    exercicio17.Atividade12();
                    break;
                    case 18:
                    AtividadesOAT3Part1 exercicio18 = new AtividadesOAT3Part1();

                    exercicio18.Atividade12();
                    break;
                    case 19:
                    AtividadesOAT3Part1 exercicio19 = new AtividadesOAT3Part1();

                    exercicio19.Atividade12();
                    break;
                    case 20:
                    AtividadesOAT3Part1 exercicio20 = new AtividadesOAT3Part1();

                    exercicio20.Atividade12();
                    break;
                    case 21:
                    AtividadesOAT3Part1 exercicio21 = new AtividadesOAT3Part1();

                    exercicio21.Atividade12();
                    break;
                    case 22:
                    AtividadesOAT3Part1 exercicio22 = new AtividadesOAT3Part1();

                    exercicio22.Atividade12();

                    break;


                default:
                    Console.WriteLine("Opção Invalida!");
                    break;



            }

        }

    }
}
