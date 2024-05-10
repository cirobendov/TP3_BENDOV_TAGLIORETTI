using System;

static class Ticketera
{
    private static Dictionary <int, Clientes> dicCLientes;

    private static int UltimoIDEntrada = 0;
    public static int DevolverUltimoID()
    {
        return UltimoIDEntrada;
    }
    public static int AgregarCliente(Clientes cliente)
    {
        UltimoIDEntrada++;
        dicCLientes.Add(UltimoIDEntrada, cliente);
        return UltimoIDEntrada;
           
    }
    public static Clientes BuscarCliente(int ID, Dictionary <int, Clientes> dicCLientes)
    {
        bool existe;
        Clientes clienteObtenido = null;
        existe =  dicCLientes.ContainsKey(ID);
        if (existe == true)
        {
            clienteObtenido = dicCLientes[ID];
        }
        else 
        {
            Console.WriteLine("No se ha encontrado un cliente con ese ID");
        }
        return clienteObtenido;

    }
    public static bool CambiarEntrada(int ID, int tipo, int cantidad, Dictionary<int, double> Entradas, Dictionary <int, Clientes> dicCLientes)
    {
        int IDIngresado;
        Console.WriteLine("Ingrese su id");
        IDIngresado = int.Parse(Console.ReadLine());
        if (BuscarCliente(IDIngresado, dicCLientes) != null)
        {
            do
            {
                Console.WriteLine("Ingrese el nuevo tipo de entrada");
                tipo = int.Parse(Console.ReadLine());
            } while(Entradas.ContainsKey(tipo));
            if(Entradas.Values > dicCLientes[ID].)
        }
    }
    public static List<string> EstadisticasTicketera()
    {

    }
}