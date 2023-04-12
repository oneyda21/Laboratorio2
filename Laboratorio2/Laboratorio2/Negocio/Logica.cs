using Laboratorio2.DAO;
using Laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Negocio
{
    
    public class Logica
    {
        public static void MostrarNotas(Notas notas)
        {

            NotaEstudianteContext db = new NotaEstudianteContext();
            #region MostrarPro
            var ListNotas = db.Nota.ToList();

            foreach (var not in ListNotas)
            {
                Console.WriteLine("===================================");
                Console.WriteLine($"Materia: {not.NombreMateria}\n" +
                                  $"Nombre estudiante: {not.NombreEstudiante}\n"+
                                  $"Las notas ingresadas son \n"+
                                  $"Lab 1: {not.Lab1}\n" +
                                  $"Parcial 1 : {not.Parcial1}\n" +
                                  $"Lab 2: {not.Lab2}\n" +
                                  $"Parcial 2: {not.Parcial2}\n" +
                                  $"Labo 3: {not.Lab2}\n" +
                                   $"Parcial 3: {not.Parcial3}\n" +
                                  $"Resultado Final: {not.Resultado}\n");

                Console.WriteLine("===================================");
            }
            #endregion

        }
        public static void CalcularNotas(Notas notas)
        {
           
            decimal periodo1lab1 = notas.Lab1 * 0.40m;
            decimal periodo1parcial1 = notas.Parcial1 * 0.60m;
            decimal periodo1resultado = periodo1lab1 + periodo1parcial1;

            decimal periodo2lab2 = notas.Lab2 * 0.40m;
            decimal periodo2parcial2 = notas.Parcial2 * 0.60m;
            decimal periodo2resultado = periodo2lab2 + periodo2parcial2;


            decimal periodo3lab3 = notas.Lab3 * 0.40m;
            decimal periodo3parcial3 = notas.Parcial3 * 0.60m;
            decimal periodo3resultado = periodo3lab3 + periodo3parcial3;


            decimal Resultado = (periodo1resultado + periodo2resultado + periodo3resultado) / 3;
           

          
           
            Console.WriteLine( "El resultado es "+ Resultado);
      notas.Resultado = Resultado;


        }
    }
}
