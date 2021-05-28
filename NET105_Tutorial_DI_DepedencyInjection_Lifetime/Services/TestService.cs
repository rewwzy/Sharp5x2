using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_DI_DepedencyInjection_Lifetime.IServices;
namespace NET105_Tutorial_DI_DepedencyInjection_Lifetime.Services
{
    public class TestService:ITransientService,IScopeService,ISingletonService
    {
        private Guid _guid;
        public TestService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid Getid()
        {
            return _guid;
        }
    }
}
