using Model;
using Model.classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ModelContext context = new ModelContext();

                List<Eleve> listeEleves = new List<Eleve>();

                Classe classe = new Classe { NomEtablissement = "MCW", Niveau = "4eme", Eleves = listeEleves };

                Eleve eleve1 = new Eleve { 
                    Nom = "Paul", 
                    Prenom = "Pierre", 
                    Classe = classe, 
                    DateDeNaissance = new DateTime(), 
                    Absences = new List<Absence>(),
                    Notes = new List<Note>(),
                };

                
                listeEleves.Add(eleve1);


                context.Classes.Add(classe);
                context.Eleves.Add(eleve1);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
