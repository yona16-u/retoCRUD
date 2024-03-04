using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retoCRUD.ENTIDADES
{
    public class E_clientes
    {//DEFINICION DE ENTIDADES 
        public int IdCliente { get; set; }
        public decimal Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Telefono { get; set; }
        public string Direccion { get; set; }
        public int CodGrupo { get; set; }
        public int CodDoc { get; set; }
    }
}
