using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PaginaPerfil_V1_net_4_6.Modelo
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ciudad { get; set; }
        public string Email { get; set; }
        public string Mensaje { get; set; }
    }

    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }       
    }

    public class ListContactos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad { get; set; }
    }

    public class Maps
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
