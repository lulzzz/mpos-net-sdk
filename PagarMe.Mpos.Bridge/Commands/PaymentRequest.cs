﻿using System;

namespace PagarMe.Mpos.Bridge.Commands
{
    internal class PaymentRequest
    {
        public ProcessPaymentRequest Process { get; set; }
        public FinishPaymentRequest Finish { get; set; }
        public InitializeRequest Initialize { get; set; }
        public DisplayMessageRequest DisplayMessage { get; set; }

        public String ContextId { get; set; }
        public Type RequestType { get; set; }

        public enum Type
        {
            UnknownCommand = 0,
            ListDevices = 1,
            Initialize = 2,
            Process = 4,
            Finish = 5,
            DisplayMessage = 6,
            Status = 7,
            Close = 8,
        }
    }
}