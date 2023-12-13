namespace Test;
static class Program {

    public static void Main(string[] args) {
        Console.WriteLine("Ejercicio 1");
        VariablesAndOperators();

        Console.WriteLine("\nEjercicio 2");
        ControlStructures();

        Console.WriteLine("\nEjercicio 3");
        PooClassAndMethods();

        Console.WriteLine("\nEjercicio 4");
        PooMethods();

        Console.WriteLine("\nEjercicio 5");
        PooInheritance();
    }

    public static void VariablesAndOperators() {
        int numero1 = 2003;
        int numero2 = 780;
        int resultado = numero1 + numero2;

        Console.WriteLine($"Resultado = {resultado}");
    }
    
    public static void ControlStructures() {
        int edad = 23;
        const int mayoriaDeEdad = 18;

        if (edad >= mayoriaDeEdad) {
            Console.WriteLine("La persona es mayor de edad");
        } else {
            Console.WriteLine("La persona no es mayor de edad");
        }
    }

    public static void PooClassAndMethods() {
        Estudiante estudiante1 = new Estudiante{
            Nombre = "Alexander Guacán",
            Edad = 20,
            Calificacion = 17.0m
        };

        Console.WriteLine(
            $"Nombre: {estudiante1.Nombre}\n"
            + $"Edad: {estudiante1.Edad}\n"
            + $"Calificación: {estudiante1.Calificacion}"
        );
    }

    public static void PooMethods() {
        Estudiante estudiante1 = new Estudiante{
            Nombre = "Alexander Guacán",
            Edad = 20,
            Calificacion = 17.0m
        };

        estudiante1.MostrarInformacion();
    }

    public static void PooInheritance() {
        EstudianteGraduado graduado1 = new EstudianteGraduado {
            Nombre = "Alexander Guacán",
            Edad = 20,
            Calificacion = 19.0m,
            Titulo = "Ingeniero en Software"
        };

        graduado1.MostrarInformacion();
    }
}