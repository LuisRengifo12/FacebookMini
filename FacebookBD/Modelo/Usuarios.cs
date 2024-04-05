//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacebookBD.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Comentarios = new HashSet<Comentarios>();
            this.Publicaciones = new HashSet<Publicaciones>();
        }
    
        public int IdUsuario { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public string nombreCompleto { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public byte[] fotoPerfil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
