// ***********************************************************************
// Assembly         : BPS.Comun
// Author           : Carlos Mario Celedón
// Created          : 11-11-2019
//
// Last Modified By : Carlos Mario Celedón
// Last Modified On : 11-11-2019
// ***********************************************************************
// <copyright file="AgenteEstampillaResponseDto.cs" company="AppComun">
//     Copyright (c) Independiente. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace BPS.Comun.Dto
{
    /// <summary>
    /// Class CertificadosRegenerarDto.
    /// </summary>
    public class CertificadosRegenerarDto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value>IdCertificadoAnulado.</value>
        public long IdCertificadoAnulado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>IdCertificadoAnulado.</value>
        public string CadenaItemsCertificar { get; set; }
    }
}