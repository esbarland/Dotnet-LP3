using Graph.ViewModel.Common;
using Model.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Graph.ViewModel
{
    public class EleveDetailViewModel : BaseViewModel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private DateTime _dateDeNaissance;
        private double _moyenne;
        private int _nombreAbsences;
        private ObservableCollection<NoteViewModel> _notes;
        private ObservableCollection<AbsenceViewModel> _absences;
        private RelayCommand _saveOperation;

        public EleveDetailViewModel(Eleve e)
        {
            _id = e.Id;
            _nom = e.Nom;
            _prenom = e.Prenom;
            _dateDeNaissance = e.DateDeNaissance;
            _absences = new ObservableCollection<AbsenceViewModel>();
            _notes = new ObservableCollection<NoteViewModel>();

            double sumNotes = 0;
            foreach (Note n in e.Notes)
            {
                sumNotes = sumNotes + n.Valeur;
                _notes.Add(new NoteViewModel(n));
            }
            if(sumNotes != 0)
            {
                _moyenne = sumNotes / e.Notes.Count();
            }

            foreach (Absence a in e.Absences)
            {
                _absences.Add(new AbsenceViewModel(a));
            }
            _nombreAbsences = e.Absences.Count();
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
        public double Moyenne
        {
            get { return _moyenne; }
            set { _moyenne = value; }
        }
        public int NombreAbsences
        {
            get { return _nombreAbsences; }
            set { _nombreAbsences = value; }
        }

        public ObservableCollection<NoteViewModel> Notes
        {
            get { return _notes;  }
            set { 
                _notes = value;
                OnPropertyChanged("Notes");
            }
        }

        public ObservableCollection<AbsenceViewModel> Absences
        {
            get { return _absences; }
            set
            {
                _absences = value;
                OnPropertyChanged("Absences");
            }
        }

        public ICommand SaveOperation
        {
            get
            {
                if (_saveOperation == null)
                    _saveOperation = new RelayCommand(() => this.SaveAction());
                return _saveOperation;
            }
        }

        private void SaveAction()
        {
            List<Note> listNotes = new List<Note>();

            foreach(NoteViewModel n in this.Notes)
            {
                Note tmp = new Note() { 
                    Id = n.Id,
                    Matiere = n.Matiere,
                    Valeur = n.Valeur,
                    Appreciation = n.Appreciation, 
                    DateNote = n.DateNote, 
                    EleveId = this.Id
                };
                listNotes.Add(tmp);
            }

            Eleve e = new Eleve() { 
                Id = this.Id, 
                Nom = this.Nom, 
                Prenom = this.Prenom,
                DateDeNaissance = this.DateDeNaissance,
                Notes = listNotes

            };
            BusinessManager.Manager.Instance.ModifierEleve(e);
        }

    }
}
