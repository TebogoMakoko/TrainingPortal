using Domain.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Domain.Entities
{
    public class Catalogue : AuditEntity
    {
        public Catalogue()
        {
            this.Courses = new List<Course>();
            this.Trainings = new List<Training>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
