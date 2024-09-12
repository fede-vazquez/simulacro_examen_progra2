namespace TiendaElectronica.Models
{
    public class Producto
    {
        public string Nombre { get; private set; }
        public double Precio { get; private set; }
        public string Codigo { get; private set; }

        public Producto(string nombre, double precio, string codigo)
        {
            Nombre = nombre;
            Precio = precio;
            Codigo = codigo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}, Codigo: {Codigo}\n");
        }
    }
}
