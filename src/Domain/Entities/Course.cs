using Domain.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Domain.Entities
{
    public class Course : AuditEntity
    {
        public Course()
        {
            this.Enrolments = new List<Enrolment>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }
        
        public IEnumerable<Enrolment> Enrolments { get; set; }

        public Guid? CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
    }
}
