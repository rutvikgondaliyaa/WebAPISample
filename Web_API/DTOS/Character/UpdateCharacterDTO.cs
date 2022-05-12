using Web_API.Models;

namespace Web_API.DTOS.Character
{
    public class UpdateCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Rutvik";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgEnumClass Class { get; set; } = RpgEnumClass.Kinght;
    }
}
