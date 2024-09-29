using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicio04.DatosDeUnaPersona
{
    internal class Persona
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TiposNumero TipoNumero { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoArea { get; set; }
        public int NumeroTel { get; set; }
    }
}
