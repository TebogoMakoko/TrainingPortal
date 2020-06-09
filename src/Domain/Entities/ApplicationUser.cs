using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Enrolments = new List<Enrolment>();
            this.Trainings = new List<Training>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }

        public IEnumerable<Enrolment> Enrolments { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
