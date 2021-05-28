using System;

namespace NET105_Tutorial_DI_DepedencyInjection_Lifetime.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
