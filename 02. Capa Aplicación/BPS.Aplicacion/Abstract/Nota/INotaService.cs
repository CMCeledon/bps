using System.Collections.Generic;
using System.Data;
using BPS.Aplicacion.Helpers;
using BPS.Comun.Dto;
using BPS.Modelo.EntityModel;

namespace BPS.Aplicacion.Abstract
{
    public interface INotaService
    {
        ResponseServices<List<ConsultarNotasEstudiantes_Result>> ConsultarNotasEstudiantes();
        ResponseServices<int> EliminarNota(long idNota);
        ResponseServices<int> InsertarNota(NotaDto nota);
        ResponseServices<int> ActualizarNota(NotaDto nota);
    }
}
