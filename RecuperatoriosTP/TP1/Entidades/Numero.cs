using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        /*private double numero;

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        */
        public string BinarioDecimal(string binario)
        {
            int cantidadCaracteres = binario.Length;
            double exponente = 0;
            double numeroDecimal = 0;

            for(int i=cantidadCaracteres-1;i>=0;i--)
            {
                if(binario[i]!='0' && binario[i]!='1')
                {
                    return "Valor inválido";
                }
                numeroDecimal = numeroDecimal + (binario[i] * (Math.Pow(2, exponente)));
                exponente++;
            }
            return numeroDecimal.ToString();
        }
        /*
        public string DecimalBinario(double numero)
        {

        }

        public string DecimalBinario(string numero)
        {

        }
        
        public Numero()
        {
            SetNumero = "0";
        }

        public Numero(double numero)
        {

        }

        public Numero(string strNumero)
        {

        }

        public static double operator -(Numero n1, Numero n2)
        {

        }

        public static double operator *(Numero n1, Numero n2)
        {

        }

        public static double operator /(Numero n1, Numero n2)
        {

        }

        public static double operator +(Numero n1, Numero n2)
        {

        }

        private double ValidarNumero(string strNumero)
        { 
            foreach (char c in strNumero)
            {
                if (!char.IsDigit(c))
                {
                    return 0;
                }             
            }
            return double.Parse(strNumero);
        }*/

    }
}
