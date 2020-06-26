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
    public class AbsenceViewModel : BaseViewModel
    {
        private int _id;
        private String _motif;
        private DateTime _dateAbsence;

        public AbsenceViewModel(Absence a)
        {
            _id = a.Id;
            _motif = a.Motif;
            _dateAbsence = a.DateAbsence;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Motif
        {
            get { return _motif; }
            set { _motif = value; }
        }
        public DateTime DateAbsence
        {
            get { return _dateAbsence; }
            set { _dateAbsence = value; }
        }
    }
}
