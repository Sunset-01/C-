using System;

class Program
{
    static int numero1;
    static int numero2;

    static void Main(string[] args)
    {
        while (true)
        {
            
            
            Console.WriteLine();
            Console.Write("Escoge: ");
            string eleccion = Console.ReadLine();
            while (!int.TryParse(eleccion, out int result))
            {
                Console.Write("Escoge bien mmgvo: ");
                eleccion = Console.ReadLine();
            }
            int opcion = int.Parse(eleccion);
            if (opcion == 1)
            {
                intro_num();
                suma(numero1, numero2);
            }
            else if (opcion == 2)
            {
                intro_num();
                resta(numero1, numero2);
            }
            else if (opcion == 3)
            {
                intro_num();
                multiplicación(numero1, numero2);
            }
            else if (opcion == 4)
            {
                intro_num();
                división(numero1, numero2);
            }
            else if (opcion == 5)
            {
                intro_num();
                exponente(numero1, numero2);
            }
            else if (opcion == 6)
            {
                intro_num();
                raíz(numero1, numero2);
            }
            else if (opcion == 7)
            {
                Console.WriteLine("weno bye prro");
                break;
            }
            
        catch
        {
             Console.WriteLine("");
        }
        }
    }

    static void intro_num()
    {
        
        
            Console.Write("Primer número: ");
            string input1 = Console.ReadLine();
            while (!int.TryParse(input1, out numero1))
            {
                Console.Write("Primer número: ");
                input1 = Console.ReadLine();
            }
            Console.Write("Segundo número: ");
            string input2 = Console.ReadLine();
            while (!int.TryParse(input2, out numero2))
            {
                Console.Write("Segundo número: ");
                input2 = Console.ReadLine();
            }
        

    }

    static void suma(int a, int b)
    {
        try
        {
            Console.WriteLine("la Suma de " + a + " + " + b + " = " + (a + b));
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }

    static void resta(int a, int b)
    {
        try
        {
            Console.WriteLine("la Resta de " + a + " - " + b + " = " + (a - b));
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }

    static void multiplicación(int a, int b)
    {
        try
        {
            Console.WriteLine("la Multiplicación de " + a + " * " + b + " = " + (a * b));
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }

    static void división(int a, int b)
    {
        try
        {
            if (numero1 == 0)
            {
                Console.WriteLine("No es posible dividir por cero");
            }
            else if (numero2 == 0)
            {
                Console.WriteLine("No es posible dividir por cero");
            }
            else
            {
                Console.WriteLine("la División de " + a + " / " + b + " = " + (a / b));
            }
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }

    static void raíz(int a, int b)
    {
        try
        {
            if (numero1 <= 0 || numero2 <= 0)
            {
                Console.WriteLine(" negativas raíces no jalan baboso.");
            }
            else
            {
                Console.WriteLine("la Raíz de " + a + " v--- " + b + " = " + a + Math.Sqrt(b));
            }
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }

    static void exponente(int a, int b)
    {
        try
        {
            Console.WriteLine("El exponente de " + a + " ** " + b + " = " + Math.Pow(a, b));
        }
        catch
        {
            Console.WriteLine("Hazlo bien");
        }
    }
}



