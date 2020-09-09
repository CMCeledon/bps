using System.Collections.Generic;
using System.Data;
using BPS.Aplicacion.Helpers;
using BPS.Comun.Dto;
using BPS.Modelo.EntityModel;

namespace BPS.Aplicacion.Abstract
{
    public interface IEstudianteService
    {
        ResponseServices<List<Estudiante>> ConsultarEstudiantes();
        ResponseServices<Estudiante> ConsultarEstudianteId(long idEstudiante);
        ResponseServices<int> EliminarEstudiante(long idEstudiante);
        ResponseServices<int> InsertarEstudiante(EstudianteDto estudiante);
        ResponseServices<int> ActualizarEstudiante(EstudianteDto estudiante);
    }
}
