
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
            List<Eleve> listEleves = manager.GetAllEleve();

            foreach(Eleve e in listEleves)
            {
                Console.WriteLine("Elève:");
                Console.WriteLine(e.Nom);
                Console.WriteLine(e.Prenom);
                Console.WriteLine(e.Id);
            }
            Thread.Sleep(10000);
        }
    }
}
