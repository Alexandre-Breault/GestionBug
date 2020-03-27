using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBug.DB.Models
{
    public class Bug
    {
        public int Identifiant { get; set; }
        public string Titre { get; set; }
        public DateTime DateBug { get; set; }
        public bool EstBloquant { get; set; }
        public int IdentifiantSeverite { get; set; }
        public Severite Severite { get; set; }

    }
}
