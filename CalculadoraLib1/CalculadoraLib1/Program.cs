using System;
using CalculadoraLib; // Importamos la librería

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

            if (opcion == "9") // Opción para salir
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            double num1 = 0, num2 = 0;
            double resultado = 0;

            if (opcion != "8") // La opción 8 (Fracción) solo necesita un número
            {
                Console.Write("Ingresa el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                // Solo pedimos el segundo número para las operaciones que lo necesitan
                if (opcion != "5") // La raíz cuadrada no necesita un segundo número
                {
                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                // La opción 8 solo requiere un número decimal para convertirlo a fracción
                Console.Write("Ingresa un número decimal para convertirlo a fracción: ");
                num1 = Convert.ToDouble(Console.ReadLine());
            }

            try
            {
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
                        // Convertir el número decimal a fracción
                        string fraccion = ConvertirADecimalAFaccion(num1);
                        Console.WriteLine($"La fracción equivalente de {num1} es: {fraccion}");
                        continue; // Salimos del ciclo para evitar mostrar el resultado general
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

    // Método para convertir un número decimal a su equivalente fraccionario
    static string ConvertirADecimalAFaccion(double decimalValue)
    {
        // Convertir el número decimal a fracción
        double tolerance = 1E-6; // Para determinar la precisión de la fracción
        int denominator = 1;
        while (Math.Abs(decimalValue * denominator - Math.Round(decimalValue * denominator)) > tolerance)
        {
            denominator++;
        }

        int numerator = (int)(decimalValue * denominator);
        int gcd = ObtenerMCD(numerator, denominator); // Obtener el máximo común divisor

        // Simplificar la fracción
        numerator /= gcd;
        denominator /= gcd;

        return $"{numerator}/{denominator}";
    }

    // Método para obtener el máximo común divisor (MCD)
    static int ObtenerMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
