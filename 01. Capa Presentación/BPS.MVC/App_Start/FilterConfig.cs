// ***********************************************************************
// Assembly         : BPS.MVC
// Author           : cmceledon (Carlos Mario Celedón Rodelo)
// Created          : 08-09-2020
//
// Last Modified By : cmceledon (Carlos Mario Celedón Rodelo)
// Last Modified On : 08-09-2020
// ***********************************************************************
// <copyright file="FilterConfig.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Web.Mvc; 

namespace BPS.MVC
{
	/// <summary>
	/// Class FilterConfig.
	/// </summary>
	public class FilterConfig
	{
		/// <summary>
		/// Registers the global filters.
		/// </summary>
		/// <param name="filters">The filters.</param>
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}