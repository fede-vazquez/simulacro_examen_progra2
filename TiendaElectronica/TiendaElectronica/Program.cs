using TiendaElectronica.Models;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Juan Perez", 123456, "asr-ftr");
        cliente.MostrarCliente();

        Producto producto = new Producto("un producto re piola", 9999, "asd-fgh");
        producto.MostrarDetalles();

        Venta venta = new Venta(new DateTime(2024, 9, 12), producto, 2, cliente);
        venta.MostrarVenta();
    }
}