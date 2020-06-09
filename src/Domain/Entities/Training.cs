using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Training : AuditEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid? TrainingTypeId { get; set; }
        public TrainingType TrainingType { get; set; }

        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Guid? CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
    }
}
