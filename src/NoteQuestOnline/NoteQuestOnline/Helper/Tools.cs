namespace NoteQuestOnline.Helper
{
    public static class Tools
    {
        private static Random random { get; set; } = new Random();

        private static int RoleDice(int sites)
        {
            return random.Next(sites) + 1;
        }
    }
}
