using AutoMapper;
using BPS.Aplicacion.Abstract;
using BPS.Aplicacion.Helpers;
using BPS.Comun.Dto;
using BPS.Comun.Enumerators;
using BPS.Modelo.EntityModel;
using System.Collections.Generic;
using System.Linq;

namespace BPS.Aplicacion.Implements
{
	public class NotaService : INotaService
	{
		private BPSEntities _ctxModel = new BPSEntities();
		private readonly IMapper _mapper;

		public NotaService(IMapper mapper)
		{
			_mapper = mapper;
		}
		public NotaService()
		{

		}
		public ResponseServices<List<ConsultarNotasEstudiantes_Result>> ConsultarNotasEstudiantes()
		{
			var response = new ResponseServices<List<ConsultarNotasEstudiantes_Result>>();
			response.Type = Enums.MensajeRespuesta.Consulta.ToStringAttribute();

			var resultList = _ctxModel.ConsultarNotasEstudiantes().ToList();

			if (resultList.Any())
			{
				response.Info = resultList;
				response.Message = Enums.MensajeRespuesta.Ok.ToStringAttribute();
				response.State = true;
				return response;
			}
			response.Info = resultList;
			response.Message = Enums.MensajeRespuesta.Error.ToStringAttribute();
			response.State = false;
			return response;
		}


		public ResponseServices<int> EliminarNota(long idNota)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Eliminar.ToStringAttribute();
			var result = _ctxModel.Nota.Find(idNota);

			if (result != null)
			{
				_ctxModel.Nota.Remove(result);
				var eliminado = _ctxModel.SaveChanges();

				response.Info = eliminado;
				response.Message = Enums.MensajeRespuesta.Ok.ToStringAttribute();
				response.State = true;
				return response;
			}
			response.Info = (int)Enums.Status.Error;
			response.Message = Enums.MensajeRespuesta.Error.ToStringAttribute();
			response.State = false;
			return response;
		}

		public ResponseServices<int> InsertarNota(NotaDto nota)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Insert.ToStringAttribute();
			_ctxModel.InsertarNotaEstudiante(null,nota.IdProfesor,nota.IdEstudiante,nota.Nombre,nota.Valor);
			var result = _ctxModel.SaveChanges();
			if (result > (int)Enums.Status.Error)
			{
				response.Info = result;
				response.Message = Enums.MensajeRespuesta.Ok.ToStringAttribute();
				response.State = true;
				return response;
			}
			response.Message = Enums.MensajeRespuesta.Error.ToStringAttribute();
			response.State = false;
			return response;
		}
		public ResponseServices<int> ActualizarNota(NotaDto nota)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Update.ToStringAttribute();
			var mapEntidad = AutoMapperConfig.GetMapper<Nota, NotaDto>().Map<Nota>(nota);

			var result = _ctxModel.Nota.Find(mapEntidad.idNota);

			if (result != null)
			{
				result.nombre = nota.Nombre;
				result.valor = nota.Valor;
				var modificado = _ctxModel.SaveChanges();

				response.Info = modificado;
				response.Message = Enums.MensajeRespuesta.Ok.ToStringAttribute();
				response.State = true;
				return response;
			}
			response.Message = Enums.MensajeRespuesta.Error.ToStringAttribute();
			response.State = false;
			return response;
		}
	}
}
