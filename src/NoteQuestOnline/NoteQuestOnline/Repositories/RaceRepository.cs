using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public class RaceRepository : BaseRepository<Race>
    {
        public RaceRepository(ApplicationDbContext context) : base(context) { }

        public override IEnumerable<Race> GetAll() => Context.Races;

        public override IQueryable<Race> GetAll(bool asyn = true) => Context.Races;

        public override Race GetById(Guid id) => Context.Races.FirstOrDefault(a => a.RaceId == id);
    }
}
