using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesperLibrary
{
    public class Diplome
    {
        //Donées membres
        private int id;
        private string libelle;
        List<Employe> lesEmployes;

        //propriétés
        public List<Employe> LesEmploye
        {
            get { return lesEmployes; }
            set { lesEmployes = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        //méthodes
        public Diplome(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public override string ToString()
        {
            return String.Format("id : {0}, Libellé : {1}", this.id, this.libelle);
        }
    }
}
