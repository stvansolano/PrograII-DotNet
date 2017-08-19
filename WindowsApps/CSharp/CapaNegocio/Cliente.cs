using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CapaNegocio
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }

        public string NombreCompleto {
            get
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }
        
        public static Cliente[] ObtenerClientes(DataTable tabla) 
        {
            var consulta = from cliente in tabla.AsEnumerable()

                           select new Cliente {
                               Nombre = cliente.Field<string>("Nombre"),
                               Telefono = cliente.Field<string>("Telefono"),
                               PrimerApellido = cliente.Field<string>("PrimerApellido"),
                               SegundoApellido = cliente.Field<string>("SegundoApellido")
                               
                           };

            var ordenado = (from elemento in consulta
                                orderby elemento.PrimerApellido
                                select elemento);
            return ordenado.ToArray();
        }
    }
}
