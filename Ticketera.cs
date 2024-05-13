using System;

static class Ticketera
{
    private static Dictionary <int, Clientes> dicCLientes = new Dictionary<int, Clientes>();
    private static int UltimoIDEntrada = 0;
    public static int DevolverUltimoID()
    {
        return UltimoIDEntrada;
    }
    public static int AgregarCliente(Clientes cliente)
    {
        dicCLientes.Add(UltimoIDEntrada, cliente);
        UltimoIDEntrada++;
        return UltimoIDEntrada;
    }
    public static Clientes BuscarCliente(int ID)
    {
        bool existe;
        Clientes clienteObtenido = null;
        Console.WriteLine("Ingrese el cliente");
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
    public static bool CambiarEntrada(int ID, int tipo, int cantidad, Dictionary<int, double> Entradas)
    {
        int IDIngresado;     
        Console.WriteLine("Ingrese su id");
        IDIngresado = int.Parse(Console.ReadLine());
        if (BuscarCliente(IDIngresado) != null)
        {
            do
            {
                Console.WriteLine("Ingrese el nuevo tipo de entrada");
                tipo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantudad");
                cantidad = int.Parse(Console.ReadLine());
              
            } while(Entradas.ContainsKey(tipo));
            if(tipo * cantidad > dicCLientes[IDIngresado].Cantidad * Entradas[dicCLientes[IDIngresado].TipoEntrada])
            {
                dicCLientes[IDIngresado].Cantidad = cantidad;
                dicCLientes[IDIngresado].TipoEntrada = tipo;
                return true;
            }
            else 
            {
                Console.WriteLine("El monto es menor al anterior");
                return false;
            }
        }
        else 
        {
            Console.WriteLine("El ingreso no es valido");
            return false;
        }
    }
    public static void EstadisticasTicketera(int[] sumas,Dictionary<int, double> Entradas, int suma)
    {
        double[] porcentajes;
        List<double> rec; 
        porcentajes = CalcularPorcentaje(sumas, suma);
        rec = CalcularRecaudacion(sumas, Entradas);
        Console.WriteLine("La cantidad de clientes inscriptos es de " + suma);
        Console.WriteLine("");
        Console.WriteLine("Entrada 1: " + sumas[0] + porcentajes[0] + rec[0]);
        Console.WriteLine("Entrada 2: " + sumas[1] + porcentajes[1] + rec[1]);
        Console.WriteLine("Entrada 3: " + sumas[2] + porcentajes[2] + rec[2]);
        Console.WriteLine("Entrada 4: " + sumas[3] + porcentajes[3] + rec[3]);
        Console.WriteLine("La recaudacion total es de " + (rec[0] + rec[1] + rec[2] + rec[3])); 
    }
    private static double[] CalcularPorcentaje(int[] sumas, int suma)
    {
        double[] porcentajes = new double[4];
        porcentajes[0] = sumas[0] *100/ suma; 
        porcentajes[1] = sumas[1] *100/ suma; 
        porcentajes[2] = sumas[2] *100/ suma; 
        porcentajes[3] = sumas[3] *100/ suma; 
        return porcentajes;
    }
    private static List<double> CalcularRecaudacion(int[] sumas, Dictionary<int, double> Entradas)
    {
        List<double> recaudaciones = new List<double>();
        recaudaciones[0] = Entradas[1] * sumas[0];
        recaudaciones[1] = Entradas[2] * sumas[1];
        recaudaciones[2] = Entradas[3] * sumas[2];
        recaudaciones[3] = Entradas[4] * sumas[3];
        return recaudaciones;
    }
}
