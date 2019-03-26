using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GesperLibrary;

namespace ChargementGesper
{
    class Program
    {
        static void Main(string[] args)
        {
           int choix;
            /* instancier une connexion */
            string host;
            string user;
            string bdd;
            string pwd;
            

            host = "localhost";
            bdd = "gesper";
            user = "root";
            pwd = "siojjr";

            Connexion cnx = new Connexion(user,pwd, host, bdd);
            MySqlConnection Cnx;
            cnx.Ouvrir();
            Cnx = cnx.getcnx;
            
                                            
                                    
            /* instancier un objet de la classe Donnees */
            Données lesDonnees = new Données();
            do
            {
                do
                {

                    Console.WriteLine("1 - charger les services");
                    Console.WriteLine("2 - ajouter un service");
                    Console.WriteLine("3 - sauvegarder les services");         
                    Console.WriteLine("4 - fin du traitement");
                    Console.WriteLine();


                    choix = Int32.Parse(Console.ReadLine());

                } while (choix < 0 || choix > 5);

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("1 - charger les services");
                             /* charger les services */
                        lesDonnees.ChargerService(Cnx);
                             /* afficher le contenu de l'objet lesDonnees */
                            lesDonnees.AfficherServices();
                            Console.ReadLine();
            
                        break;
                        case 2:
                        Console.WriteLine("1 - ajouter un service");
                             /* appel de la procédure  ajout_service */
                        Service RH = new Service(7, "Ressources Humaines", "A", 1000);
                           lesDonnees.AjouterService(RH);
                             /* afficher le contenu de l'objet lesDonnees */
                     //       lesDonnees.AfficherServices();
                        break;
                    case 3:
                        Console.WriteLine("1 - sauvegarder les services");
                             /* appel de la procédure  ajout_service */
              //              lesDonnees.sauvegarderServices(Cnx);
                             /* afficher le contenu de l'objet lesDonnees */
                            lesDonnees.AfficherServices();
                        break;
                }
            }while(choix != 4);

            /* fermer la connexion */
            cnx.DeConnexion();
            Console.ReadLine();
            
        }
    }

            
    
}
