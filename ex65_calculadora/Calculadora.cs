using System;

namespace CalculadoraPOO
{
    public class Calculadora
    {
        // Método para somar
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        // Método para subtrair
        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        // Método para multiplicar
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        // Método para dividir com tratamento de exceção para divisão por zero
        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida.");
            return num1 / num2;
        }
    }
}
