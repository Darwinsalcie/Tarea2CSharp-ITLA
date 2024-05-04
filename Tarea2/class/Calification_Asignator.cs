
namespace Programa3;


public class Claseprograma3
{

    public void AsignarCalificacion()
    {
        string alumno = "Pedro Soriano";
        int notascantidad = 0;
        int sumatotal = 0;
        float promedio = 0f;
        float promediocifras = 0f;
        bool exit = false;
        List<int> listanotas = new List<int>();


        Console.WriteLine("---------------------Está ejecutando el programa #3--------------------- \n\n\n");

        //ingrese la cantidad de notas
        Console.Write("Ingrese la cantidad de notas con las que trabajará: ");


        while (exit == false)
        {

            try
            {   //cantidad de notas
                notascantidad = Convert.ToInt32(Console.ReadLine());
                exit = true;
            }

            catch (Exception)
            {
                Console.WriteLine("\n\n¡Sólo se admiten números!\n\n");
            }

            Console.WriteLine("\n");
        }



        //pedir notas
        for (int i = 1; i <= notascantidad; i++)
        {
            exit = false;
            while (exit == false)
            {

                try
                {
                    Console.Write($"Ingrese la nota número {i}:");

                    listanotas.Add(Convert.ToInt32(Console.ReadLine()));      //agregar notas a la lista

                    exit = true;

                }

                catch (Exception)

                {
                    Console.WriteLine("\n\n¡Sólo se admiten números!\n\n");

                }

            }


        }

        //sumar notas


        foreach (int nota in listanotas)
        {
            sumatotal += nota;
        }

        //promediar

        promedio = ((float)sumatotal / (float)notascantidad);
        promediocifras = promedio;
        int cantidaddecifras = 1;

        while (promediocifras >=1)    //Convertir a nota de una sola unidad
        {
            promediocifras /= 10;
            cantidaddecifras *=10;
        }

        promedio = (10 * promedio) / (cantidaddecifras);

        if (promedio >=7)
        {
            Console.WriteLine($"\n\n{alumno} fue Promovido");
        }

        else if (promedio >= 4 && promedio <7)
        {
            Console.WriteLine($"\n\n{alumno} obtuvo un Regular");
        }

        else if(promedio >4)
        {
            Console.WriteLine($"\n\n{alumno} fue Reprobado");
        }



    }
}