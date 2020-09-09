// ***********************************************************************
// Assembly         : BPS.Modelo.Entities
// Author           : www.cmceledon.com (Carlos Mario Celedón Rodelo)
// Created          : 2020-02-18 08:45:00.473
//
// Last Modified By : www.cmceledon.com (Carlos Mario Celedón Rodelo)
// Last Modified On : 2020-02-18 08:45:00.473
// ***********************************************************************
// <copyright file="TarifaOportunidad.cs" company="Tecniamsa">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************

using AutoMapper;
using BPS.Comun.Dto;
using BPS.Modelo.EntityModel;

namespace BPS.Aplicacion.Helpers
{
    /// <summary>
    /// Class MappingProfiles.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class MappingProfiles : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfiles"/> class.
        /// </summary>
        public MappingProfiles()
        {
            CreateMap<Estudiante, EstudianteDto>().ReverseMap();
            CreateMap<Profesor, ProfesorDto>().ReverseMap();
            CreateMap<ConsultarNotasEstudiantes_Result, NotasEstudiantesDto>().ReverseMap();
        }
    }
}