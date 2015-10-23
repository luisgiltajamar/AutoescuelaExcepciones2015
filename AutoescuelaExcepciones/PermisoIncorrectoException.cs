using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoescuelaExcepciones
{
   public class PermisoIncorrectoException:Exception
    {
       public PermisoIncorrectoException(String msg) :
           base(msg)
       {
           
       }
    }
}
