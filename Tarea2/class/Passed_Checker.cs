
namespace programa2;


public class Claseprograma2
{

    public void Checarsiaprobo()
    {
        string alumno = "Mario Suarez";
        int notascantidad = 0;
        int sumatotal = 0;
        float promedio = 0f;
        bool exit = false;
        List<int> listanotas = new List<int>();


        Console.WriteLine("---------------------Está ejecutando el programa #2--------------------- \n\n\n");

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

        Console.WriteLine($"El promedio de {alumno} es igual a {promedio}\n\n");

    }
}