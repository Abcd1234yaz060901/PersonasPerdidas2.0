//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonasPerdidas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FotosPersona
    {
        public int Id_Fotos { get; set; }
        public Nullable<int> id_personaDesaparecida { get; set; }
        public byte[] Fotos { get; set; }
    
        public virtual CrearPersonaPerdida CrearPersonaPerdida { get; set; }
    }
}