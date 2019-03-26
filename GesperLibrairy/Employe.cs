using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesperLibrary
{
    public class Employe
    {
        //données membres
        private byte cadre;
        private int id;
        private string nom;
        private string prenom;
        private decimal salaire;
        private string sexe;
        private List<Diplome> lesDiplomes;
        private Service leService;

        //propriétés
        public Service LeService
        {
            get { return leService; }
            set { leService = value; }
        }

        public byte Cadre
        {
            get { return cadre; }
            set { cadre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public decimal Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public List<Diplome> LesDiplomes
        {
            get { return lesDiplomes; }
            set { lesDiplomes = value; }
        }

        //methodes
        public Employe(int id, string nom, string prenom, string sexe, decimal salaire, byte cadre, Service leService)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.salaire = salaire;
            this.cadre = cadre;
            this.leService = leService;
        }

        public override string ToString()
        {
            return String.Format("Id : {0}, Nom : {1}, Prénom : {2}, Sexe : {3}, Salaire : {4}, Cadre : {5}, Service : {6}", this.id, this.nom, this.prenom, this.sexe, this.salaire, this.cadre, this.leService);
        }
    }
}
