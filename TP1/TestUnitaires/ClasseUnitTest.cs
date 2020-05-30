using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaires
{
    [TestClass]
    public class ClasseUnitTest
    {

        [TestMethod]
        public void OnCreateEleve()
        {
            // ARRANGER / AGIR / AUDITER
            // CREER OBJET, AJOUTER, ASSERT

            ModelContext context = new ModelContext();
            List<Eleve> listeEleves = new List<Eleve>();
            Classe classe = new Classe { NomEtablissement = "MCW", Niveau = "4eme", Eleves = listeEleves };

            Eleve eleve1 = new Eleve
            {
                Nom = "Paul",
                Prenom = "Pierre",
                Classe = classe,
                DateDeNaissance = new DateTime(),
                Absences = new List<Absence>(),
                Notes = new List<Note>(),
            };

            context.Classes.Add(classe);
            context.Eleves.Add(eleve1);
            context.SaveChanges();
            Assert.AreEqual(context.Eleves.First(), eleve1);
        }

    }
}
