using ConsolaSeniorCoca;

Estructurada.EjecutarEstructurada();

Persona seniorCoca = new(
    nombre: "Señor Coca",
    altura: 1.75M,
    edad: 29,
    ojosColor: "Popo",
    cantidadBrazos: 2,
    cantidadPiernas: 2);

Persona lepe = new(
    nombre: "Señor Lepe",
    altura: 1.75M,
    edad: 24,
    ojosColor: "Popo",
    cantidadBrazos: 2,
    cantidadPiernas: 1);

List<Persona> personas = [seniorCoca, lepe];

Persona? personaMasViejita = null;

foreach (Persona persona in personas)
{
    if (personaMasViejita != null)
    {
        bool actualMasViejito = persona.Edad > personaMasViejita.Edad;

        if (actualMasViejito)
        {
            personaMasViejita = persona;
        }
    }
    else
    {
        personaMasViejita = persona;
    }
}

seniorCoca.Habla("popo");
seniorCoca.Habla(hablaDeTusBrazos: true);

await Task.Delay(5000);

public class Animal
{
    public string Nombre { get; set; } = null!;

    public void Habla(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

public class Persona : Animal
{
    public decimal Altura { get; set; }
    public int Edad { get; set; }
    public string OjosColor { get; set; } = null!;
    private int CantidadBrazos { get; set; }
    private int CantidadPiernas { get; set; }

    public Persona(string nombre, decimal altura, int edad, string ojosColor, int cantidadBrazos, int cantidadPiernas)
    {
        Nombre = nombre;
        Altura = altura;
        Edad = edad;
        OjosColor = ojosColor;
        CantidadBrazos = cantidadBrazos;
        CantidadPiernas = cantidadPiernas;
    }

    public void Habla(bool hablaDeTusBrazos = false, bool hablaDeTusPiernas = false)
    {
        if (hablaDeTusBrazos)
        {
            Console.WriteLine($"Hola, tengo {CantidadBrazos} brazos.");
        }

        if (hablaDeTusPiernas)
        {
            Console.WriteLine($"Hola, tengo {CantidadPiernas} brazos.");
        }
    }
}
