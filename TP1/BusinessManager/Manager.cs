using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.Queries;
using Model;
using Model.classes;

namespace BusinessManager
{
    public class Manager
    {
        private readonly ModelContext context;
        private static Manager _businessManager = null;

        private Manager()
        {
            context = new ModelContext();
        }

        public static Manager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new Manager();
                return _businessManager;
            }
        }

        public List<Eleve> GetAllEleve()
        {
            EleveQuery eq = new EleveQuery(context);
            return eq.GetAll().ToList();
        }
    }
}