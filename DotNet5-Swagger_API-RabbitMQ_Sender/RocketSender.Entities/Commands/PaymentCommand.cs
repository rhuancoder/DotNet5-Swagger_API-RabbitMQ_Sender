using System;

namespace RocketSender.Entities
{
    public class PaymentCommand
    {

        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal Value { get; set; }
        public PayerCommand Payer { get; set; }
    }
}