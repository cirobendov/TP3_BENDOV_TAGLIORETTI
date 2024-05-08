using System;

class Clientes
{
    public static int DNI {get; private set;}
    public static string Apellido {get; private set;}
    public static string Nombre {get; private set;}
    public static DateTime FechaInscripción {get; set;}
    public static int TipoEntrada {get; set;}
    public static int Cantidad {get; set;}

    public Clientes(int dni, string apellido, string nombre, DateTime fechaInscripcion, int tipoentrada, int cant)
    {
        dni = DNI;
        apellido = Apellido;
        nombre = Nombre;
        fechaInscripcion = FechaInscripción;
        tipoentrada = TipoEntrada;
        cant = Cantidad;
    }


}