using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpleadoWebApi.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Perfil { get; set; }
        public string Departamento { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public bool IsDone { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
