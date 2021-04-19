using System;

namespace Ejercicios_.NET_1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ejercicio6();
        }

        public static void Ejercicio1()
        {
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota>=1&&nota<=7)
            {
                Console.WriteLine("Nota dentro del rango");
            }
            else
            {
                Console.WriteLine("Nota fuera del rango");
            }

        }

        public static void Ejercicio2() { 

        int numero = Convert.ToInt32(Console.ReadLine());

            if (numero%2==0)
            {
                Console.WriteLine("Numero es par");
            }
            else
            {
                Console.WriteLine("Numero es impar");
            }
        }

        public static void Ejercicio3()
        {
            int distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Convert.ToDouble(distancia)/6) + " Km/h");
        }


        public static void Ejercicio4()
        {
            int distancia = Convert.ToInt32(Console.ReadLine());

            if ((Convert.ToDouble(distancia) / 6)>100)
            {
                Console.WriteLine("El vehiculo se desplazara a gran velocidad");
            }
            else
            {
                Console.WriteLine("El vehiculo se desplazara a velocidad moderada");
            }
            Console.WriteLine((Convert.ToDouble(distancia) / 6) + " Km/h");
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ingresar cantidad de notas a promediar");
            int cantidadDeNotas = Convert.ToInt32(Console.ReadLine());
            double Promedio = 0;
            double nota = 0;
            for (int x=0;x<cantidadDeNotas;x++)
            {
                Console.WriteLine("Ingresar nota "+x);
                nota= Convert.ToDouble(Console.ReadLine());
                Promedio = Promedio + nota;
            }
            Console.WriteLine("Promedio: "+(Promedio/cantidadDeNotas));
        }
        public static void Ejercicio6()
        {
            Console.WriteLine("Ingresar limite iteraciones");
            int limite = Convert.ToInt32(Console.ReadLine());
            for (int x=1;x<=limite;x++)
            {
                if (x%2==1)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public static void Ejercicio7()
        {

        }

    }
}
