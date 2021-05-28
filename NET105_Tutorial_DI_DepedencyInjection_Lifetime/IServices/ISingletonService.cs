using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_DI_DepedencyInjection_Lifetime.IServices
{
    public interface ISingletonService
    {
        Guid Getid();
    }
}
