using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subclase_Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("El Babo", 38);
            persona1.Saludar();

            Estudiante estudiante1 = new Estudiante ("Timmy Turner", 18, 9.5, "2");
            estudiante1.Saludar();
            estudiante1.Estudiar();
            estudiante1.Grado_Decir();
            Console.ReadKey();
        }
    }
}
