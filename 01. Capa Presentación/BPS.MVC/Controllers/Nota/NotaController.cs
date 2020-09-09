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
	public class NotaController : ApiController
	{
		private readonly INotaService _service;

		public NotaController(INotaService service)
		{
			_service = service;
		}

		public NotaController()
		{
			NotaService servicio = new NotaService();
			_service = servicio;
		}

		[ExceptionHandler]
		[HttpGet]
		public ResponseServices<List<ConsultarNotasEstudiantes_Result>> ConsultarNotasEstudiantes()
		{
			var response = _service.ConsultarNotasEstudiantes();
			return response;
		}


		[ExceptionHandlerJson]
		public ResponseServices<int> InsertarNota(NotaDto nota)
		{
			var response = _service.InsertarNota(nota);
			return response;
		}

		[ExceptionHandlerJson]
		public ResponseServices<int> EliminarNota(long idNota)
		{
			var response = _service.EliminarNota(idNota);
			return response;
		}

		[ExceptionHandlerJson]
		public ResponseServices<int> ActualizarNota(NotaDto nota)
		{
			var response = _service.ActualizarNota(nota);
			return response;
		}
	}
}