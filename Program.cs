using System;

Dictionary <int, double> Entradas = new Dictionary<int, double>();
    Entradas.Add(1, 45000);
    Entradas.Add(2, 60000);
    Entradas.Add(3, 30000);
    Entradas.Add(4, 100000);

static void NuevaInscripcion()
{
    string apellido, nombre; 
    DateTime fechaInscripcion = DateTime.Now; 
    int tipoentrada, cant, dni;
    

    Console.WriteLine("Ingrese el nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido");
    apellido = Console.ReadLine();
    do
    {
        Console.WriteLine("Ingrese el tipo de entrada");
        tipoentrada = int.Parse(Console.ReadLine());
    } while(tipoentrada < 1 || tipoentrada > 4);
    Console.WriteLine("Ingrese la cantidad");
    cant = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su dni");
    dni = int.Parse(Console.ReadLine());

    Clientes cliente = new Clientes(dni, apellido, nombre, fechaInscripcion, tipoentrada, cant);
}