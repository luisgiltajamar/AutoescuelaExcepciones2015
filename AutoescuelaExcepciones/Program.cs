using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoescuelaExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a=new Alumno()
                {
                    Nombre = "Pepe",
                    Edad = 19,
                   Permiso = Permisos.B,
                    Actual = Permisos.A
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
