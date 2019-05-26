using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {

        /*
         *Titulo: Promedio y desviacion estandar
         *Autor: Juan Sebastian Toledo
         *Fecha de creacion: 17/02/2019
         * Descripccion Simple: Halla de una lista de numeros el promedio y la desviacion estandar
         */


        static void Main(string[] args)
        {
            Double numero = 0;
            int cantidad; //numeros cargados
            Double[] numeros; //llenado de numeros
            Double promedio; //promedio cargado
            Double datos_v = 0; //datos de varianza
            Double total_varianza;
            Console.WriteLine("Introducir cantidad de numeros");
            cantidad = Convert.ToInt32(Console.ReadLine());
            numeros = new double[cantidad]; //Total de numeros a ingresar
            for (int c = 0; c < numeros.Length; c++) //LLenar el array para poderlo trabajar
            {
                Console.WriteLine("Numero: " + (c + 1));
                numeros[c] = Convert.ToDouble(Console.ReadLine()); //solicitando numeros y llenado
                numero = numeros[c] + numero;

            }
           
            promedio = numero / cantidad; //Divide la suma con la cantidad de numeros   

            //varianza
            for (int c = 0; c < numeros.Length; c++)
            {
                //lenando con exp 2
                datos_v += Math.Pow((numeros[c]-promedio), 2);//lenando con exp 2
            }
            total_varianza = datos_v / (cantidad-1); //-1 de la formula

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Promedio es: " + promedio);
            Console.WriteLine("Desviacion estandar: " + Math.Sqrt(total_varianza));
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Presione alguna tecla, para terminar");
            
            Console.ReadKey();

        }
    }
}
