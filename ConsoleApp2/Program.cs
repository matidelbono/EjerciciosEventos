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
        Console.Writeline("termino la actualizacion");
    }
}
