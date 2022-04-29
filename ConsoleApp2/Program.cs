internal class Program
{
    static void Main (string[] args)
    {
        Persona persona = new Persona();
        persona.ActualizacionNombreCompletado += ActualizacionNombreCompletadoHandler;
        persona.ActualizarNombre("Matias", "Alejandro");
        Console.Read;
    }
    static void ActualizacionNombreCompletadoHandler(object? sender, ActualizacionEventArgs e)
    {
        Console.Writeline("termino la actualizacion de" + Nombre, "a" + NombreNuevo);
    }
    // duda 1 : Cómo configuro al suscriptor si este está en una clase distinta de la que tiene el evento asociado?
    // duda 2: Cómo se pasa el método ActualizarNombre como parámetro a través del delegado ActualizacionNombreCompletado?
}

