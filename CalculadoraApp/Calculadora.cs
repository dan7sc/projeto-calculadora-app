using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private readonly List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = [];
        }
        
        public int Somar(int a, int b)
        {
            int resultado = a + b;
            InserirValorNoHistorico(resultado);

            return resultado;
        }
        
        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            InserirValorNoHistorico(resultado);

            return resultado;
        }
        
        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            InserirValorNoHistorico(resultado);

            return resultado;
        }
        
        public int Dividir(int a, int b)
        {
            int resultado = a / b;
            InserirValorNoHistorico(resultado);

            return resultado;
        }
        
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

        private void InserirValorNoHistorico(int valor)
        {
            listaHistorico.Insert(0, "Resultado: " + valor);
        }
    }
}