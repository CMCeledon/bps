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
	public class EstudianteService : IEstudianteService
	{
		private BPSEntities _ctxModel = new BPSEntities();
		private readonly IMapper _mapper;

		public EstudianteService(IMapper mapper)
		{
			_mapper = mapper;
		}
		public EstudianteService()
		{

		}
		public ResponseServices<List<Estudiante>> ConsultarEstudiantes()
		{
			var response = new ResponseServices<List<Estudiante>>();
			response.Type = Enums.MensajeRespuesta.Consulta.ToStringAttribute();
			var resultList = _ctxModel.Estudiante.ToList();
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

		public ResponseServices<Estudiante> ConsultarEstudianteId(long idEstudiante)
		{
			var response = new ResponseServices<Estudiante>();
			response.Type = Enums.MensajeRespuesta.Consulta.ToStringAttribute();
			var result = _ctxModel.Estudiante.Find(idEstudiante);

			if (result != null)
			{
				response.Info = result;
				response.Message = Enums.MensajeRespuesta.Ok.ToStringAttribute();
				response.State = true;
				return response;
			}
			response.Info = result;
			response.Message = Enums.MensajeRespuesta.Error.ToStringAttribute();
			response.State = false;
			return response;
		}

		public ResponseServices<int> EliminarEstudiante(long idEstudiante)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Eliminar.ToStringAttribute();
			var result = _ctxModel.Estudiante.Find(idEstudiante);

			if (result != null)
			{
				_ctxModel.Estudiante.Remove(result);
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

		public ResponseServices<int> InsertarEstudiante(EstudianteDto estudiante)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Insert.ToStringAttribute();
			var mapEntidad = AutoMapperConfig.GetMapper<Estudiante, EstudianteDto>().Map<Estudiante>(estudiante);
			_ctxModel.Estudiante.Add(mapEntidad);
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
		public ResponseServices<int> ActualizarEstudiante(EstudianteDto estudiante)
		{
			var response = new ResponseServices<int>();
			response.Type = Enums.MensajeRespuesta.Update.ToStringAttribute();
			var mapEntidad = AutoMapperConfig.GetMapper<Estudiante, EstudianteDto>().Map<Estudiante>(estudiante);

			var result = _ctxModel.Estudiante.Find(mapEntidad.idEstudiante);

			if (result != null)
			{
				result.nombre = estudiante.Nombre;
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
