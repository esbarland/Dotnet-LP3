using Graph.ViewModel.Common;
using Model.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.ViewModel
{
    public class EleveDetailViewModel : BaseViewModel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private DateTime _dateDeNaissance;
        private ObservableCollection<NoteViewModel> _notes;

        public EleveDetailViewModel(Eleve e)
        {
            _id = e.Id;
            _nom = e.Nom;
            _prenom = e.Prenom;
            _dateDeNaissance = e.DateDeNaissance;
            if(e.Notes != null)
            {
                Console.WriteLine("Il y a des notes");
                _notes = new ObservableCollection<NoteViewModel>();
                foreach (Note n in e.Notes)
                {
                    _notes.Add(new NoteViewModel(n));
                }
            }
            else
            {
                Console.WriteLine("Il y a PAS des notes");
                _notes = new ObservableCollection<NoteViewModel>();
            }
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

        public ObservableCollection<NoteViewModel> Notes
        {
            get { return _notes;  }
            set { 
                _notes = value;
                OnPropertyChanged("Notes");
            }
        }

    }
}
