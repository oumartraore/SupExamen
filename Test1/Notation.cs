//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notation
    {
        public int Id { get; set; }
        public string certification { get; set; }
        public string validation { get; set; }
        public string matiere { get; set; }
        public int TeacherId { get; set; }
    
        public virtual Teacher Teachers { get; set; }
    }
}