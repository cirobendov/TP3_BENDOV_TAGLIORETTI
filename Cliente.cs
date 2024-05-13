using System;

class Clientes
{
    public  int DNI {get; private set;}
    public  string Apellido {get; private set;}
    public  string Nombre {get; private set;}
    public  DateTime FechaInscripción {get; set;}
    public  int TipoEntrada {get; set;}
    public  int Cantidad {get; set;}
    
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