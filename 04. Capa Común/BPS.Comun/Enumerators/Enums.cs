// ***********************************************************************
// Assembly         :  BPS.Comun.Enums
// Author           : cmceledon (Carlos Mario Celedón Rodelo)
// Created          : 08-09-2020
//
// Last Modified By : cmceledon (Carlos Mario Celedón Rodelo)
// Last Modified On : 08-09-2020
// ***********************************************************************
// <copyright file="Enums.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace BPS.Comun.Enumerators
{
    /// <summary>
    /// Clase Enums
    /// </summary>
    public class Enums
    {
        #region Enumeradores
        public enum Result
        {
            [StringValue("~/Login")]
            UnAuthorized,
            [StringValue("login")]
            LoginPublicacion,
            [StringValue("admin")]
            AdminPublicacion,
            [StringValue("Error")]
            Error,
            [StringValue("swagger")]
            swagger,
            [StringValue("ui/index")]
            swaggerDefault,
            [StringValue("Request")]
            Request,
            [StringValue("ExceptionFechaGuia")]
            ExceptionFechaGuia,
            [StringValue("~/App_Data/")]
            App_Data
        }
     


        //EnumCMCeledon 2

     
        public enum FormatosArchivos
        {
            [StringValue(".csv")]
            CSV,
        }
      
        /// <summary>
        /// Enum FormatoStringFecha
        /// </summary>
        public enum FormatoStringFecha
        {
            /// <summary>
            /// Tipo año mes día
            /// </summary>
            [StringValue("yyyy/MM/dd")]
            AnioMesDiaSeparadorSlaps,
            /// <summary>
            /// The anio mes dia separador guion
            /// </summary>
            [StringValue("yyyy-MM-dd")]
            AnioMesDiaSeparadorGuion
        }
        /// <summary>
        /// Enum Mensajes Respuesta General
        /// </summary>
        public enum MensajeRespuesta
        {
            /// <summary>
            /// 
            /// </summary>
            [StringValue("Correcto")]
            Ok,
            /// <summary>
            /// 
            /// </summary>
            [StringValue("Crear")]
            Crear,
            /// <summary>
            /// 
            /// </summary>
            [StringValue("Error")]
            Error,

            /// <summary>
            /// 
            /// </summary>
            [StringValue("Sin Información")]
            SinDatos,

            /// <summary>
            /// 
            /// </summary>
            [StringValue("Tipo Consulta")]
            Consulta,

            /// <summary>
            /// 
            /// </summary>
            [StringValue("Inserción y Consulta")]
            InsertConsulta,

            /// <summary>
            /// 
            /// </summary>
            [StringValue("Eliminar Registro")]
            Eliminar,
            /// <summary>
            /// 
            /// </summary>
            [StringValue("Inserción")]
            Insert,
            /// <summary>
            /// 
            /// </summary>
            [StringValue("Modificación")]
            Update
        }


        /// <summary>
        /// Enum Status
        /// </summary>
        public enum Status
        {
            /// <summary>
            /// The ok
            /// </summary>
            Ok = 1,
            /// <summary>
            /// The error
            /// </summary>
            Error = 0
        }
        /// <summary>
        /// Enum Status
        /// </summary>
        public enum Estado
        {
            /// <summary>
            /// The ok
            /// </summary>
            [StringValue("True")]
            True,
            /// <summary>
            /// The error
            /// </summary>
            [StringValue("False")]
            False,
            /// <summary>
            /// Concatenados Aprobados
            /// </summary>
            [StringValue("3,10,19")]
            Aprobados,
        }
    
    

        #endregion
    }
}
