using System.Collections.Generic;

namespace Web_API.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Rutvik";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgEnumClass Class { get; set; } = RpgEnumClass.Kinght;
        public User User{ get; set; }
        public Weapon Weapon { get; set; }
        public List<Skill> Skills{ get; set; }

        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
