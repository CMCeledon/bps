
// ***********************************************************************
// Assembly         : BPS.Modelo.Entities
// Author           : www.cmceledon.com (Carlos Mario Celedón Rodelo)
// Created          : 2020-02-18 16:38:36.163
//
// Last Modified By : www.cmceledon.com (Carlos Mario Celedón Rodelo)
// Last Modified On : 2020-02-18 16:38:36.163
// ***********************************************************************
// <copyright file="ExceptionControl.cs" company="Tecniamsa">
//     Copyright © 2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace BPS.Comun.Dto
{
    /// <summary>
    /// Clase: ExceptionControl. (Entidad de Dominio)
    /// </summary>
    public class EstudianteDto
    {
        /// <summary>
        /// Atributo:  IdEstudiante, de la entidad Estudiante.
        /// </summary>
        public long IdEstudiante { get; set; }

        /// <summary>
        /// Atributo:  Nombre, de la entidad Estudiante.
        /// </summary>
        public string Nombre { get; set; }

    }
}