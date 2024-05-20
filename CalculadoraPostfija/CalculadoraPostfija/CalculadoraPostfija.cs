using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPostfija
{
    class CalculadoraPostfija
    {
        public double EvaluarPostfija(string expresion)
        {
            Stack<double> pila = new Stack<double>();
            string[] tokens = expresion.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    double b = pila.Pop();
                    double a = pila.Pop();
                    double resultado = 0;

                    switch (token)
                    {
                        case "+":
                            resultado = a + b;
                            break;
                        case "-":
                            resultado = a - b;
                            break;
                        case "*":
                            resultado = a * b;
                            break;
                        case "/":
                            if (b != 0)
                            {
                                resultado = a / b;
                            }
                            else
                            {
                                throw new DivideByZeroException("División por cero.");
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Operador no válido.");
                    }
                    pila.Push(resultado);
                }
            }

            return pila.Pop();
        }
    }
}
