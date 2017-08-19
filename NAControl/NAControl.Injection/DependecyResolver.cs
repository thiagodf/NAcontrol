using Microsoft.Practices.Unity;
using NAControl.Business.Services;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using NAControl.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAControl.Injection
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

            container.RegisterType<User, User>(new HierarchicalLifetimeManager());

            container.RegisterType<IGroupRepository, GroupRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGroupService, GroupService>(new HierarchicalLifetimeManager());

            container.RegisterType<Group, Group>(new HierarchicalLifetimeManager());
        }
    }
}
