using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace GesperLibrary
{
     public class Données
    {
        //données membres
        private List<Service> lesServices;
        private List<Employe> lesEmployes;
        private List<Diplome> lesDiplomes;
        

        //propriétés
        public List<Diplome> LesDiplomes
        {
            get { return lesDiplomes; }
            set { lesDiplomes = value; }
        }

        public List<Service> LesServices
        {
            get { return lesServices; }
            set { lesServices = value; }
        }

        public List<Employe> LesEmployes
        {
            get { return lesEmployes; }
            set { lesEmployes = value; }
        }

        //méthodes
        public List<Diplome> AfficherDiplomes()
        {
            List<Diplome> ListDiplome = new List<Diplome>();
            foreach (Diplome d in lesDiplomes) 
            {
                ListDiplome.Add(d);
            }
            return ListDiplome;
        }

        public List<Employe> AfficherEmployes()
        {
            List<Employe> ListEmploye = new List<Employe>();
            foreach (Employe e in lesEmployes) 
            {
                ListEmploye.Add(e);
            }
            return ListEmploye;
        }

        public void AfficherServices()
        {
            List<Service> ListServices = new List<Service>();
            foreach (Service s in lesServices) 
            {
                ListServices.Add(e);
            }
             return ListServices;   
        }

        public void Charger() { }

        public void ChargerDiplomes(MySqlConnection Cnx)
        {
           Cnx.Open();
            MySqlCommand cmd = new MySqlCommand();
            string resultat = "";
            cmd.Connection = Cnx;
            cmd.CommandText = "diplome";
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            while (Rdr.Read())
            {
                resultat += string.Format("{0}, {1}\n", Rdr[0], Rdr[1]);
            }
           Cnx.Close();
        }

        public void ChargerEmployes(MySqlConnection Cnx) 
        {
            Cnx.Open();
            MySqlCommand cmd = new MySqlCommand();         
            cmd.Connection = Cnx;
            cmd.CommandText = "employe";
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            while (Rdr.Read())
            {
              Employe unEmploye = new Employe(Int32.Parse(Rdr.GetString(0)), Rdr.GetString(1), Rdr.GetString(2), Rdr.GetString(3), Decimal.Parse(Rdr.GetString(4)), Byte.Parse(Rdr.GetString(5)), null);
              lesEmployes.Add(unEmploye);  
            }
            Cnx.Close();
        }
           
          public void ChargerService(MySqlConnection Cnx) 
          {
             
              MySqlCommand cmd = new MySqlCommand();              
              cmd.Connection = Cnx;
              cmd.CommandText = "service";
              cmd.CommandType = CommandType.TableDirect;
              MySqlDataReader Rdr;
              Rdr = cmd.ExecuteReader();
              while (Rdr.Read())
              {
                  if (Rdr.GetString(2) == "P") 
                  {
                      Service unService = new Service(Int32.Parse(Rdr.GetString(0)), Rdr.GetString(1), Rdr.GetString(2), Rdr.GetString(3), Int32.Parse(Rdr.GetString(4)));
                      lesServices.Add(unService);
                  }
                  else if (Rdr.GetString(2) == "A") 
                  {
                      Service unService = new Service(Int32.Parse(Rdr.GetString(0)), Rdr.GetString(1), Rdr.GetString(2), Decimal.Parse(Rdr.GetString(5)));
                      lesServices.Add(unService);
                  }                  
              }
              
          }

        public void ChargerLesDiplomesDesEmployes(MySqlConnection Cnx) { }

        public void ChargerLesEmployésDesServices(MySqlConnection Cnx) { }

        public void ChargerLesEmployésTitulaireDesDiplomes(MySqlConnection Cnx) { }

        public void AjouterService(Service unService) 
        {
            lesServices.Add(unService);
        }

        public Données(){
            //this.lesServices = new List<Service>();
           // this.lesEmployes = new List<Employe>();
           // this.lesDiplomes = new List<Diplome>();
        }
    }
}
