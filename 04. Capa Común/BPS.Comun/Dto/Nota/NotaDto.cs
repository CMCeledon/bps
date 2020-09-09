using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPS.Comun.Dto
{
    public class NotaDto
    {
        public long IdNota { get; set; }
        public long IdProfesor { get; set; }
        public long IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
    }
}
