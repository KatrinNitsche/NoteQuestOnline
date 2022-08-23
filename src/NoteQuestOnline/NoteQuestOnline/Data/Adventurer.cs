using System.ComponentModel.DataAnnotations;

namespace NoteQuestOnline.Data
{
    public class Adventurer
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public Race Race {get;set; }
        [Required] public AdventurerClass Class { get; set; }
    }

    public class Race
    {
        [Key] public Guid RaceId { get; set; }
        [Required] public string Name { get; set; }
        public int Hitpoints { get; set; }
    }

    public class AdventurerClass
    {
        [Key] public Guid ClassId { get; set; }
        [Required] public string Name { get; set; }
        public int HitpointsModifier { get; set; }
    }

    public class Spell
    {
        [Key] public Guid SpellId { get; set; }
        [Required] public string Name { get; set; }
        public int PointsModifier { get; set; }
        public SpellEffect Effect { get; set; }
    }

    public class SpellEffect
    {
        [Key] public Guid SpellId { get; set; }
        [Required] public string Description { get; set; }
        public EffectType EffectType { get; set; }
    }

    public enum EffectType { Damage, Heal, Torch, Teleport }
}
