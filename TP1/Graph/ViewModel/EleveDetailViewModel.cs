using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.ViewModel
{
    public class EleveDetailViewModel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private DateTime _dateDeNaissance;

        public EleveDetailViewModel(Eleve e)
        {
            _id = e.Id;
            _nom = e.Nom;
            _prenom = e.Prenom;
            _dateDeNaissance = e.DateDeNaissance;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }

    }
}
