using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Enrolment : AuditEntity
    {
        public Guid Id { get; set; }

        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Guid? CourseId { get; set; }
        public Course Course { get; set; }

        public Guid? TrainingId { get; set; }
        public Training Training { get; set; }

        public Guid? PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
