using System;

namespace CalculadoraLib
{
    public class Calculadora
    {
        public static double Sumar(double a, double b) => a + b;
        public static double Restar(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;
        public static double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }

        public static double RaizCuadrada(double a)
        {
            if (a < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            return Math.Sqrt(a);
        }

        public static double Potencia(double baseNum, double exponente) => Math.Pow(baseNum, exponente);

        public static double Porcentaje(double total, double porcentaje) => (total * porcentaje) / 100;

        public static double Fraccion(double numerador, double denominador)
        {
            if (denominador == 0)
                throw new DivideByZeroException("El denominador no puede ser cero.");
            return numerador / denominador;
        }
    }
}
