using System;

Dictionary <int, double> Entradas = new Dictionary<int, double>();
Entradas.Add(1, 45000);
Entradas.Add(2, 60000);
Entradas.Add(3, 30000);
Entradas.Add(4, 100000);
int opcion, id = -1, suma = 0, tipo = 0, cantidad = 0;
int[] sumasEntradas = new int [4] {0, 0, 0, 0};


do
{
    opcion = Menu();

    switch(opcion)
    {
        case 1:
        NuevaInscripcion(sumasEntradas, id, suma, tipo, cantidad);
        break;
        case 2:
        Ticketera.EstadisticasTicketera(sumasEntradas, Entradas, suma);
        break;
        case 3:
        Ticketera.BuscarCliente(id);
        break;
        case 4:
        Ticketera.CambiarEntrada(id, tipo, cantidad, Entradas);
        break;

    }
} while (opcion != 5);

static void NuevaInscripcion(int[] sumasEntradas, int id, int suma, int tipo, int cantidad)
{

    string apellido, nombre; 
    DateTime fechaInscripcion = DateTime.Today; 
    int dni;
    Console.WriteLine("Ingrese el nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido");
    apellido = Console.ReadLine();
    do
    {
        Console.WriteLine("Ingrese el tipo de entrada");
        tipo = int.Parse(Console.ReadLine());
    } while(tipo < 1 || tipo > 4);
    Console.WriteLine("Ingrese la cantidad");
    cantidad = int.Parse(Console.ReadLine());
    switch(tipo)
    {
        case 1:
        sumasEntradas[1] = (sumasEntradas[1]++) * cantidad;
        break;
        case 2:
        sumasEntradas[2] = (sumasEntradas[2]++) * cantidad;
        break;
        case 3:
        sumasEntradas[3] = (sumasEntradas[3]++) * cantidad;
        break;
        default:
        sumasEntradas[4] = (sumasEntradas[4]++) * cantidad;
        break;
    }
    

    Console.WriteLine("Ingrese su dni");
    dni = int.Parse(Console.ReadLine());

    Clientes cliente = new Clientes(dni, apellido, nombre, fechaInscripcion, tipo, cantidad);
    id = Ticketera.AgregarCliente(cliente);
    suma ++;
}
static int Menu()
{
    int opcion;
    do
    {
        Console.WriteLine("1. Nueva inscripcion");
        Console.WriteLine("2. Obtener estadisticas");
        Console.WriteLine("3. Buscar cliente");
        Console.WriteLine("4. Cambiar entrada");
        Console.WriteLine("5. Salir");
        opcion = int.Parse(Console.ReadLine());
    } while(opcion > 5 || opcion < 1);
    return opcion;
}
