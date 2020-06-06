
using BusinessManager;
using Model.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace TP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = Manager.Instance;

            /*Classe c = new Classe() {Niveau = "6ème", NomEtablissement = "MCW" };
            manager.AjouterClasse(c);

            Note n1 = new Note() { Matiere = "Sport", Valeur = 10 };
            List<Note> notes = new List<Note>();
            notes.Add(n1);
            manager.AjouterEleve(new Eleve() { Nom = "Stanley", Prenom = "Kubrick", Classe = c, DateDeNaissance = new DateTime(), Notes = notes });*/

            List<Eleve> listEleves = manager.GetAllEleve();
            foreach (Eleve e in listEleves)
            {
                Console.WriteLine("Elève:");
                Console.WriteLine("{0} {1} {2}", e.Id, e.Nom, e.Prenom);
               

                if (e.Notes == null)
                {
                    Console.WriteLine("pas de notes");
                    continue;
                }
                foreach(Note n in e.Notes)
                {
                    Console.WriteLine("Note:");
                    Console.WriteLine("{0} {1}", n.Matiere, n.Valeur);
                }
            }
            Console.WriteLine("--------------------------");
            foreach(Note n in manager.GetAllNote())
            {
                Console.WriteLine("Note from db:");
                Console.WriteLine("{0} {1}", n.Matiere, n.Valeur);
            }
            Thread.Sleep(10000);
        }
    }
}
