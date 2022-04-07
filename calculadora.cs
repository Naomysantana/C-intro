using System;

namespace ns 
{
    class Program 
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Calculadora");
            Console.Write("Ligar calculadora(1): " );
            string ligar  = Console.ReadLine();
            if (ligar.Equals("1"))
            {
                while(true){

                    Console.Write("Digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o operador: ");
                    string operador = Console.ReadLine();

                    Console.Write("Digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine($"Resultado: {Somar(num1, num2)}");
                            break; 
                        
                        case "-" :
                            Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                            break;

                        case "*":
                            Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                            break;

                        case "/":
                            Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                            break;

                        default:
                            Console.WriteLine("Operador Inválido");
                            continue;
                    }
                    Console.Write("Deseja sair (0): ");
                    string desligar = Console.ReadLine();
                    if (desligar.Equals("0"))
                    {
                        break;
                    }
                }
                
            }    
    }

    public static string Somar(int num1, int num2)
    {   
        return (num1 + num2).ToString();
    }
    
    public static string Subtrair(int num1, int num2)
    {
        return (num1 - num2).ToString();
    }

    public static string Multiplicar(int num1, int num2)
    {
        return (num1 * num2).ToString();
    }

    public static string Dividir(int num1, int num2)
    {
        if(ValorDividendoMenorOuIgualQueZero(num2))
        {
            return"Não é possível dividir por zero ou menor que zero";
        }

        return (num1 / num2).ToString();
    

        bool ValorDividendoMenorOuIgualQueZero(int num2)
        {
            if (num2 <= 0)
            {
                return true;
            }
            return false;
            }
        }
    }

    
}