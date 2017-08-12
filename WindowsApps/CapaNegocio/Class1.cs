using System.Data;
using System.Linq;

namespace CapaNegocio
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string NombreCompleto
        {
            get { return Nombre + " " + PrimerApellido; }
        }

        public static Cliente[] ObtenerClientes(DataTable tabla)
        {
            var resultado = (from fila in tabla.AsEnumerable()
                          let cliente = new Cliente {
                              Nombre = fila.Field<string>("Nombre"),
                              PrimerApellido = fila.Field<string>("PrimerApellido")
                          }
                          select cliente).ToArray();

            return resultado;
        }
    }
}
