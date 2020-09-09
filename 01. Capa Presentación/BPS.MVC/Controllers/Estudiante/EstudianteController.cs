using BPS.Aplicacion.Abstract;
using BPS.Aplicacion.Helpers;
using BPS.Aplicacion.Implements;
using BPS.Comun.Dto;
using BPS.Modelo.EntityModel;
using NLog.Fluent;
using System.Collections.Generic;
using System.Web.Http;

namespace BPS.MVC.Controllers.AppService
{
	public class EstudianteController : ApiController
	{
		private readonly IEstudianteService _service;

		public EstudianteController(IEstudianteService service)
		{
			_service = service;
		}

		public EstudianteController()
		{
			EstudianteService servicio = new EstudianteService();
			_service = servicio;
		}

		[ExceptionHandler]
		[HttpGet]
		public ResponseServices<List<Estudiante>> ConsultarEstudiantes()
		{
			var response = _service.ConsultarEstudiantes();
			return response;
		}

		[ExceptionHandler]
		[HttpGet]
		public ResponseServices<Estudiante> ConsultarEstudianteId(long idEstudiante)
		{
			var response = _service.ConsultarEstudianteId(idEstudiante);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> InsertarEstudiante(EstudianteDto estudiante)
		{
			var response = _service.InsertarEstudiante(estudiante);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> EliminarEstudiante(long idEstudiante)
		{
			var response = _service.EliminarEstudiante(idEstudiante);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> ActualizarEstudiante(EstudianteDto estudiante)
		{
			var response = _service.ActualizarEstudiante(estudiante);
			return response;
		}
	}
}