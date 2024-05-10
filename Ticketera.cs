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
    public static void BuscarCliente(int ID)
    {

    }
    public static int CambiarEntrada(int ID, int tipo, int cantidad)
    {

    }
    public static List<string> EstadisticasTicketera()
    {

    }
}