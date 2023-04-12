using Laboratorio2.Models;
using Laboratorio2.DAO;
using Laboratorio2.Negocio;
Logica logica = new Logica();
Notas notas = new Notas();
Proceso proceso= new Proceso();



Console.WriteLine("Menu");
Console.WriteLine("Pulse 1 para calcular sus notas");
var Menu = Convert.ToInt32(Console.ReadLine());

#region Menu
switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("Ingresa el nombre de la materia");
           notas.NombreMateria = Console.ReadLine();

            Console.WriteLine("Ingresa tu nombre");
            notas.NombreEstudiante = Console.ReadLine();

            Console.WriteLine("Ingresa la nota de laboratorio 1");
            notas.Lab1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa la nota del parcial 1");
            notas.Parcial1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa la nota de laboratorio 2");
            notas.Lab2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa la nota del parcial 2");
            notas.Parcial2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa la nota de laboratorio 3");
            notas.Lab3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa la nota del parcial 3");
            notas.Parcial3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Las notas se ingresaron correctamente");
            Logica.CalcularNotas(notas);

            Proceso.AgregarNotas(notas);

            
           


            Console.WriteLine("Pulsa 1 para continuar calculando notas");
            Console.WriteLine("Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
    case 2:
        Logica.MostrarNotas(notas);
 
        Console.WriteLine("Pulsa 0 para salir");
        bucle = Convert.ToInt32(Console.ReadLine());
        break;
}




#endregion
