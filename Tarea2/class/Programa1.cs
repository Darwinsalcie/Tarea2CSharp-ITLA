// Creamos un nuevo namespace
using System.Security.Cryptography.X509Certificates;

namespace Programa1
{
    public class Claseprograma1
    {
        public void ejecutarprograma1()
        {
            //variables
            int num1 = 0;
            int num2 = 0;
            bool exit=false;
            bool esmayor = false;

            Console.WriteLine("---------------------Está ejecutando el programa #1--------------------- \n\n\n");

            while (exit == false)
            {
                try
                {
                    Console.Write("Ingrese el primer número: ");  //pedimos y asignamos el primer número
                    num1 = Convert.ToInt32(Console.ReadLine());


                    exit = true;
                }


                catch (Exception)
                {
                    Console.WriteLine("\n\n¡Sólo se admiten números!\n\n");
                }
            }

            exit = false;

            while (exit == false)
            {
                try
                {

                    Console.Write("Ingrese el segundo número:");   //pedimos y asignamos el segundo número
                    num2 = Convert.ToInt32(Console.ReadLine());

                    exit = true;
                }


                catch (Exception)
                {
                    Console.WriteLine("\n\n¡Sólo se admiten números!\n\n");
                }
            }


            //Comparar los numeros

            if (num1 > num2)
            {
                Console.WriteLine($"\nEl primer número es mayor que el segundo número, puesto que {num1} > {num2}.");
                esmayor = true;
            }

            else
            {
                Console.WriteLine($"\nEl primer número es menor o igual que el segundo número, puesto que {num1} <= {num2}.");

            }

            //Operaciones

            if (esmayor == true)
            {

                int resultadosuma = num1 + num2;
                int resultadoresta = num1 - num2;
                Console.WriteLine($"{num1} + {num2} = {resultadosuma}");
                Console.WriteLine($"{num1} - {num2} = {resultadoresta}\n\n");

            }

            else
            {
                int resultadomult = num1 * num2;
                int resultadodiv = num1 / num2;

                Console.WriteLine($"{num1} * {num2} = {resultadomult}");
                Console.WriteLine($"{num1} / {num2} = {resultadodiv}\n\n");

            }

        }

    }
}