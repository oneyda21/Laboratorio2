using Laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.DAO
{

    public class Proceso
    {
        public static void AgregarNotas(Notas ParamentrosNotas)
        {

            using (NotaEstudianteContext db =
                new NotaEstudianteContext())
            {
                Notas notas = new Notas();
                notas.NombreMateria = ParamentrosNotas.NombreMateria;
                notas.NombreEstudiante = ParamentrosNotas.NombreEstudiante;
                notas.Lab1 = ParamentrosNotas.Lab1;
                notas.Parcial1 = ParamentrosNotas.Parcial1;
                notas.Lab2 = ParamentrosNotas.Lab2;
                notas.Parcial2 = ParamentrosNotas.Parcial2;
                notas.Lab3 = ParamentrosNotas.Lab3;
                notas.Parcial3 = ParamentrosNotas.Parcial3;
            notas.Resultado= ParamentrosNotas.Resultado;
                db.Add(notas);
                db.SaveChanges();
            }

        }
      



    }
}
