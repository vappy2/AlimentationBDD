using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesperLibrary
{
   public class Service
    {
        //donées membres
        private decimal budget;
        private int capacite;
        private int dernierId;
        private string designation;
        private int id;
        private string produit;
        private string type;
        private List<Employe> lesEmployeduService;

        //propriétés
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public int Capacite
        {
            get { return capacite; }
            set { capacite = value; }
        }

        public int DernierId
        {
            get { return dernierId; }
            set { dernierId = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Produit
        {
            get { return produit; }
            set { produit = value; }
        }

        //Méthodes
        public Service(int id,string designation, string type, string produit, int capacite)
        {            
            this.capacite = capacite;            
            this.designation = designation;
            this.id = id;
            this.produit = produit;
            this.type = type;
        }

        public Service(int id, string designation, string type, decimal budget) 
        {
            this.id = id;
            this.designation = designation;
            this.type = type;
            this.budget = budget;
        }

        public override string ToString()
        {
            string chaine = String.Format("service {0} n°{1} de type ", this.designation, this.id);
            if (type == "P")
            {
                chaine += String.Format("production de {0} pour une capacité de {1}", this.produit, this.capacite);
            }
            if (type == "A")
            {
                chaine += String.Format("comptabilité pour un budget de {0}", this.budget);
            }
            return chaine;
        }


    }
}
