using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public class AdventurerClassRepository : BaseRepository<AdventurerClass>
    {
        public AdventurerClassRepository(ApplicationDbContext context) : base(context) { }

        public override IEnumerable<AdventurerClass> GetAll() => Context.AdventurerClasses;

        public override IQueryable<AdventurerClass> GetAll(bool asyn = true) => Context.AdventurerClasses;

        public override AdventurerClass GetById(Guid id) => Context.AdventurerClasses.FirstOrDefault(a => a.ClassId == id);
    }
}
