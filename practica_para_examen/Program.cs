// Creamos el objeto de cliente y su instancia
Clientes cliente1 = new Clientes();
cliente1.Id = 1;
cliente1.Nombre = "Darlink";
cliente1.Edad = 19;
cliente1.Estatura = 1.52m;
cliente1.Actividad = true;

Console.WriteLine(cliente1.Id);
Console.WriteLine(cliente1.Nombre);

// Creamos el objeto de empleado y su instancia
Empleados empelado1 = new Empleados();
empelado1.Id = 2;
empelado1.Nombre = "Juan Esteban";
empelado1.Edad = 20;
empelado1.Estatura = 1.73m;
empelado1.Cargo = "Secretario";

Console.WriteLine(empelado1.Id);
Console.WriteLine(empelado1.Nombre);
Console.WriteLine(empelado1.Cargo);

// Creamos el objeto de autor y su instancia
Autores autor1 = new Autores();
autor1.Id = 3;
autor1.Nombre = "Brayan";
autor1.Nacimiento = DateTime.Now;

Console.WriteLine(autor1.Id);
Console.WriteLine(autor1.Nombre);
Console.WriteLine(autor1.Nacimiento);

// Creamos el objeto de libro y su instancia
Libros libro1 = new Libros();
libro1.Id = 102;
libro1.Titulo = "Cien años de soledad";
libro1.Autor = new Autores { Id = 3, Nombre = "Brayan" };

Console.WriteLine(libro1.Id);
Console.WriteLine(libro1.Autor); // Arreglar

// Se llaman las funciones
cliente1.Mostrar_información();
empelado1.Mostrar_información();

cliente1.Libros = new List<Libros>();
cliente1.Libros.Add(new Libros() { Id = 102, Titulo = "Cien años de soledad" });
cliente1.Libros.Add(new Libros() { Id = 102, Titulo = "Poca vida" });
cliente1.Libros.Add(new Libros() { Id = 102, Titulo = "Ensayo sobre la ceguera" });

foreach (var elemento in cliente1.Libros)
{
    Console.WriteLine(elemento.Titulo);
}



public class Libros
{
    public int Id;
    public string? Titulo;
    public Autores? Autor;
}

public class Usuarios
{
    public int Id;
    public string? Nombre;
    public int Edad;
    public decimal Estatura;

    public virtual void Mostrar_información() //Polimorfismo
    {
        Console.WriteLine($"Id {Id}, Nombre {Nombre}, edad {Edad},estatura {Estatura}");
    }

}

public class Clientes : Usuarios
{
    public bool Actividad;
    public List<Libros>? Libros; // Se crea la lista

    public override void Mostrar_información() //Polimorfismo
    {
        Console.WriteLine($"El estado del cliente {Nombre} con c.c {Id} es: {Actividad} ");
    }
}

public class Empleados : Usuarios
{
    public string? Cargo;

    public override void Mostrar_información()
    {
        Console.WriteLine($"Señor@ {Nombre}, su cargo es {Cargo} ");
    }
}

public class Autores : Usuarios
{
    public DateTime Nacimiento;

}

