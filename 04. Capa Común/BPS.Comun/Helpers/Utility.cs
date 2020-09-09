// ***********************************************************************
// Assembly         : BPS.MVC
// Author           : cmceledon (Carlos Mario Celedón Rodelo)
// Created          : 08-09-2020
//
// Last Modified By : cmceledon (Carlos Mario Celedón Rodelo)
// Last Modified On : 08-15-2019
// ***********************************************************************
// <copyright file="Utility.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;
using System.Web;
namespace BPS.Comun.Helpers.Utility
{
	/// <summary>
	/// Class Utility.
	/// </summary>
	/// 
	[ExcludeFromCodeCoverage]
	public class Utility
	{
		/// <summary>
		/// Gets the length of the password.
		/// </summary>
		/// <value>The length of the password.</value>
		public static int PasswordLength { get; private set; }

		/// <summary>
		/// Calculates the m d5 hash.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>System.String.</returns>
		public static string CalculateMD5Hash(string input)
		{
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}

		/// <summary>
		/// Obteners the ip.
		/// </summary>
		/// <param name="Request">The request.</param>
		/// <returns>System.String.</returns>
		public static string ObtenerIP(HttpRequestBase Request)
		{
			return Request.ServerVariables["REMOTE_ADDR"].ToString();
		}

		/// <summary>
		/// Codigoes the aleatorio.
		/// </summary>
		/// <returns>System.String.</returns>
		public static string CodigoAleatorio()
		{
			long chars = 0;
			System.Random rnd = new System.Random();
			for (int i = 0; i < 10; i++)
			{
				chars = rnd.Next(1000, 9999);
			}

			return (chars.ToString());
		}

		/// <summary>
		/// Obteners the server.
		/// </summary>
		/// <returns>System.String.</returns>
		public static string ObtenerServer()
		{


			String strHostName = string.Empty;
			strHostName = System.Net.Dns.GetHostName();
			return strHostName.ToString();

		}

		/// <summary>
		/// Base64s the encode.
		/// </summary>
		/// <param name="plainText">The plain text.</param>
		/// <returns>System.String.</returns>
		public static string Base64Encode(string plainText)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return System.Convert.ToBase64String(plainTextBytes);
		}

		/// <summary>
		/// Strings the mensaje error.
		/// </summary>
		/// <param name="plainText">The plain text.</param>
		/// <param name="width">The width.</param>
		/// <returns>System.String.</returns>
		public static string stringMensajeError(string plainText, string width)
		{
			if (plainText == null)
			{
				plainText = "Error al procesar la información.";
			}
			if (width == null)
			{
				width = "78%";
			}
			var plainTextHTML = "<div class=\"ErrorAvanzadaForm\" style=\"width: 78%\"><b>" + plainText + "</b></div>";
			return plainTextHTML;
		}

		/// <summary>
		/// Strings the mensaje correcto.
		/// </summary>
		/// <param name="plainText">The plain text.</param>
		/// <param name="width">The width.</param>
		/// <returns>System.String.</returns>
		public static string stringMensajeCorrecto(string plainText, string width)
		{
			if (plainText == null)
			{
				plainText = "Información recibida con exito.";
			}
			if (width == null)
			{
				width = "78%";
			}
			var plainTextHTML = "<div class=\"ConfirmacionAvanzadaForm\" style=\"width: " + width + "\"><b>" + plainText + "</b></div>";
			return plainTextHTML;
		}

		/// <summary>
		/// Base64s the decode.
		/// </summary>
		/// <param name="base64EncodedData">The base64 encoded data.</param>
		/// <returns>System.String.</returns>
		public static string Base64Decode(string base64EncodedData)
		{
			try
			{
				var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
				return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
			}
			catch (Exception e)
			{
				return "";
			}

		}




		/// <summary>
		/// Variables the dump.
		/// </summary>
		/// <param name="Request">The request.</param>
		/// <returns>System.String.</returns>
		internal static string var_dump(HttpRequest Request)
		{
			string StringDatos = "<b>Array</b><br />";
			for (int i = 0; i < Request.Form.Count; i++)
			{
				StringDatos += ("'" + Request.Form.GetKey(i) + "' => string  <font color='#cc0000'>'" + Request.Form[i] + "'</font><br />");
			}
			return StringDatos;
		}

		/// <summary>
		/// Base64s the encode.
		/// </summary>
		/// <param name="p">The p.</param>
		/// <returns>System.String.</returns>
		internal static string Base64Encode(int p)
		{
			string s = Base64Decode(p.ToString());
			return s;
			//throw new NotImplementedException();
		}




	}
}