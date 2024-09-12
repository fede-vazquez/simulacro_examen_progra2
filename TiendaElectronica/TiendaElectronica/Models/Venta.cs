using System.Security.Cryptography.X509Certificates;

namespace TiendaElectronica.Models
{
    public class Venta
    {
        public DateTime Fecha { get; private set; }
        public Producto ProductoVendido { get; private set; }
        public int Cantidad { get; private set; }
        public Cliente Cliente { get; private set; }

        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            Fecha = fecha;
            ProductoVendido = productoVendido;
            Cantidad = cantidad;
            Cliente = cliente;
        }

        public double CalcularTotal() => ProductoVendido.Precio * Cantidad;

        public void MostrarVenta()
        {
            Console.WriteLine($"Producto: {ProductoVendido.Nombre}, Cantidad: {Cantidad}");
            Console.WriteLine($"Precio del producto: {ProductoVendido.Precio}, Total: {CalcularTotal()}");
            Console.WriteLine($"Cliente: {Cliente.Nombre}, Codigo: {Cliente.Codigo}");
        }
    }
}
