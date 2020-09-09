using Newtonsoft.Json;
using NLog;
using System;
using System.Web.Mvc;
using BPS.Aplicacion.Abstract;
using BPS.Aplicacion.Implements;
using BPS.Comun.Dto;
using BPS.Comun.Enumerators;

namespace BPS.MVC
{
    public class ExceptionHandlerAttribute : FilterAttribute, IExceptionFilter
    {

        /// <summary>
		/// The logger
		/// </summary>
		private static Logger logger = LogManager.GetCurrentClassLogger();

        public void OnException(ExceptionContext filterContext)
        {
            ExceptionControlDto exceptionControl = new ExceptionControlDto()
            {
                ExceptionMessage = filterContext.Exception.Message,
                ExceptionStackTrack = filterContext.Exception.StackTrace,
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ExceptionLogTime = DateTime.Now
            };

            var jsonResultResiduosRecibidos = JsonConvert.SerializeObject(exceptionControl);
            logger.Error(jsonResultResiduosRecibidos);

            filterContext.ExceptionHandled = true;
            var result = new ViewResult
            {
                ViewName = Enums.Result.Error.ToStringAttribute(),
                TempData = filterContext.Controller.TempData,
            };
            filterContext.Result = result;
            result.TempData[Enums.Result.ExceptionFechaGuia.ToStringAttribute()] = exceptionControl.ExceptionLogTime;
        }
    }
    public class ExceptionHandlerJsonAttribute : HandleErrorAttribute
    {
        /// <summary>
		/// The logger
		/// </summary>
		private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        ///   Método  para manejar excepciones
        /// </summary>
        /// <param name="filterContext"> </param>
        public override void OnException(ExceptionContext filterContext)
        {
            // Si se maneja la excepción, regrese (no haga nada)
            if (filterContext.ExceptionHandled)
                return;

            // Se establece ExceptionHandled en verdadero 
            filterContext.ExceptionHandled = true;

            //TODO: Registrar una excepción a la base de datos o al archivo de registro
            ExceptionControlDto exceptionControl = new ExceptionControlDto()
            {
                ExceptionMessage = filterContext.Exception.Message,
                ExceptionStackTrack = filterContext.Exception.StackTrace,
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ExceptionLogTime = DateTime.Now
            };

            var jsonResultResiduosRecibidos = JsonConvert.SerializeObject(exceptionControl);
            logger.Error(jsonResultResiduosRecibidos);


            //Estructura de resultados
            filterContext.Result = new JsonResult
            {
                Data = new { State = false, Message = filterContext.Exception.Message, Info = new { } },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

        }
    }
}