using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Persona
    {
        public EventHandler<ActualizacionEventArgs> ActualizacionNombreCompletado;
        private string Nombre { get; set; }
        public string ActualizarNombre (string Nuevonombre)
        {
            Nombre = Nuevonombre;
            if (this.ActualizacionNombreCompletado != null)
                this.ActualizacionNombreCompletado(this, new ActualizacionEventArgs() { Nombre = Nombre });
            return Nombre;
        }


}
}
