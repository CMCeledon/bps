﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPS.Modelo.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BPSEntities : DbContext
    {
        public BPSEntities()
            : base("name=BPSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
    
        public virtual ObjectResult<ConsultarNotasEstudiantes_Result> ConsultarNotasEstudiantes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarNotasEstudiantes_Result>("ConsultarNotasEstudiantes");
        }
    
        public virtual int InsertarNotaEstudiante(Nullable<long> idNota, Nullable<long> idProfesor, Nullable<long> idEstudiante, string nombre, Nullable<decimal> valor)
        {
            var idNotaParameter = idNota.HasValue ?
                new ObjectParameter("idNota", idNota) :
                new ObjectParameter("idNota", typeof(long));
    
            var idProfesorParameter = idProfesor.HasValue ?
                new ObjectParameter("idProfesor", idProfesor) :
                new ObjectParameter("idProfesor", typeof(long));
    
            var idEstudianteParameter = idEstudiante.HasValue ?
                new ObjectParameter("idEstudiante", idEstudiante) :
                new ObjectParameter("idEstudiante", typeof(long));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarNotaEstudiante", idNotaParameter, idProfesorParameter, idEstudianteParameter, nombreParameter, valorParameter);
        }
    }
}