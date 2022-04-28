using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Logger
    {
        public string ImprimirActualizacion(string Nombre, string NombreNuevo)
        {
            Console.Writeline("El nombre fue modificado de" + Nombre , "a" + NombreNuevo);
        }
}
}
