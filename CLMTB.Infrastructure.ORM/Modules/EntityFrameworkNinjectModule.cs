using CLMTB.Domain.Contracts;
using CLMTB.Infrastructure.DAO.Common.Uow;
using CLMTB.Infrastructure.ORM.Common;
using CLMTB.Infrastructure.ORM.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Modules
{
    public class EntityFrameworkNinjectModule : NinjectModule
    {
        public override void Load()
        {
            var entityFrameworkFactory = new EntityFrameworkFactory();
            var type = entityFrameworkFactory.GetType();

            Bind<IUnitOfWork>().To<EntityFrameworkUnitOfWork>().WithConstructorArgument(type, entityFrameworkFactory);
            Bind<IAthleteRepository>().To<AthleteRepository>().WithConstructorArgument(type, entityFrameworkFactory);
        }
    }
}