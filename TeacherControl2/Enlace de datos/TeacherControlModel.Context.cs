﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegEstudiantes.Enlace_de_datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeacherControlDbEntities : DbContext
    {
        public TeacherControlDbEntities()
            : base("name=TeacherControlDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Asistencia> Asistencias { get; set; }
        public virtual DbSet<AsistenciasDetalle> AsistenciasDetalles { get; set; }
        public virtual DbSet<Calificacion> Calificacions { get; set; }
        public virtual DbSet<CalificacionesDetalle> CalificacionesDetalles { get; set; }
        public virtual DbSet<Deuda> Deudas { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Evaluacione> Evaluaciones { get; set; }
        public virtual DbSet<EvaluacionesDetalle> EvaluacionesDetalles { get; set; }
        public virtual DbSet<Inscripcione> Inscripciones { get; set; }
        public virtual DbSet<InscripcionesDetalle> InscripcionesDetalles { get; set; }
        public virtual DbSet<PagosDeuda> PagosDeudas { get; set; }
        public virtual DbSet<Profesore> Profesores { get; set; }
        public virtual DbSet<Seccione> Secciones { get; set; }
        public virtual DbSet<Semestre> Semestres { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<TareasDetalle> TareasDetalles { get; set; }
    }
}
