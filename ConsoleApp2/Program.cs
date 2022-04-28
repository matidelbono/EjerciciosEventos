internal class Program
{
    static void Main (string[] args)
    {
        Persona persona = new Persona();
        persona.ActualizacionNombreCompletado += ActualizacionNombreCompletadoHandler;
        Console.Read;
    }
    static void ActualizacionNombreCompletadoHandler(object? sender, ActualizacionEventArgs e)
    {
        Console.Writeline("termino la actualizacion");
    }
}
