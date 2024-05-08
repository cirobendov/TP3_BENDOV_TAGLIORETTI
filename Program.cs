using System;


static void NuevaInscripcion()
{
    string apellido, nombre; 
    DateTime fechaInscripcion = DateTime.Now; 
    int tipoentrada, cant, dni;

    Console.WriteLine("Ingrese el nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido");
    apellido = Console.ReadLine();
    Console.WriteLine("Ingrese el tipo de entrada");
    tipoentrada = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad");
    cant = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su dni");
    dni = int.Parse(Console.ReadLine());

    Clientes cliente = new Clientes(dni, apellido, nombre, fechaInscripcion, tipoentrada, cant);
}