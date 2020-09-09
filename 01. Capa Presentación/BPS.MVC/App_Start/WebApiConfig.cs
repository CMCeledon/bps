// ***********************************************************************
// Assembly         : BPS.MVC
// Author           : cmceledon (Carlos Mario Celedón Rodelo)
// Created          : 08-09-2020
//
// Last Modified By : cmceledon (Carlos Mario Celedón Rodelo)
// Last Modified On : 08-09-2020
// ***********************************************************************
// <copyright file="WebApiConfig.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Http;

namespace BPS.MVC
{
	/// <summary>
	/// Class WebApiConfig.
	/// </summary>
	public static class WebApiConfig
	{
		/// <summary>
		/// Registers the specified configuration.
		/// </summary>
		/// <param name="config">The configuration.</param>
		public static void Register(HttpConfiguration config)
		{

			config.Routes.MapHttpRoute(
				name: "ApiWithAction",
				routeTemplate: "api/{controller}/{action}/{id}", defaults: new { id = RouteParameter.Optional });
			// config.Formatters.Remove(config.Formatters.JsonFormatter);
			//config.Routes.MapHttpRoute(
			//    name: "DefaultApi",
			//    routeTemplate: "api/{controller}/{id}",
			//    defaults: new { id = RouteParameter.Optional }
			//);
			config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
			= Newtonsoft.Json.ReferenceLoopHandling.Ignore;


		}
	}
}
