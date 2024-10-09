using MassPersonaAssessment.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MassPersonaAssessment.Data
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions options) : base(options) { }
        public DbSet<Review> Reviews { get; set; }
    }
}
