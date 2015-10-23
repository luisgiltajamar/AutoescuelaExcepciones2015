using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoescuelaExcepciones
{
    public class EdadIncorrectaException:Exception
    {
        public EdadIncorrectaException(int edad) :
            base("Edad incorrecta " + edad)
        {
            
        }
    }
}
