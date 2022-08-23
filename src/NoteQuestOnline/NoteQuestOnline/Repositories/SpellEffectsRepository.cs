using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public class SpellEffectsRepository : BaseRepository<SpellEffect>
    {
        public SpellEffectsRepository(ApplicationDbContext context) : base(context) { }

        public override IEnumerable<SpellEffect> GetAll() => Context.SpellEffects;

        public override IQueryable<SpellEffect> GetAll(bool asyn = true) => Context.SpellEffects;

        public override SpellEffect GetById(Guid id) => Context.SpellEffects.FirstOrDefault(a => a.SpellId == id);
    }
}
