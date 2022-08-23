using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NoteQuestOnline.Models;

namespace NoteQuestOnline.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Adventurer> Adventurers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<AdventurerClass> AdventurerClasses { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<SpellEffect> SpellEffects { get; set; }
    }
}