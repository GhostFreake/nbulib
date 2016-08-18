using NbuLibrary.Core.Domain;
using NbuLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuLibrary.Modules.DocDelivery
{
    public class EntityQueryInspector : IEntityQueryInspector
    {
        private ISecurityService _securityService;

        public EntityQueryInspector(ISecurityService securityService)
        {
            _securityService = securityService;

        }

       
    }
}
