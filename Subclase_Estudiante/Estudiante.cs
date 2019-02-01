using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subclase_Estudiante
{
    class Estudiante:Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante(string nombre, int edad, double promedio, string grado): base(nombre,edad)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public virtual void Estudiar()
        {
            Console.WriteLine("Estoy estudiando duro en mi clase de programación");
        }
        public virtual void Grado_Decir()
        {
            Console.WriteLine("Mi semestre es: {0}",Grado);
        }
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy {0} y mi grado es {1}", Nombre, Grado);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} años, grado {2}, promedio {3}", Nombre, Edad, Grado, Promedio);
        }
    }
}
