using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRec
{
    public class Metodos
    {
        public void Tabla()
        {
            int[,] ventas = new int[,] { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    Console.Write(ventas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int vendedor1 = 0;
            for (int i = 0; i <= ventas.GetLength(1); i++)
            {
                vendedor1 += ventas[i, 0];
            }
            int vendedor2 = 0;
            for (int i = 0; i <= ventas.GetLength(1); i++)
            {
                vendedor2 += ventas[i, 1];
            }
            int vendedor3 = 0;
            for (int i = 0; i <= ventas.GetLength(1); i++)
            {
                vendedor3 += ventas[i, 2];
            }
            int vendedor4 = 0;
            for (int i = 0; i <= ventas.GetLength(1); i++)
            {
                vendedor4 += ventas[i, 3];
            }
            Console.WriteLine($"El vendedor 1 tuvo una ganancia de {vendedor1} pesos");
            Console.WriteLine($"El vendedor 2 tuvo una ganancia de {vendedor2} pesos");
            Console.WriteLine($"El vendedor 3 tuvo una ganancia de {vendedor3} pesos");
            Console.WriteLine($"El vendedor 4 tuvo una ganancia de {vendedor4} pesos");

            int producto1 = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                producto1 += ventas[0, i];
            }
            int producto2 = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                producto2 += ventas[1, i];
            }
            int producto3 = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                producto3 += ventas[2, i];
            }
            int producto4 = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                producto4 += ventas[3, i];
            }
            int producto5 = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                producto5 += ventas[4, i];
            }

            Console.WriteLine($"\nEl producto 1 generó {producto1} pesos de ganancia");
            Console.WriteLine($"El producto 2 generó {producto2} pesos de ganancia");
            Console.WriteLine($"El producto 3 generó {producto3} pesos de ganancia");
            Console.WriteLine($"El producto 4 generó {producto4} pesos de ganancia");
            Console.WriteLine($"El producto 5 generó {producto5} pesos de ganancia");
        }

        public void CURP()
        {
            string[] curp = new string[18];
            Console.WriteLine("Ingresa tu CURP carácter por carácter");
            for (int i = 0; i < curp.Length; i++)
            {
                curp[i] = Console.ReadLine().ToUpper();
            }
            for (int i = 0; i < curp.Length; i++)
            {
                Console.Write(curp[i]);
            }

            int año = int.Parse(curp[4]);

            if (curp[10] == "M" && año <= 2)
            {
                Console.WriteLine($"Usted es de sexo femenino y su fecha de nacimiento es {curp[8]}{curp[9]}/{curp[6]}{curp[7]}/20{curp[4]}{curp[5]} ");
            }
            else if (curp[10] == "M" && año > 2)
            {
                Console.WriteLine($"Usted es de sexo femenino y su fecha de nacimiento es {curp[8]}{curp[9]}/{curp[6]}{curp[7]}/19{curp[4]}{curp[5]} ");

            }
            else if (curp[10] == "H" && año <= 2)
            {
                Console.WriteLine($"Usted es de sexo masculino y su fecha de nacimiento es {curp[8]}{curp[9]}/{curp[6]}{curp[7]}/20{curp[4]}{curp[5]} ");
            }
            else if (curp[10] == "H" && año > 2)
            {
                Console.WriteLine($"Usted es de sexo masculino y su fecha de nacimiento es {curp[8]}{curp[9]}/{curp[6]}{curp[7]}/19{curp[4]}{curp[5]} ");

            }
            else { Console.WriteLine("CURP incorrecta"); }
        }
        public void Calificaciones()
        {
            Random rnd = new Random();
            int[] calificaciones = new int[10];
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = rnd.Next(1, 101);
            }
            Console.WriteLine("Matriz desordenada\n");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write($"{calificaciones[i]}, ");
            }

            int temp = 0;
            for (int i = 0; i < calificaciones.Length - 1; i++)
            {
                for (int j = i + 1; j <= calificaciones.Length - 1; j++)
                {
                    if (calificaciones[i] < calificaciones[j])
                    {
                        temp = calificaciones[i];
                        calificaciones[i] = calificaciones[j];
                        calificaciones[j] = temp;
                    }

                }
            }
            Console.WriteLine("\n\nMatriz Ordenada\n");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write(calificaciones[i] + ", ");
            }

            Console.Write("\n\n¿Que numero quieres buscar? ");
            int numero = int.Parse(Console.ReadLine());
            bool encontrado = false;
            int posicion = 0;

            while (posicion < calificaciones.Length)
            {
                if (numero == calificaciones[posicion])
                {
                    encontrado = true;
                    break;
                }


                posicion++;
            }

            if (encontrado == true)
            {
                Console.WriteLine($"El numero se encontro en la poscicion {posicion + 1} de la lista");
            }
            else Console.WriteLine("El numero no se encuentra");
        }
    }
}
