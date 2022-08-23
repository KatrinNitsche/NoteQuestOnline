using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public class SpellRepository : BaseRepository<Spell>
    {
        public SpellRepository(ApplicationDbContext context) : base(context) { }

        public override IEnumerable<Spell> GetAll() => Context.Spells;

        public override IQueryable<Spell> GetAll(bool asyn = true) => Context.Spells;

        public override Spell GetById(Guid id) => Context.Spells.FirstOrDefault(a => a.SpellId == id);
    }
}
