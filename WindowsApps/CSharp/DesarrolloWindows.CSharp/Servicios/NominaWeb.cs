using System;
using System.Net;
using CapaNegocio;

// Este paquete se instala mediante NuGet. Más info en: https://goo.gl/15J3ed
using Newtonsoft.Json;

namespace DesarrolloWindows.CSharp
{
    public class NominaWeb
    {
        public static Empleado[] ObtenerEmpleados()
        {
            var servidor = new WebClient();
            //var catalogo = servidor.DownloadString(new Uri("AQUI LA URL"));

            return new Empleado[0];
        }
    }
}