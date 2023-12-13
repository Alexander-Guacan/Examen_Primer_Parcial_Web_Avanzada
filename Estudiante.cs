namespace Test;

public class Estudiante {
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }
    public decimal Calificacion { get; set; }

    public virtual void MostrarInformacion() {
        Console.WriteLine(
            $"Nombre: {Nombre}\n"
            + $"Edad: {Edad}\n"
            + $"Calificación: {Calificacion}"
        );
    }
}