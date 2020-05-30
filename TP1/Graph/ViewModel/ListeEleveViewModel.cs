using Graph.ViewModel.Common;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.ViewModel
{
    public class ListeEleveViewModel : BaseViewModel
    {
        private ObservableCollection<EleveDetailViewModel> _eleves = null;
        private EleveDetailViewModel _selectedEleve;

        public ListeEleveViewModel()
        {
            _eleves = new ObservableCollection<EleveDetailViewModel>();
            foreach (Eleve e in BusinessManager.Manager.Instance.GetAllEleve())
            {
                _eleves.Add(new EleveDetailViewModel(e));
            }

            if (_eleves != null && _eleves.Count > 0)
                _selectedEleve = _eleves.ElementAt(0);
        }

        public ObservableCollection<EleveDetailViewModel> Eleves
        {
            get { return _eleves; }
            set
            {
                _eleves = value;
                OnPropertyChanged("Eleves");
            }
        }

        public EleveDetailViewModel SelectedEleve
        {
            get { return _selectedEleve; }
            set
            {
                _selectedEleve = value;
                OnPropertyChanged("SelectedEleve");
            }
        }

    }
}
