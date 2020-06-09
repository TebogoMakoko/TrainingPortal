using System;

namespace Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string Amount { get; set; }
        public DateTime DateCreated { get; set; }

        public Guid? PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
