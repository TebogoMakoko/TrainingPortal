using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class TrainingType : AuditEntity
    {
        public TrainingType()
        {
            this.Trainings = new List<Training>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
    }
}
