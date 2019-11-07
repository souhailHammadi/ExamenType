using Domaine;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using MyFinance.Data.Infrastructure;

namespace Services
{
    public class ServiceCandidat : Service<Candidat>,IServiceCandidat
    {
        private static IDatabaseFactory dbfactor = new DatabaseFactory();
        private static IUnitOfWork wow = new UnitOfWork(dbfactor);
        IDatabaseFactory dbfactory = null;
        public ServiceCandidat():base(wow)
        {

        }
    }
}
