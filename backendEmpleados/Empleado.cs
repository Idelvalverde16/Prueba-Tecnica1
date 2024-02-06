using System.ComponentModel.DataAnnotations;

namespace backendEmpleados
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nombre { get; set; }

        public int Edad { get; set; }
        [MaxLength(60)]

        public string Departamento { get; set; }
        [MaxLength(60)]

        public string Cargo { get; set; }
        [MaxLength(60)]

        public string Genero { get; set; }
        [MaxLength(10)]

        public decimal Salario { get; set; }
    }
}
