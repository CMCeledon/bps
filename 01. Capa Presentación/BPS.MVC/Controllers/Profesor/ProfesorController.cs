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
	public class ProfesorController : ApiController
	{
		private readonly IProfesorService _service;

		public ProfesorController(IProfesorService service)
		{
			_service = service;
		}

		public ProfesorController()
		{
			ProfesorService servicio = new ProfesorService();
			_service = servicio;
		}

		[ExceptionHandler]
		[HttpGet]
		public ResponseServices<List<Profesor>> ConsultarPorfesores()
		{
			var response = _service.ConsultarPorfesores();
			return response;
		}

		[ExceptionHandler]
		[HttpGet]
		public ResponseServices<Profesor> ConsultarProfesorId(long idProfesor)
		{
			var response = _service.ConsultarProfesorId(idProfesor);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> InsertarProfesor(ProfesorDto profesor)
		{
			var response = _service.InsertarProfesor(profesor);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> EliminarPorfesor(long idProfesor)
		{
			var response = _service.EliminarPorfesor(idProfesor);
			return response;
		}

		[ExceptionHandler]
		public ResponseServices<int> ActualizarPorfesor(ProfesorDto profesor)
		{
			var response = _service.ActualizarPorfesor(profesor);
			return response;
		}
	}
}