using AutoMapper;
using System.Web.Mvc;
using BPS.Aplicacion.Abstract;
using BPS.Aplicacion.Helpers;
using BPS.Aplicacion.Implements;
using BPS.Comun.Dto;
using BPS.Comun.Helpers;
using Unity;
using Unity.Mvc5;

namespace BPS.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            // Configuracion regional
            // Creado Por:   Carlos Mario Celedón Rodelo
            var container = new UnityContainer();

           
            //Configuracion de autommaper
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfiles());
            });

            var mapper = mappingConfig.CreateMapper();
            container.RegisterInstance(mapper);

            //<summary>
            //configuracion Inyeccion de dependencias en controladores, desde la Capa de Aplicación.
            //</summary>
            container.RegisterType<IEstudianteService, EstudianteService>();
            container.RegisterType<IProfesorService, ProfesorService>();
            container.RegisterType<INotaService, NotaService>();
            //<summary>
            //Configuración Inyeccion de dependencias en services, desde la Capa de Dominio (Modelo).
            //</summary>
            //container.RegisterType<IReportesRepository, ReportesRepository>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}