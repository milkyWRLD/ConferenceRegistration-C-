using Microsoft.EntityFrameworkCore;
using ConferenceRegistration.Server.Models;


namespace ConferenceRegistration.Server.Data
{
    /// <summary>
    /// Контекст базы данных для приложения конференции
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{
}

        /// <summary>
        /// Набор данных для участников
        /// </summary>
        public DbSet<Participant> Participants { get; set; }  // Таблица участников конференции
    }
}
