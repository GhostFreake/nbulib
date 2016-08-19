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
            Bind<IEntityOperationLogic>().To<DocDeliveryOperationLogic>();
        }
    }
    public class DocDeliveryModule : IModule
    {
        private IUIProvider _uiProvider;
        const int Id = 350;

        DocDeliveryModule()
        {

        }

        int IModule.Id
        {
            get { return Id; }
        }

        public decimal Version
        {
            get { return 1.0M; }
        }

        public string Name
        {
            get { return "Document Delivery"; }
        }

        public IUIProvider UIProvider
        {
            get
            {
                if (_uiProvider == null)
                    _uiProvider = new DocDeliveryUIProvider();

                return _uiProvider;
            }
        }


        public ModuleRequirements Requirements
        {
            get { throw new NotImplementedException(); }
        }

        public void Initialize()
        {

        }
    }

    public class DocDeliveryUIProvider : IUIProvider
    {

        public string GetClientTemplates(UserTypes type)
        {
            //if (type == UserTypes.Admin)
            //    return GetContent("Templates.AdminUI.html");
            return string.Empty;
        }

        private string GetContent(string resourceFileName)
        {
            string resourceContent = null;
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("NbuLibrary.Modules.DocDelivery.{0}", resourceFileName)))
            {
                using (var reader = new StreamReader(stream))
                {
                    resourceContent = reader.ReadToEnd();
                }
            }

            return resourceContent;
        }


        IEnumerable<ClientScript> IUIProvider.GetClientScripts(UserTypes type)
        {
            var scripts = new List<ClientScript>();
            if (type == UserTypes.Librarian || type == UserTypes.Customer)
            {
                /*
                scripts.Add(new ClientScript()
                {
                    Name = "docdelivery",
                    Content = GetContent("Scripts.docdelivery.js")
                });
                 */
            }
            return scripts;
        }
    }

    public class EntityOperationInspector : IEntityOperationInspector
    {
        private ISecurityService _securityService;
        private IEntityRepository _repository;

        public EntityOperationInspector(ISecurityService securityService, IEntityRepository repository)
        {
            _securityService = securityService;
            _repository = repository;
        }

        public InspectionResult Inspect(EntityOperation operation)
        {
            return InspectionResult.None;
        }
    }

    public class DocDeliveryOperationLogic : IEntityOperationLogic
    {
         private ISecurityService _securityService;
        private IEntityRepository _repository;

        public DocDeliveryOperationLogic(ISecurityService securityService, IEntityRepository repository)
        {
            _securityService = securityService;
            _repository = repository;
        }
        public void Before(EntityOperation operation, EntityOperationContext context)
        {
            //throw new NotImplementedException();
        }

        public void After(EntityOperation operation, EntityOperationContext context, EntityOperationResult result)
        {
            //throw new NotImplementedException();
        }
    }
}
