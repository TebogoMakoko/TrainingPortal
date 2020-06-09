using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PaymentType : AuditEntity
    {
        public PaymentType()
        {
            this.Payments = new List<Payment>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
    }
}
