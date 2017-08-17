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
        
        public static Cliente[] ObtenerClientes(DataTable tabla) 
        {
            var consulta = from cliente in tabla.AsEnumerable()
                           select new Cliente {
                               Nombre = cliente.Field<string>("Nombre"),
                               Telefono = cliente.Field<string>("Telefono")
                           };

            return consulta.ToArray();
        }
    }
}
