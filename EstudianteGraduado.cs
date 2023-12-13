namespace Test;

public class EstudianteGraduado : Estudiante {
    public string Titulo { get; set; } = "";

    public override void MostrarInformacion() {
        base.MostrarInformacion();
        Console.WriteLine($"Titulo: {Titulo}");
    }
}