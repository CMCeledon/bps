using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS.Comun.Dto
{
    public class NotasEstudiantesDto
    {
        public long idEstudiante { get; set; }
        public long idProfesor { get; set; }
        public long idNota { get; set; }
        public string NotaString { get; set; }
        public decimal ValorNota { get; set; }
        public string NombreEstudiante { get; set; }
        public string NombreProfesor { get; set; }
    }
}
