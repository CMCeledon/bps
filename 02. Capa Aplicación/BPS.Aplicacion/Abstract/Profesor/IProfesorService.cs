using System.Collections.Generic;
using System.Data;
using BPS.Aplicacion.Helpers;
using BPS.Comun.Dto;
using BPS.Modelo.EntityModel;

namespace BPS.Aplicacion.Abstract
{
    public interface IProfesorService
    {
        ResponseServices<List<Profesor>> ConsultarPorfesores();
        ResponseServices<Profesor> ConsultarProfesorId(long idEstudiante);
        ResponseServices<int> EliminarPorfesor(long idEstudiante);
        ResponseServices<int> InsertarProfesor(ProfesorDto estudiante);
        ResponseServices<int> ActualizarPorfesor(ProfesorDto estudiante);
    }
}
