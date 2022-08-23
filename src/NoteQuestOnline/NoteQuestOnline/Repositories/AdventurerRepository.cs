using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public class AdventurerRepository : BaseRepository<Adventurer>
    {
        public AdventurerRepository(ApplicationDbContext context) : base(context) { }

        public override IEnumerable<Adventurer> GetAll() => Context.Adventurers;

        public override IQueryable<Adventurer> GetAll(bool asyn = true) => Context.Adventurers;

        public override Adventurer GetById(Guid id) => Context.Adventurers.FirstOrDefault(a => a.Id == id);
    }
}
