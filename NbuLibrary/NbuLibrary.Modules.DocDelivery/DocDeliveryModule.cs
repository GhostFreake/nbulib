using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NbuLibrary.Core.ModuleEngine;
using NbuLibrary.Core.Services;
using NbuLibrary.Core.Services.tmp;
using Ninject.Modules;
using NbuLibrary.Core.Domain;
using System.Security.Cryptography;
using NbuLibrary.Core.Service.tmp;
using NbuLibrary.Core.DataModel;

namespace NbuLibrary.Modules.DocDelivery
{
    public class Permissions
    {
        public const string Use = "Use";
    }

    public class DocDeliveryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IModule>().To<DocDeliveryModule>();
            Bind<IEntityOperationInspector>().To<EntityOperationInspector>();
            Bind<IEntityQueryInspector>().To<EntityQueryInspector>();
            Bind<IEntityOperationLogic>().To<AskTheLibOperationLogic>();
        }
    }
    public class DocDeliveryModule : IModule
    {
    }

    public class DocDeliveryUIProvider : IUIProvider
    {

    }

    public class EntityOperationInspector : IEntityOperationInspector
    {

    }

    public class AskTheLibOperationLogic : IEntityOperationLogic
    {
    }
}
