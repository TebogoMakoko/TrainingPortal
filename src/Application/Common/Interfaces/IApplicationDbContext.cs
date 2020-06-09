using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Catalogue> Catalogues { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Enrolment> Enrolments { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<PaymentType> PaymentTypes { get; set; }
        DbSet<Training> Trainings { get; set; }
        DbSet<TrainingType> TrainingTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
