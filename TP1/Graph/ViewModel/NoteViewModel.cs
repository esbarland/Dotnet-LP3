using Graph.ViewModel.Common;
using Model.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.ViewModel
{
    public class NoteViewModel : BaseViewModel
    {
        private int _id;
        private String _matiere;
        private DateTime _dateNote;
        private String _appreciation;
        private int _valeur;

        public NoteViewModel(Note n)
        {
            _id = n.Id;
            _matiere = n.Matiere;
            _dateNote = n.DateNote;
            _appreciation = n.Appreciation;
            _valeur = n.Valeur;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Matiere
        {
            get { return _matiere; }
            set { _matiere = value; }
        }
        public DateTime DateNote
        {
            get { return _dateNote; }
            set { _dateNote = value; }
        }
        public String Appreciation
        {
            get { return _appreciation; }
            set { _appreciation = value; }
        }
        public int Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }
    }
}
