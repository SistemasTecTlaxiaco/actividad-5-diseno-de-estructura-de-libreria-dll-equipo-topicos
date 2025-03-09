using System;
using CalculadoraLib; // Importamos la librería

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Calculadora en C# ---");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Potencia");
            Console.WriteLine("7. Porcentaje");
            Console.WriteLine("8. Fracción");
            Console.WriteLine("9. Salir");
            Console.Write("Selecciona una opción: ");


            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            Console.Write("Ingresa el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo nuumero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double resultado = 0;
                switch (opcion)
                {
                    case "1":
                        resultado = Calculadora.Sumar(num1, num2);
                        break;
                    case "2":
                        resultado = Calculadora.Restar(num1, num2);
                        break;
                    case "3":
                        resultado = Calculadora.Multiplicar(num1, num2);
                        break;
                    case "4":
                        resultado = Calculadora.Dividir(num1, num2);
                        break;
                    case "5":
                        resultado = Calculadora.RaizCuadrada(num1);
                        break;
                    case "6":
                        resultado = Calculadora.Potencia(num1, num2);
                        break;
                    case "7":
                        Console.Write("Ingresa el porcentaje: ");
                        double porcentaje = Convert.ToDouble(Console.ReadLine());
                        resultado = Calculadora.Porcentaje(num1, porcentaje);
                        break;
                    case "8":
                        resultado = Calculadora.Fraccion(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                
            }
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}