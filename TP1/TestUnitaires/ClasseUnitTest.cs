using BusinessManager;
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
        public void OnCreateClasse()
        {
            // ARRANGER / AGIR / AUDITER
            // CREER OBJET, AJOUTER, ASSERT
            Manager manager = BusinessManager.Manager.Instance;

            Classe classe = new Classe { NomEtablissement = "Unit", Niveau = "Test", Eleves = new List<Eleve>() };

            manager.AjouterClasse(classe);
            Assert.AreEqual(manager.GetAllClasse().Last(), classe);
        }

    }
}
