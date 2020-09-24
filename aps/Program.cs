using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho, cont, escolha, escolha2, tamchave;
            String texto1, texto2 = "", chave;
            int[] numero = new int[10000];

            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("||  Digite 1 para criptografar        ||");
                Console.WriteLine("||  Digite 2 para descriptografar     ||");
                Console.WriteLine("||  Digite 3 para limpar os campos    ||");
                Console.WriteLine("||  Digite 4 para encerrar o programa ||");
                Console.WriteLine("========================================");
                escolha = Convert.ToInt16(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        Console.WriteLine("Entre com uma chave:");
                        chave = Console.ReadLine();

                        tamchave = chave.Length;

                        Console.WriteLine("O que deseja criptografar?");
                        texto1 = Console.ReadLine();
                        texto1 = texto1.ToUpper();

                        tamanho = texto1.Length;
                        
                         //PARA TRANSFORMAR O VETOR STRING EM VETOR NÚMERO
                        for (cont = 0; cont < tamanho; cont++)
                        {
                            numero[cont] = Convert.ToInt16(texto1[cont]);
                        }
                        Console.Write("\n\n");

                        //PARA CRIPTOGRAFAR 

                        Console.Write("Sua mensagem criptografada é:");
                        Console.Write("\n\n");
                        for (cont = 0; cont < tamanho; cont++)
                        {

                            if ((numero[cont] >= 65) || (numero[cont] <= 72))
                            {
                                numero[cont] = Convert.ToInt16(texto1[cont]) + tamchave;
                                texto2 = texto2 + Convert.ToChar(numero[cont]);
                            }
                            else
                            {
                                if ((numero[cont] >= 73) || (numero[cont] <= 81))
                                {
                                    numero[cont] = Convert.ToInt16(texto1[cont]) + tamchave + 1;
                                    texto2 = texto2 + Convert.ToChar(numero[cont]);
                                }
                                else
                                {
                                    if ((numero[cont] >= 82) || (numero[cont] <= 90))
                                    {
                                        numero[cont] = Convert.ToInt16(texto1[cont]) + tamchave + 3;
                                        texto2 = texto2 + Convert.ToChar(numero[cont]);
                                    }
                                    else
                                    {
                                        numero[cont] = Convert.ToInt16(texto1[cont]) + tamchave + 2;
                                        texto2 = texto2 + Convert.ToChar(numero[cont]);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("{0}", texto2);
                        Console.ReadKey();
                        break;

                    //PARA DESCRIPTOGRAFAR
                    case 2:
                        Console.WriteLine("===============================================================");
                        Console.WriteLine("||  Digite 1 para descriptografar mensagem já criptografada  ||");
                        Console.WriteLine("||  Digite 2 para descriptografar nova mensagem              ||");
                        Console.WriteLine("===============================================================");
                        escolha2 = Convert.ToInt16(Console.ReadLine());

                        switch (escolha2)
                        { 
                            //Para descriptografar a mensagem anteriormente codificada
                            case 1:
                                texto1 = "";
                                tamanho = texto2.Length;

                                Console.WriteLine("Entre com uma chave:");
                                chave = Console.ReadLine();

                                tamchave = chave.Length;

                                Console.Write("Sua mensagem descriptografada é:");
                                Console.WriteLine("\n\n");
                                for (cont = 0; cont < tamanho; cont++)
                                {
                                    if ((numero[cont] >= 65) || (numero[cont] <= 72))
                                    {
                                        numero[cont] = Convert.ToInt16(texto2[cont]) - tamchave;
                                        texto1 = texto1 + Convert.ToChar(numero[cont]);
                                    }
                                    else
                                    {
                                        if ((numero[cont] >= 73) || (numero[cont] <= 81))
                                        {
                                            numero[cont] = Convert.ToInt16(texto2[cont]) - tamchave - 1;
                                            texto2 = texto1 + Convert.ToChar(numero[cont]);
                                        }
                                        else
                                        {
                                            if ((numero[cont] >= 82) || (numero[cont] <= 90))
                                            {
                                                numero[cont] = Convert.ToInt16(texto2[cont]) - tamchave - 3;
                                                texto1 = texto1 + Convert.ToChar(numero[cont]);
                                            }
                                            else
                                            {
                                                numero[cont] = Convert.ToInt16(texto2[cont]) - tamchave - 2;
                                                texto1 = texto1 + Convert.ToChar(numero[cont]);
                                            }
                                        }

                                    }

                                }
                                Console.WriteLine("{0}", texto1);
                                Console.ReadKey();
                                break;
                            //Para descriptografar mensagem exterior, ou seja, que não tenha sido criptografada pelo programa anteriormente 
                            case 2:
                                Console.WriteLine("Entre com uma chave:");
                                chave = Console.ReadLine();

                                tamchave = chave.Length;
                                Console.WriteLine("\n\n");

                                Console.WriteLine("O que deseja descriptografar?");
                                texto1 = Console.ReadLine();
                                texto1 = texto1.ToUpper();

                                tamanho = texto1.Length;
                                Console.WriteLine("\n");
                                
                                for (cont = 0; cont < tamanho; cont++)
                                {
                                    numero[cont] = Convert.ToInt16(texto1[cont]);
                                }

                                Console.Write("\n\n");
                                Console.Write("Sua mensagem descriptografada é:");
                                Console.Write("\n\n");

                                for (cont = 0; cont < tamanho; cont++)
                                {

                                    if ((numero[cont] >= 65) || (numero[cont] <= 72))
                                    {
                                        numero[cont] = Convert.ToInt16(texto1[cont]) - tamchave;
                                        texto2 = texto2 + Convert.ToChar(numero[cont]);
                                    }
                                    else
                                    {
                                        if ((numero[cont] >= 73) || (numero[cont] <= 81))
                                        {
                                            numero[cont] = Convert.ToInt16(texto1[cont]) - tamchave - 1;
                                            texto2 = texto2 + Convert.ToChar(numero[cont]);
                                        }
                                        else
                                        {
                                            if ((numero[cont] >= 82) || (numero[cont] <= 90))
                                            {
                                                numero[cont] = Convert.ToInt16(texto1[cont]) - tamchave - 3;
                                                texto2 = texto2 + Convert.ToChar(numero[cont]);
                                            }
                                            else
                                            {
                                                numero[cont] = Convert.ToInt16(texto1[cont]) - tamchave - 2;
                                                texto2 = texto2 + Convert.ToChar(numero[cont]);
                                            }
                                        }
                                    }
                                }
                                Console.WriteLine("{0}", texto2);
                                Console.ReadKey();
                                break;
                            //Instrução a ser executada caso o usuário digite um número diferente dos apresentados na legenda
                            default:
                                Console.WriteLine("OPÇÃO INVÁLIDA!");
                                break;
                        }
                       
                        break;
                    //Intrução a ser executada caso o usuario queria iniciar uma nova criptografia, limpa os formulários        
                    case 3:
                        texto1 = "";
                        texto2 = "";
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("===================");
                        Console.WriteLine("| OPÇÂO INVÁLIDA! |");
                        Console.WriteLine("===================");
                        break;
                }
            } while (!(escolha == 4));

            Console.ReadKey();
        }
    }
}
