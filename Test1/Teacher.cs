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
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Notations = new HashSet<Notation>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string firstname { get; set; }
        public string campus { get; set; }
        public string email { get; set; }
        public string campus_would_teach { get; set; }
        public string campus_already_teach { get; set; }
        public string courses_already_teach { get; set; }
        public string courses_would_teach { get; set; }
        public string current_promotion { get; set; }
        public string comments { get; set; }
    
        public virtual ICollection<Notation> Notations { get; set; }
    }
}
